using System;

namespace next {
	class Ex2 {
		static void Main (string[] args) {
			string m1, m2, m3;
			Console.Write ("이름? ");
			m1 = Console.ReadLine ();
			Console.Write ("밑변? ");
			m2 = Console.ReadLine ();
			Console.Write ("높이? ");
			m3 = Console.ReadLine ();

			int x = Convert.ToInt32 (m2);
			int y = Convert.ToInt32 (m3);
			double total = 0;
			total = Convert.ToDouble(x * y / 2);
			Console.WriteLine ("{0}의 넓이 = {1}", m1, total);
		}
	}
}
