﻿using System;

namespace iterationProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("type your name: ");
                var input = Console.ReadLine();
                
                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                
                break;
            }
        }
    }
}
