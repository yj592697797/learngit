﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnVSGit
{
    class Program
    {
        static void Main(string[] args)
        {
            //master update
            Console.WriteLine("Hello world!123");
        }

        /// <summary>
        /// dev update
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private void add(int a, int b) { }

        /// <summary>
        /// 分支特有
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private void min(int a, int b) { }

        /// <summary>
        /// 主分支共有
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private void max(int a, int b) { }

        private void max2() { }

        private void max3() { }
    }
}
