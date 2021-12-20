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

            Console.WriteLine("1)Maximum in Integer   2)Maximum in Float    3)Maximum in String");
            Console.WriteLine("---------------------------------------------------");
            Console.Write("Enter your choice : ");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    FindMaxValue<int>.ShowMax();
                    break;
                case 2:
                    FindMaxValue<float>.ShowMax();
                    break;
                case 3:
                    FindMaxValue<string>.ShowMax();
                    break;
                default:
                    Console.WriteLine("Invalid Choice !!!");
                    break;
            }

        }
    }
}