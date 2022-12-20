using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        { 
                int n1, n2;

                Console.Write("Enter first num: ");
                n1 = int.Parse(Console.ReadLine());

                Console.Write("Enter last: ");
                n2 = int.Parse(Console.ReadLine());

                for (int i = n1; i <= n2; i++)
                {

                    int sum = 0;           

                    for (int j = 1; j < i; j++)            
                    {                           
                        if (i % j == 0)               
                            sum += j;
                    }                           

                    if (sum  == i)              
                        Console.Write(sum + " ");           
                }

                Console.Write("\n");
            }
        
    }
}
