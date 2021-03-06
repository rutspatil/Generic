using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumGenerics
{
    internal class Maximum
    {
        public static void FindIntMax(int num1, int num2, int num3)
        {
            if (num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) >= 0)
                Console.WriteLine($"Max value is: {num1}");
            else if (num2.CompareTo(num3) >= 0)
                Console.WriteLine($"Max value is: {num2}");
            else
                Console.WriteLine($"Max value is: {num3}");
        }

        /// <summary>
        /// Finds Max of 3 floats
        /// </summary>
        public static void FloatMax(float num1, float num2, float num3)
        {
            if (num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) >= 0)
                Console.WriteLine($"Max value is: {num1}");
            else if (num2.CompareTo(num3) >= 0)
                Console.WriteLine($"Max value is: {num2}");
            else
                Console.WriteLine($"Max value is: {num3}");
        }
        /// <summary>
        /// Finds Max of 3 strings
        /// </summary>
        public static void StringMax(string str1, string str2, string str3)
        {
            if (str1.CompareTo(str2) >= 0 && str1.CompareTo(str3) >= 0)
                Console.WriteLine($"Max value is: {str1}");
            else if (str2.CompareTo(str3) >= 0)
                Console.WriteLine($"Max value is: {str2}");
            else
                Console.WriteLine($"Max value is: {str3}");
        }
    }
}