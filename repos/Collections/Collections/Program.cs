
using System;
using System.Collections.Generic;


    class Program
    {
        public static void Main(string[] args)
        {
        Dictionary<int,string> dict = new Dictionary<int,string>();

        dict.Add(1, "Hello");
        dict.Add(15, "Orange");
        dict.Add(20, "Mango");

        dict.Remove(1);
        if (dict.TryGetValue(1, out string value))
            Console.WriteLine(value);
        else
            Console.WriteLine("failure");

        dict[1] = "World";
        dict[5] = "Hi";
        
        
        foreach(var o in dict)
            Console.WriteLine(o);
        Console.ReadLine();
           

        }
    }

