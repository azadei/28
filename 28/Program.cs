using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
       
        string[] items = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

        
        var arrangedList = items.OrderBy(item => item.Length)
                                .ThenBy(item => item);

       
        Console.WriteLine("Here is the arranged list:");
        foreach (var item in arrangedList)
        {
            Console.WriteLine(item);
        }

    }
}