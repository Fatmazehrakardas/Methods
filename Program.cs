using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // [Access level] <return value> method name(method parameters){method body}
            // A return type of a method is not part of the signature of the method for the purposes of method overloading.
            int a = 2;
            int b = 3;
            Console.WriteLine(a + b);

            int result = Topla(a, b);
            Console.WriteLine(result);

            Methods methods = new Methods();
            methods.PrintScreen(Convert.ToString(result));

            int result2 = methods.İncreasegather(ref a, ref b);
            methods.PrintScreen(Convert.ToString(result2));
            methods.PrintScreen(Convert.ToString(a + b));
        }
        static int Topla(int value1, int value2)

        {
            return (value1 + value2);
        }
    }
    class Methods
    {
        public void PrintScreen(string data)
        {
            Console.WriteLine(data);
        }

        public int İncreasegather(ref int value1, ref int value2)
        {
            value1 += 1;
            value2 += 1;
            return value1 + value2;
        }

        // REF:The ref keyword in C# is used for passing or returning references of values to or from Methods.
        // Basically, it means that any change made to a value that is passed by reference will reflect this change since you are modifying the value at the address and not just the value.
    }
}
