﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindMaximumByGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine($"Maximum number is {program.findmaxnumber(999, 569, 478)}");
        }
        public int findmaxnumber(int num1, int num2, int num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {
                return num1;
            }
            else if (num2.CompareTo(num3) > 0 && num2.CompareTo(num1) > 0)
            {
                return num2;
            }
            else
            {
                return num3;  
            }
        }
    }
}