using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.App.Two
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine($"This is the output of Console.App.Two: ");
            System.Console.WriteLine($"Server Name: {Environment.MachineName}");
            System.Console.WriteLine($"Server Time: {DateTime.Now}");
            System.Console.WriteLine("Cool! This console application is running! Now you can press anything to exit:");
            System.Console.ReadLine();
        }
    }
}
