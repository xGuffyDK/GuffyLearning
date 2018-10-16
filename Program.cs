using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = false;
            bool isTall = true;

            if (isMale && !isTall)
            {

                Console.WriteLine("You are male and tall");
            } else if (!isTall && !isMale)
            {
                Console.WriteLine("You are not male and nor are you tall.");
            } else if (!isMale && isTall)   
            {
                Console.WriteLine("HEY TEST");
            }

            Console.ReadLine(); 
        }
    }
}
