using System;

namespace next {
		class Ex1 {
			static void Main (string[] args) {

			string name1, name2;
			int kor1, kor2;
			int math1, math2;
			double avg1, avg2, avg3;

			name1 = "임정민";
			name2 = "배철오";
			kor1 = 80;
			kor2 = 88;
			math1 = 90;
			math2 = 60;
			avg1=Convert.ToDouble(kor1+math1)/2;
			avg2=Convert.ToDouble(kor2+math2)/2;
			avg3 = Convert.ToDouble (((kor1 + kor2) / 2) + ((math1 + math2) / 2)) / 2;

			Console.WriteLine("{0}의 평균 = {1}", name1, avg1);
			Console.WriteLine("{0}의 평균 = {1}", name2, avg2);
			Console.WriteLine("전체과목평균 = {0}", avg3);
		}
	}
}