using System;

namespace StudentClass {
    class Program {
        static void Main(string[] args) {


            var jada = new Student();
            jada.Name = "Jada";
            jada.Id = 1;
            jada.GPA = 3.5;
            jada.SAT = 1600;
            jada.TimesTardy = 112;
            Console.WriteLine($"Jada's name is {jada.Name} ");

            var steve = new Student();
            steve.Name = "Steve";
            steve.Id = 2;
            steve.SAT = 1599;
            steve.GPA = 4.0;
            steve.TimesTardy = 0;
            var steveString = steve.GetValues();
            Console.WriteLine($"Steve: {steveString}");
            Console.WriteLine($"Steve's BC score is {steve.BC(2)}");

            var dave = new Student("Dave", 3, 1, 1600, 3.8) ;
            var matt = new Student("Matt", 4, 2, 1598, 3.9) ;
            var jon = new Student("Dave", 5, 3, 1597, 3.7) ;
        }
    }
}
