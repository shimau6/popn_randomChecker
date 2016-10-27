using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popn_randomChecker
{

    class RandomChecker
    {
        public List<Result> checkMurioshiCount(List<PatternData> patterns)
        {
            List<Result> resultList = new List<Result>();
            int ramPattern;
            for (ramPattern = 123456788; ramPattern <= 987654321; ramPattern++)
            {
                if (isRamPatternInteger(ramPattern))
                {
                    Result result = new Result(ramPattern);
                    for (int i = 0;i < patterns.Count; i++)
                    {
                        result.AddPattern(murioshiCheck(ramPattern,patterns[i]));
                    }
                    resultList.Add(result);
                }
            }

            return resultList;
        }

        private List<int> murioshiCheck(int ramPattern,PatternData p)
        {
            var list = new List<int>();
            string s = ramPattern.ToString();
            bool[] ramd = new bool[9];
            for (int i = 0; i < 9; i++)
            {
                ramd[i] = p.boolArrayData[int.Parse(s[i].ToString()) - 1];
            }

            if (isMurioshi(ramd))
            {
                int addition = boolArrayToIntPattern(ramd);
                for (int i = 0; i < p.count; i++)
                {
                    list.Add(addition);
                }
            }
            return list;
        }

        private bool isRamPatternInteger(int num)
        {
            string s = num.ToString();
            List<int> nlist = new List<int>();
            int n;
            for (int i = 0; i < 9; i++)
            {
                n = int.Parse(s[i].ToString());
                if (n == 0) return false;
                if (nlist.IndexOf(n) >= 0) return false;
                nlist.Add(n);
            }
            return true;
        }

        private bool isMurioshi(bool[] b)
        {
            int c = 0;
            for (int i = 0; i < 9; i++)
            {
                if (b[i] == true)
                {
                    if (c < 2)
                    {
                        c++;
                        if (i + 2 < 9) i += 2;
                        else break;
                    }
                    else
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private int boolArrayToIntPattern(bool[] b)
        {
            string ans = "";
            for (int i = 0; i < 9; i++)
            {
                if(b[i] == true)
                {
                    ans += (i + 1).ToString();
                }
            }
            return int.Parse(ans);
        }
    }
}
