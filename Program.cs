using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2,temp,prime,j;

        Console.WriteLine ("please enter start and end value") ;

            n1 = int.Parse(Console.ReadLine());

                n2 = int.Parse(Console.ReadLine());
            if(n1>n2)
            { temp = n1;
                n1 = n2;
                n2 = temp;
                    }
            
            for (int i=n1;i<=n2;i++)
                { if (i==0||i==1)
                    continue;
                prime = 0;
                for(j=2;j<i;j++)
                {
                    if (i%j==0)
                    {
                        prime = 1;
                        break;
                     
                    }
                }
                if (prime==0)
                {
                    Console.WriteLine(i);
                 }
                //esraa samir ibrahim
                }


                }
    }
}
  