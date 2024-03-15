using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BictConsoleApp
{
    public class Student
    {
        public void DisplayResult() //method or function
        {
            float score = 80.5F;
            if (score >= 99 && score <= 100)
            {
                Console.WriteLine("grade A+");
            }
            else if (score >= 80)
            {
                Console.WriteLine(" grade A");
            }
            else
            {
                Console.WriteLine("Failed"); //System.out.println("Failed"); [in java]
            }
        }

        public void Calculate()
        {
            int i = 5;
            int j = 5;

            int k = i + j;
            Console.WriteLine("Addition:" + k);

            k = i - j;
            Console.WriteLine("Subtraction:" + k);

            k = i * j;
            Console.WriteLine("Multiplication:" + k);

            k = i / j;
            Console.WriteLine("Division:" + k); 

            k = i % j;
            Console.WriteLine("Remainder:" + k); //Modulo
        }

    }

}
