using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {

            // AddTwoNumbers(20, 6);
            //DivideTwoNumbers(20, 6);

            //kalkulaator:
            Console.WriteLine("Sisesta esimene arv:");
            int userNumberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta teine arv:");
            int userNumberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("vali tehe (sisesta '+', '-', '*' või '/')");
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch (userOperator)
            {
                case '+':
                    AddTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '/':
                    DivideTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '*':
                    MultiplyTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '-':
                    SubstractTwoNumbers(userNumberOne, userNumberTwo);
                    break;

                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }

        }

        public static void AddTwoNumbers(int x, int y) //public, siis võib mujal kasutada, kasutame private siis siin ainult
        {
            int result = x + y;
            Console.WriteLine(result);
        }

        public static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y; //teist tüüpi kümnendarv: decimal (see on aeglasem, aga täpsem kui double)
            Console.WriteLine(result);
        }

        //sooritab lahutamist subtraction

        //korrutamine multiplication

        public static void MultiplyTwoNumbers(double x, double y)
        {
            double result = x * y;
            Console.WriteLine(result);
        }

        public static void SubstractTwoNumbers(int x, int y)
        {
            int result = x - y;
            Console.WriteLine(result);
        }
    }
}
