using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popn_randomChecker
{

    //ランダムチェッカー
    //メソッド名がなんかおかしい気がするけど眠かったんだろうなって
    class RandomChecker
    {
        //引数にList<PatternData>　※TextConvertでコンバートしたやつ　を入れるだけで
        //乱の全通りのパターンを試してそれぞれの無理押しをカウントして
        //その結果のリストList<Result>を返す
        //めｔｔｔｔｔｔｔｔｔｔｔｔっちゃ時間かかる
        public List<Result> checkMurioshiCount(List<PatternData> patterns)
        {
            List<Result> resultList = new List<Result>();
            int ramPattern;//123456789などの乱のパターンを格納する　intでもオーバーフローしなかった
            for (ramPattern = 123456788; ramPattern <= 987654321; ramPattern++)
            {
                //ramPatternの値が乱のパターンとして成立したら無理押し計算をする
                if (isRamPatternInteger(ramPattern))
                {
                    //与えられたパターンを全網羅して無理押し回数をチェックして
                    //その結果をList<Result>に格納する
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

        //無理押しをチェックする
        //帰ってくるList<int>には無理押しになった配置が含まれている
        //PatternData pのcountがもし2だった場合　List<int>には無理押しになった配置が２個入る
        //日本語がおかしい
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

        //123456789 948372615みたいな乱として成立しているintegerかどうかを考えるやつ
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

        //与えられたbool[]が無理押しだったらtrueを返す
        /*
        * b[0]から+1ずつチェックしていく
        * もしtrue（ポップ君が降ってくる場所)を見つけたら添え字+2に飛ぶ
        * これは片手で3つのポップ君が押せるから、片手で押せる範囲をチェックする必要はないってこと…？かな？
        * 
        * 飛んだ場所からまたチェックして、またそれを見つけたら飛んで
        * 更にもう一回見つけた場合、それは無理押しだと判断してtrueを返す
        */
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

        //bool[]をintに変える　これPatternDataクラスに入れたほうがいいかも
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
