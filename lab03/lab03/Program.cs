using System;
namespace next {
	public class Student {
		public string name ;
		public int kor ;
		public int math;
		public double avg;
	}

	class Test{
		static void Main(String[] args){
			Student s1, s2;
			s1 = new Student();
			s2 = new Student();

			s1.name = "Lim";
			s1.kor = 80;
			s1.math = 90;
			s1.avg = Convert.ToDouble (s1.kor + s1.math) / 2;

			s2.name = "Lee";
			s2.kor = 90;
			s2.math = 100;
			s2.avg = Convert.ToDouble (s2.kor + s2.math) / 2;

			double tavg = 0;
			tavg = Convert.ToDouble ((s1.avg + s2.avg) / 2);

			Console.WriteLine("{0}의 평균은 {1} 입니다.", s1.name, s1.avg);
			Console.WriteLine("{0}의 평균은 {1} 입니다.", s2.name, s2.avg);
			Console.WriteLine("{0}과 {1}의 전체 평균은 {2} 입니다.", s1.name, s2.name, tavg);
		}
	}
}