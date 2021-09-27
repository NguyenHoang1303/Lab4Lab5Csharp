﻿using System;

namespace Lab5_P1_4
{
    
    internal class Program
    {
        public static int AnExceptionFunction(int value)
        {
            if (value == 0) // Can&#39;t divide by zero
                throw new DivideByZeroException("Divide By 0 error!");
            int x = 20 / value;
            return x;
        }
        
        public static void Main(string[] args)
        {
            int value = 0;
            try
            {
                value = AnExceptionFunction(10); // This works ok
                Console.WriteLine("Value = {0}", value);
                AnExceptionFunction(0); // This doesn&#39;t
                Console.WriteLine("Value = {0}", value);
            }
            catch (Exception e)
            {
                Console.WriteLine("Caught an exception {0}. Continuing", e);
            }
        }
    }
}