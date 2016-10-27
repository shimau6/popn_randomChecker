using System.Collections.Generic;

namespace popn_randomChecker
{

    class ConvertTextClass
    {
        public ConvertTextClass()
        {
            //なにもない
        }

        //.txtのあるURLを入れたらList<PatternData>が返ってくるやつ
        //ねむくなってきた
        public List<PatternData> ConvertToList(string textUrl)
        {
            List<PatternData> list = new List<PatternData>();
            using (System.IO.StreamReader sr = new System.IO.StreamReader(textUrl))
            {
                //読み込んだ.txtの内容を一行ずつ読み込む
                while (sr.Peek() > -1)
                {
                    int num = int.Parse(sr.ReadLine());
                    if(hasSamePattern(num,list) == false)
                    {
                        list.Add(new PatternData(num));
                    }
                }
            }
            return list;
        }

        //重複しているパターンがあるかどうかを探す
        //重複しているパターンがあったらtrueを返す
        private bool hasSamePattern(int num,List<PatternData> list)
        {
            foreach(var r in list)
            {
                if (r.isSameData(num))
                {
                    return true;
                }
            }
            return false;
        } 
    }
}
