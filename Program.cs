using System;

namespace task1101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Telebe fullname qeyd edin!");
            string student1Fullname = Console.ReadLine();
            //Console.WriteLine("Telebenin ad gununu daxil edin!");
            //DateTime birthday = Console.ReadLine();
            Console.WriteLine("Telebenin groupNo qeyd edin");
            string student1GroupNO = Console.ReadLine();
            //int student1GroupNO = Convert.ToInt32(student1GroupNOStr);
            Console.WriteLine("Telebe Point qeyd edin!");
            string student1PointStr = Console.ReadLine();
            int student1Point = Convert.ToInt32(student1PointStr);
            Student student1 = new Student(student1Fullname,student1GroupNO,student1Point);
            student1.ShowInfo();


            ///Fullname, BirthDate, GroupNo, Point xüsusiyyətlərinə və ShowInfo metoduna sahib Student class yaradırsınız.
            //FullName və Point dəyəri təyin olunmamış student obyekti yaradıla bilməz.
            //Proqram açıldıqda bizdən tələbə yaratmaq üçün datalar daxil etməyimizi istyir,
            //daxil edib tələbə obyektini yaradırıq və Shoüİnfo metodu ilə içindəki məlumatlara baxırıq
        }
    }
}

