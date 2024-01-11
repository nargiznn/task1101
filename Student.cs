using System;
namespace task1101
{
	public class Student
	{
		public Student(string fullname,int point)
		{
			this.fullname = fullname;
			this.Point = point;

		}
		public Student(string fullname, string GroupNo,int point):this(fullname,point)
		{
			this.GroupNo = GroupNo;
		}
		public string fullname;
		public DateTime birthday;
		public string GroupNo;
		public int Point;
	

		public void ShowInfo()
		{
			Console.WriteLine($"Fullname: {this.fullname} GroupNo: {this.GroupNo}  Point: {this.Point}");
		}

        //Fullname, BirthDate, GroupNo, Point xüsusiyyətlərinə və ShowInfo metoduna sahib Student class yaradırsınız.
		//FullName və Point dəyəri təyin olunmamış student obyekti yaradıla bilməz.
		//Proqram açıldıqda bizdən tələbə yaratmaq üçün datalar daxil etməyimizi istyir,
		//daxil edib tələbə obyektini yaradırıq və Shoüİnfo metodu ilə içindəki məlumatlara baxırıq
    }
}

