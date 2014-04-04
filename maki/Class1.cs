using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maki
{
	public enum μs
	{
		穂乃果, 絵里, ことり, 海未, 凛, 真姫, 希, 花陽, にこ
	}

	public class SchoolIdol
	{
		public int 年齢 { get; private set; }
		public int 彼氏いない歴 { get; private set; }
		public string 趣味 { get; private set; }
		public string 特技 { get; private set; }
		public string 今1番欲しい物 { get; private set; }
		// 続く

		public SchoolIdol(μs name)
		{
			switch(name)
			{
				case μs.絵里:
				case μs.にこ:
				case μs.希:
					年齢 = 17;
					彼氏いない歴 = 年齢;
					break;
				case μs.海未:
				case μs.穂乃果:
				case μs.ことり:
					年齢 = 16;
					彼氏いない歴 = 年齢;
					break;
				case μs.花陽:
				case μs.凛:
					年齢 = 15;
					彼氏いない歴 = 年齢;
					break;
				case μs.真姫:
					// 他は知らん
					年齢 = 15;
					彼氏いない歴 = 17;
					趣味 = "買い物";
					特技 = "開脚";
					今1番欲しい物 = "お兄ちゃん";
					break;

			}
		}
	}
}
