using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace таск_5
{
    class Strings
    {
        string[] arr = new string[35];
        int kilkist;
        public void input(StreamReader sw)
        {
            int i = 0;
            while (sw.Peek() != -1)
            {
                arr[i] = sw.ReadLine();
                i++;
            }
            kilkist = i;
        }

        public void output()
        {
            for(int i = 0; i < kilkist; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public void change()
        {
            for (int i = 0; i < kilkist; i++)
            {
                arr[i] = arr[i].Replace('<', '#');
            }

            for (int i = 0; i < kilkist; i++)
            {
                arr[i] = arr[i].Replace('>', '#');
            }
        }
    }
}

