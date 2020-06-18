using System;
using System.Collections.Generic;
using System.Text;

namespace StudentClass {

    class Student {
        public double GPA;
        public int SAT;
        public int TimesTardy;
        public string Name;
        public int Id;

        private double SecretNumberCalculation(double bnumber, int SecretNumber) {
            return bnumber / SecretNumber;
        }

        public double BC(int SecretNumber) {
            var dblSat = SAT * 2;
            var b = dblSat * GPA;
            var bc = b / SecretNumberCalculation(b, SecretNumber);
            return bc;
        }

        public string GetValues() {
            return $" ID: {Id}|NAME: {Name}|TIMES TARDY: {TimesTardy}|SAT: {SAT}|GPA: {GPA}";

        }

        public Student() { // default constructor
        
        }
        public Student(string Name, int Id, int TimesTardy, int SAT, double GPA) {
            this.Name = Name;
            this.Id = Id;
            this.TimesTardy = TimesTardy;
            this.SAT = SAT;
            this.GPA = GPA;
       
        }   



    } 
}
