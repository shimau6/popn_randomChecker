using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popn_randomChecker
{
    class Result
    {
        public int ramPattern;
        public List<int> Patterns = new List<int>();

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
