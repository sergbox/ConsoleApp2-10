using System;
using System.ServiceModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2_9;

namespace Client
{
    internal class Client
    {
        static void Main(string[] args)
        {
            CalculatorClient client = new CalculatorClient();
            double value1 = 70.00D;
            double value2 = 30.00D;
            double result = client.CalculateMethod1(value1, value2);
            Console.WriteLine($"CalculateMethod1({value1},{value2}) = {result}");
            // вызываем с помощью прокси метод сервиса Subtract()
            value1 = 88.70D;
            value2 = 17.50D;
            result = client.CalculateMethod2(value1, value2);
            Console.WriteLine($"CalculateMethod2({value1},{value2}) = {result}");
            client.Close();
            Console.WriteLine(" Нажмите < ENTER > для завершения работы клиента.");
            Console.ReadLine();
        }
    }
}
