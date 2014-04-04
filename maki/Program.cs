using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maki
{
	class Program
	{
		static void Main(string[] args)
		{
			var maki = new SchoolIdol(μs.真姫);
			Console.WriteLine("マキ、" + maki.年齢 + "歳♡\n将来はパパとママの跡を継いで医者になるつもりだから、本当はアイ活してる時間なんて本当はないんだけど、こーんなにカワイイのにアイドルにならないなんてもったいないじゃナイ？だからとりあえず、青春の思い出に参戦♡趣味は" +maki.趣味+ "、今1番欲しい物は"+maki.今1番欲しい物+"、特技は" +maki.特技+"、あとは──アピールポイントはなんだっけな。あ、こう見えて彼氏いない歴" + maki.彼氏いない歴 + "年よ！");
			Console.ReadLine();
		}
	}
}
