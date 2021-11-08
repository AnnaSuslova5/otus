using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Itask task = new TaskString();
            Tester tester = new Tester(
                task,
                @"E:\Загрузка\A01_Счастливые_билеты-1801-057a77\0.String"
                );
            tester.RunTests();
            Console.ReadKey();
        }
    }
