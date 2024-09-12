using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KabitaLabwork
{   
    class Member
    {

        private int id;
        private string name;

        public Member(int i, string n)
        {
           id = i;
           name = n;
        }
        public void PrintDetails()
        {
            Console.WriteLine("Id is {0} \nName is {1} ",id, name);
        }
    }
    //single level inheritance
    class Teacher: Member
    {
        private string panno;

        public Teacher(int  i, string n, string p):base (i, n) 
        {
            panno = p;
        }
        public void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine("Pan no: "+panno);
        }
    }
    //Multi-level
    class BCATeacher: Teacher
    {
        private bool isTechnical;

        public BCATeacher(int i, string n, string p, bool it): base(i,n,p)
        {
            isTechnical = it;
        }
        public void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine("Is Technical: {0}", isTechnical);
        }
    }
    //Hierarchical
    class Student : Member
    {
        private int rollno;

        public Student (int i, string n, int r):base(i,n) 
        {
            rollno = r;
        }

        public void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine("Roll No: {0}", rollno);
        }
    }
    internal class Lab2Q4
    {
        static void Main(string[] args)
        {
            Teacher t = new Teacher(1, "Basanta", "12121212\n");
            t.PrintDetails();
            BCATeacher b = new BCATeacher(1, "Basanta", "12121212", true);
            b.PrintDetails();
            Student s = new Student(2, "Kabita", 04);
            s.PrintDetails();
            Console.ReadKey();
        }
    }
}
