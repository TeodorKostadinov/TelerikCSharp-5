using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a program that prints to the console
//which day of the week is today. Use System.DateTime.


namespace _03.PrintDay
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("Today is {0}", today.DayOfWeek);
        }
    }
}