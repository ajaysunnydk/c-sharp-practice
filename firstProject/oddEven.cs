using System;

namespace firstProject
{
    internal class oddEven
    {
        static void main(string[] args)
        {
            int num;
            Console.WriteLine("Enter any Number: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Number is "+num);
            if (num%2 == 0)
            {
                Console.WriteLine(num+" is Even");
            }
            else
            {
                Console.WriteLine(num+" is Odd");
            }
            Console.ReadKey();
        }
    }
}
