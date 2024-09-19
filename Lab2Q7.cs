using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KabitaLabwork
{
    class Unary
    {
        private int x;
        private int y;
        public Unary() { }
        public Unary(int i, int j)
        {
            x = i; y = j;
        }
        public void Show() {
            Console.WriteLine("{0} {1}",x,y);
        }
        public static Unary operator - (Unary u)
        {
            Unary temp = new Unary();
            temp.x = - u.x;
            temp.y = -u.y;
            return temp;
        }
    }
    internal class Lab2Q7
    {
        /*public static void Main(string[] args)
        {
            Unary u1 = new Unary(10, 20);
            u1.Show();
            Unary u2 = new Unary();
            u2.Show();
            u2 = -u1;
            u2.Show();
        }*/
    }
}
