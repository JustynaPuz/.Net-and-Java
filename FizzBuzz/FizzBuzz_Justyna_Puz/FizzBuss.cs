using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_Justyna_Puz
{
    internal class FizzBuss
    {
        int number = 0;

        public FizzBuss(int number)
        {
            this.number = number;
        }
        public void Display()
        {
            for (int i = 1; i < number; i++)
            {
                if(i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("FizzBuss");
                }else if( i % 5 == 0 )
                {
                    Console.WriteLine("Buzz");

                }else if(i % 3 == 0){
                    Console.WriteLine("Fizz");
                }else
                {
                    Console.WriteLine(i);              
                }       
            }

        }
    }
}
