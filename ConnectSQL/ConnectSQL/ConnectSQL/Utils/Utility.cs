using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectSQL.Utils
{
    public class Utility
    {
        public static int ReadInt()
        {
            int value;
            while(true)
            {
                try
                {
                    value = Convert.ToInt32(Console.ReadLine());
                    return value;
                }
                catch(Exception e)
                {
                    Console.WriteLine("Nhap lai!!!!");
                }
            }

        }
    }
}
