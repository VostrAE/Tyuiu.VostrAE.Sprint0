﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VostrAE.Sprint0.Task2.V0.Lib;

namespace Tyuiu.VostrAE.Sprint0.Task0.Vo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Саша"));
            Console.ReadKey();
            
        }
    }
}
