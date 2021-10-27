using System;
using System.IO;

namespace таск_5
{
    class Program
    {
        static int Menu()
        {
            int a;
            Console.WriteLine("Your choice:" + "\n1.Normal matrix" + "\n2.For n proection" + "\n3.For m proection" + "\n4.For p proection"
                + "\n5.EXIT");
            a = Convert.ToInt32(Console.ReadLine());
            return a;
        }

        static void Main(string[] args)
        {
            Matrix m = new Matrix();
            m.Input();
            int b;
            do
            {
                b = Menu();
                switch (b)
                {
                    case 1:
                        m.Output_all();
                        break;
                    case 2:
                        m.For_n();
                        break;
                    case 3:
                        m.For_m();
                        break;
                    case 4:
                        m.For_p();
                        break;
                    case 5:
                        Console.WriteLine("It was a pleasure to see you!");
                        break;
                    default:
                        Console.WriteLine("Wrong input!");
                        break;
                }
            } while (b != 5);
        }
    }
}
