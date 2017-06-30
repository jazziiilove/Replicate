/* 
 * One method that replicates a string a given number of times (e.g. ("Hi", 3) gives "HiHiHi")
 * Programmer: Baran Topal 
 * Solution name: Replicate 
 * Project name: Replicate
 * File name: Program.cs
 * Status: Finished
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Replicate
{
    /// <summary>
    /// Program replicating the given string by 3
    /// </summary>
    class Program
    {
        #region methods

        /// <summary>
        /// Replicating the given string by 3
        /// </summary>
        public static void Reqlicate()
        {
            StringBuilder s = new StringBuilder();

            //inserting the given string 3 times in the given index
            s.Insert(0, "bye", 3);

            //Another way:
            //Console.WriteLine(string.Concat(ArrayList.Repeat("Hi", 3).ToArray()));

            Console.WriteLine(s);
        }

        /// <summary>
        /// Main gate
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Reqlicate();
        }

        #endregion methods
    }
}
