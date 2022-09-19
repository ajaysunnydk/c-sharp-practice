using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProject
{
    internal class oddEven
    {
        static void main(string[] args)
        {
            int num;
            Console.WriteLine("Enter any Number: ");
            num = Console.Read();

            Console.WriteLine("Number is "+num);
            if (num%2 == 0)
            {
                Console.WriteLine(num+" is Even");
            }
            else
            {
                Console.WriteLine(num+" is Odd");
            }
        }
    }
}
