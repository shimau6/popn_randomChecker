using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popn_randomChecker
{
    class Result
    {
        //無理押しチェッカーで得られた結果を格納するだけ
        
        public int ramPattern; //ランダムのパターン　例:124365879 938471526
        public List<int> Patterns = new List<int>();//無理押しパターンのリスト　格納例:258,1469

        public Result(int ram)
        {
            ramPattern = ram;
        }

        public Result(int ram, List<int> patterns)
        {
            ramPattern = ram;
            Patterns = patterns;
        }

        public void AddPattern(List<int> patterns)
        {
            Patterns.AddRange(patterns);
        }

        public override string ToString()
        {
            string a = ramPattern.ToString();

            return "Pat:" + ramPattern.ToString()
                + " Count;" + Patterns.Count;
        }
    }
}
