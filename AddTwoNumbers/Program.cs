﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers
{
    public class Program
    {
        public int Main(string[] args)
        {
            int a = Convert.ToInt32(args[1]);
            int b = Convert.ToInt32(args[2]);

            return this.add(a, b);
        }

        int add(int a, int b)
        {
            return (a + b);
        }
    }
}
