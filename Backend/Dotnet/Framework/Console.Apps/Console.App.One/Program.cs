using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.App.One
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine($"This is the output of Console.App.One: ");

            System.Console.WriteLine($"Server Name: {Environment.MachineName}");
            System.Console.WriteLine($"Server Time: {DateTime.Now}");

            //int addResult = MathOperation.Add(1, 2);
            //int multiplyResult = MathOperation.Multiply(1, 2);
            //System.Console.WriteLine($"Reference from Class.Lib.One (Add Result of 1 and 2 {addResult} | Multiply Result of 1 and 2: {multiplyResult})");

            System.Console.WriteLine("Cool! This console application is running! Now you can press anything to exit:");
            System.Console.ReadLine();
        }
    }
}
