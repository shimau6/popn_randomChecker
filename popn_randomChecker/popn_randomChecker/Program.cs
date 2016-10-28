using System;
using System.Collections.Generic;
using System.Linq;

namespace popn_randomChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            //args[0]で入力されたファイルのテキストを読み取ってこんばーと
            var cvt = new ConvertTextClass();
            var pat = cvt.ConvertToList(args[0]);

            //乱のすべてのパターンを試してそれぞれの無理押しの回数をカウントする
            var ranche = new RandomChecker();
            var res = ranche.checkMurioshiCount(pat);

            //無理押し回数の少ない順にオーダー
            var wei = res.OrderBy(r => r.Patterns.Count).ToList();

            //args[1]にそれを出力する
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
