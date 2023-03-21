using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConceptPrograms
{
    class EvenorOddcs
    {
    public static void FindEvenorOddcs
    {
        // declare variable
        int n;

        //take input
        Console.Write("Enter the number = ");
        n = Convert.ToInt32(Console.ReadLine());

        //check if n is even or odd
        // by doing bitwise AND operation
        // with 1. If the result is 0 then
        // n is even. If the result is 1 
        // then n is odd.
        if ((n & 1) == 0)
            Console.WriteLine(n + " is even");
        else
            Console.WriteLine(n + " is odd");

        // wait for user to press any key
        Console.ReadKey();
    }
}

