using System;

namespace next {
	public class Circle {
		public int x;
		public int y;
		public double r;
	
	}

	class CircleTest{
		static void Main(String[] args) {
			Circle c1, c2;
			c1 = new Circle ();
			c2 = new Circle ();
			String tempstr;

			Console.WriteLine ("원충돌 테스트");
			Console.Write ("circle1 x? ");
			tempstr = Console.ReadLine();
			c1.x = Convert.ToInt32 (tempstr);
			Console.Write ("circle1 y? ");
			tempstr = Console.ReadLine ();
			c1.y = Convert.ToInt32 (tempstr);
			Console.Write ("circle1 r? ");
			tempstr = Console.ReadLine ();
			c1.r = Convert.ToDouble (tempstr);

			Console.Write ("circle2 x? ");
			tempstr = Console.ReadLine ();
			c2.x = Convert.ToInt32 (tempstr);
			Console.Write ("circle2 y? ");
			tempstr = Console.ReadLine ();
			c2.y = Convert.ToInt32 (tempstr);
			Console.Write ("circle2 r? ");
			tempstr = Console.ReadLine ();
			c2.r = Convert.ToDouble (tempstr);





			if (Math.Pow (c1.x-c2.x, 2) + Math.Pow(c1.y-c2.y, 2) <= Math.Pow(c1.r+c2.r, 2))
				Console.WriteLine ("두 원은 충돌합니다.");
			else
				Console.WriteLine ("두 원은 충돌하지 않습니다.");
		}
	}
}
