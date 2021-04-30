using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_MorningChallenges_Week1
{
    public enum CourseType {Cyber_Security,Software_Development,Web_Development}
    public enum BadgeType {Gold,Red,Blue}
    public enum courseTaught { Cyber, Web_Dev, Software_Dev }

    public class Student
    {
        public Student()
        {

        }
        public Student(string firstName, string lastName, DateTime doB, decimal balOwed,CourseType classT,BadgeType typeBadge,bool graduated)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateofBirth = doB;
            this.BalanceOwed = balOwed;
            this.classTaking = classT;
            this.TypeOfBadge = typeBadge;
            this.HasGraduated = graduated;
        }

        public string FirstName { set; get; }
        public string LastName { set; get; }
        public DateTime DateofBirth { set; get; }
        public decimal BalanceOwed { set; get; }
        public CourseType classTaking { get; set; }
        public BadgeType TypeOfBadge { set; get; }
        public bool HasGraduated { set; get; }

    }

    public class Instructor
    {
        // public Instructor() { }  // not needed becasue of the instructor with Employee number. If this was used you 
        //would be able to add an instance without an employee number which would not be good.

        public Instructor(int EmployNum)  // this is the only time you can give it a value
        {
            this.EmployeeNumber = EmployNum;
        }
        public Instructor(string firstName,string lastName,DateTime doB,int empNumber,courseTaught taught)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = doB;
            this.EmployeeNumber = empNumber;
            this.TeachingNow = taught;
        }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int EmployeeNumber { get; }  // this can only be set through constructor or here
        public courseTaught TeachingNow { get; set; }
    }

}
