using System;
using System.Collections.Generic;
using System.Linq;

namespace popn_randomChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            var cvt = new ConvertTextClass();
            var pat = cvt.ConvertToList(args[0]);

            var ranche = new RandomChecker();
            var res = ranche.checkMurioshiCount(pat);

            var wei = res.OrderBy(r => r.Patterns.Count).ToList();

            System.IO.StreamWriter sw = new System.IO.StreamWriter(
            args[1],
            false,
            System.Text.Encoding.GetEncoding("shift_jis"));
            for (int i = 0; i < wei.Count(); i++)
            {
                sw.WriteLine(wei[i].ToString());

            }
            sw.Close();
        }

    }
}
