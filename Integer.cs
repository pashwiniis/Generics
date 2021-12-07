using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
     class FindMaxValue 
    {


        public static int FindMaxInteger(int first, int second, int third)
        {
            int result = first.CompareTo(second);
            int res = first.CompareTo(third);

            if ((first.CompareTo(second)>0) && (first.CompareTo(third)>0))
            {
                return first;
            }

            else if ((second.CompareTo(first)>0) && (second.CompareTo(third)>0))
            {
                return second;
            }

            else if ((third.CompareTo(first)>0) && (third.CompareTo(second)>0))
            {
                return third;
            }

            else
            {
                Console.WriteLine("All three numbers having same Value");
                return default;
            }
        }

        public static  float  FindMaxInteger(float first, float second, float third)
        {
            float result = first.CompareTo(second);
            float res = first.CompareTo(third);

            if ((first.CompareTo(second)>0) && (first.CompareTo(third)>0))
            {
                return first;
            }

            else if ((second.CompareTo(first)>0) && (second.CompareTo(third)>0))
            {
                return second;
            }

            else if ((third.CompareTo(first)>0) && (third.CompareTo(second)>0))
            {
                return third;
            }

            else
            {
                Console.WriteLine("All three numbers having same Value");
                return default;
            }
        }

        public static string FindMaxInteger(string first, string second, string third)
        {
            //string result = first.CompareTo(second);
            //string res = first.CompareTo(third);

            if ((first.CompareTo(second)>0) && (first.CompareTo(third)>0))
            {
                return first;
            }

            else if ((second.CompareTo(first)>0) && (second.CompareTo(third)>0))
            {
                return second;
            }

            else if ((third.CompareTo(first)>0) && (third.CompareTo(second)>0))
            {
                return third;
            }

            else
            {
                Console.WriteLine("All three numbers having same Value");
                return default;
            }
        }

    }
}
