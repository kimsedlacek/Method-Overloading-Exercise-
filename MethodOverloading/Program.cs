using System.Security.Cryptography.X509Certificates;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(12,53));
            Console.WriteLine(Add(2.5m, 6.2m));
            Console.WriteLine(Add(0,1, true));
        }   
            
            
            public static int Add(int num1, int num2)
            {
                return num1 + num2;
            }

            public static decimal Add(decimal num1, decimal num2)
            {
                return num1 + num2;
            }

        public static string Add(int num1, int num2, bool isTrue)
        {
                int dollarsAns = num1 + num2;

            if (dollarsAns > 1 && isTrue)
            {

                return $"{dollarsAns} dollars";
            }
            else if (dollarsAns == 1 && isTrue)
            {
                return $"{dollarsAns} dollar";
            }
            else
            {
                return dollarsAns.ToString();

            }
        }



    }
}
