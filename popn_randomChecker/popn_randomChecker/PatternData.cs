using System;

namespace popn_randomChecker
{
    //同時押しのデータを格納するクラス
    class PatternData
    {
        //bool[]型とint型のデータ
        //bool[] [9]の配列　ポップ君の落ちてくる場所をtrue　それ以外はfalse
        public bool[] boolArrayData { get; protected set; }
        //int ポップ君の落ちてくる場所の番号　例：左白左黄左緑=>123, 左白右白=>19
        public int intData { get; protected set; }
        //繰り返される回数
        public int count { get; protected set; } = 1;

        public PatternData(int intdata)
        {
            intData = intdata;
            boolArrayData = convertToBooleanArray(intdata);
        }

        //引数のデータと同じデータかを比較する
        //同じデータである場合count++
        public bool isSameData(int intdata)
        {
            bool isSame = (this.intData == intdata);

            if (isSame)
            {
                count++;
            }
            return isSame;
        }

        //intdataをbool配列に変換する
        private bool[] convertToBooleanArray(int num)
        {
            bool[] b = new bool[] {false, false, false, false, false, false, false, false, false};

            string s = num.ToString();
            for(int i = 0;i < s.Length; i++)
            {
                int acc = int.Parse(s[i].ToString());
                b[acc-1] = true;
            }
            
            return b;
        }

        public override string ToString()
        {
            return "Pattern : " + intData + Environment.NewLine
                + "Count :" + count;
        }
    }
}
