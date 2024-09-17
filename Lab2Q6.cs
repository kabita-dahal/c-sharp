using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KabitaLabwork
{
    public class Constructor
    {
        int a, b;
        public Constructor()
        {
            a = 200; b = 100;
            Console.WriteLine("This is default");
        }
        //parameterized
        public Constructor(int x, int y)
        {
            a=x; b=y;
            Console.WriteLine("This is Parameterized");
        }
        public Constructor(Constructor cd)
        {
            a=cd.a; b=cd.b;
            Console.WriteLine("This is copy");
        }
        static Constructor()
        {
            Console.WriteLine("This is static constructor");
        }
        ~Constructor()
        {
            Console.WriteLine("I m destroyed");
            Console.ReadKey();
        }
        public void Deconstruct(out int p, out int q)
        {
            p = a; q=b;
        }
            static void Main(string[] args)
        {
            //default 
            Constructor demo = new Constructor();
            Console.WriteLine(demo.a);
            Console.WriteLine(demo.b);
            //parameterized
            Constructor pdemo = new Constructor(100, 100);
            Console.WriteLine(pdemo.a);
            Console.WriteLine(pdemo.b);
            //copy
            Constructor cpdemo = new Constructor(pdemo);
            (int m, int n) = cpdemo;
            Console.WriteLine(m);
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
