using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************Welcome to GenericsConcept**************");

                      
            Console.WriteLine("The maximum Integer Value is " + FindMaxValue.FindMaxInteger(30, 46, 23));
            Console.WriteLine("The maximum Float Value is " + FindMaxValue.FindMaxInteger(3.6f,6.7f,2.3f));


        }
    }
}