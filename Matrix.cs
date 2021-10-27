using System;
using System.Collections.Generic;
using System.Text;

namespace таск_5
{
    class Matrix
    {
        int n, m, p;
        const int size = 100;
        int[,,] mat = new int[size, size, size];

        public void Input()
        {
            Console.WriteLine("\nYour size (3 numbers): ");
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            p = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int k = 0; k < p; k++)
                    {
                        Random numbers = new Random();
                        mat[i, j, k] = numbers.Next(0, 2);
                    }
                }
            }
        }

        public void For_n()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int k = 0; k < p; k++)
                    {
                        Console.Write("{0,2}", mat[i, 0, 0]);
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine(' ');
            }
        }

        public void For_m()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int k = 0; k < p; k++)
                    {
                        Console.Write("{0,2}", mat[0, j, 0]);
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine(' ');
            }
        }

        public void For_p()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int k = 0; k < p; k++)
                    {
                        Console.Write("{0,2}", mat[0, 0, k]);
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine(' ');
            }
        }

        public void Output_all()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int k = 0; k < p; k++)
                    {
                        Console.Write("{0,2}", mat[i, j, k]);
                    }

                    Console.WriteLine(" ");
                }
                Console.WriteLine(' ');
            }
        }
        

    }
}
