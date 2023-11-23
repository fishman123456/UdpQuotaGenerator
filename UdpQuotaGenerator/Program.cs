using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using UdpQuotaGenerator.Service;

namespace UdpQuotaGenerator
{
    internal class Program
    {
        // RunUdpQuotaGeneratorServer - процедура запуска сервера, работает согласно алгоритму
        static void RunUdpQuotaGeneratorServer(IPEndPoint serverEnpoint, IQuotaGenerator quotaGenerator)
        {

        }

        // RunUdpQoutaGeneratorClient - процедура запуска клиента, работает согласно алгоритму
        static void RunUdpQoutaGeneratorClient(IPEndPoint serverEnpoint, IPEndPoint clientEndPoint)
        {

        }

        // ReadAndParseIPEndPoint - вспомогательная процедура парсинга ep в виде <ip адрес>:<порт>
        static IPEndPoint ReadAndParseIPEndPoint(string message)
        {
            // 127.0.0.1:1024
            Console.Write(message);
            string str = Console.ReadLine();
            string[] strs = str.Split(":".ToCharArray());
            string ipStr = strs[0];
            int port = Convert.ToInt32(strs[1]);
            return new IPEndPoint(IPAddress.Parse(ipStr), port);
        }

        static void Main(string[] args)
        {
            // Задача: написать простой udp-сервер генератора цитат
            // который принимает входящие сообщения и отправляет в ответ случайную цитату

            // Написать простой клиент, который делает запрос к серверу и выводит ответ

            Console.WriteLine("1 - запустить сервер");
            Console.WriteLine("2 - запустить клиент");
            Console.Write("Ввод: ");
            string choice = Console.ReadLine();
            switch (choice) {
                case "1":
                    {
                        IPEndPoint serverEndPoint = ReadAndParseIPEndPoint("Введите ip:port сервера: ");
                        RunUdpQuotaGeneratorServer(serverEndPoint, new PlugQuotaGenerator());
                    }
                    break;
                case "2":
                    {
                        IPEndPoint serverEndPoint = ReadAndParseIPEndPoint("Введите ip:port сервера: ");
                        IPEndPoint clientEndPoint = ReadAndParseIPEndPoint("Введите ip:port клиента: ");
                        RunUdpQoutaGeneratorClient(serverEndPoint, clientEndPoint);
                    }
                    break;
                default:
                    Console.WriteLine("Недопустимый ввод");
                    break;
            }

        }
    }
}
