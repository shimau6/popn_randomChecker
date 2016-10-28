using System;
using System.Collections.Generic;
using System.Linq;

namespace popn_randomChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = @"C:\Users\shimau6\Desktop\murioshi.txt";
            string output = @"C:\Users\shimau6\Desktop\tmp.txt";
            var cvt = new ConvertTextClass();
            var pat = cvt.ConvertToList(input);

            var ranche = new RandomChecker();
            var res = ranche.checkMurioshiCount(pat);

            var wei = res.OrderBy(r => r.Patterns.Count).ToList();

            System.IO.StreamWriter sw = new System.IO.StreamWriter(
            output,
            false,
            System.Text.Encoding.GetEncoding("shift_jis"));
            sw.WriteLine("配置,無理押し回数,無理押し");
            for (int i = 0; i < wei.Count(); i++)
            {
                sw.WriteLine(wei[i].ToString());
            }
            sw.Close();
        }

    }
}
