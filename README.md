# popn_randomChecker  
ポップンのランダムで出る無理押し数を全探索でがんばって探すやつです。  
ソフトのダウンロードは下記URLから  
https://box.yahoo.co.jp/guest/viewer?sid=box-l-7huvxd4fcapywxb5ou3b3htjea-1001&uniqid=c4beaedd-9296-4e56-823e-67e88da0324a&viewtype=detail  
___________________________  
*使い方  
Samplesに入っているMurioshiCheck.exeをコマンドプロンプトから起動  
第一引数に入力する.txtファイル、第二引数に出力する.txtまたは.csvファイルを入力  
例：MurioshiCheck.exe C:\tmp\input.txt C:\tmp\output.txt  
この例だとC:\tmp\input.txtから導き出されたパターンをC:\tmp\output.txtに出力する  
_全探索なプログラム(362880通りの乱配置パターンを全て調べる)のため、計算に20分くらいはかかる気がする_  
  
*入力  
.txt形式  
中身には調べたい譜面に出てくる3つ以上の同時押し（無理押しになる可能性がある同時押し）をすべて書いてください  
例はSampleのニエンテフォルダに入ってます  
  
*出力  
.txtか.csv　他も色々いけると思う  
出力された中身は1列目が配置、2列目が無理押しのカウントで3列目以降は検出された無理押し配置です
Excelで色々いじれると信じています（未確認）  
出力例もSampleのニエンテフォルダに入ってます  
  
*その他  
無断二次配布は✕  
バグ発見したとか治したいとか改良云々あったらPullRequestしてくれれば反応するはずです。たぶん  
