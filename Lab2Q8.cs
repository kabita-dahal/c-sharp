using System;

namespace KabitaLabwork
{
    class Binary
    {
        private int x;
        private int y;

        public Binary() { }

        public Binary(int i, int j)
        {
            x = i;
            y = j;
        }

        public void Show()
        {
            Console.WriteLine("{0} {1}", x, y);
        }

        // Defining the addition operator
        public static Binary operator +(Binary b1, Binary b2)
        {
            Binary temp = new Binary();
            temp.x = b1.x + b2.x;
            temp.y = b1.y + b2.y;
            return temp;
        }
    }

    class Lab2Q8
    {
        /*public static void Main(string[] args)
        {
            Binary b1 = new Binary(10, 20);
            b1.Show();

            Binary b2 = new Binary(20, 30);
            b2.Show();

            // Corrected the instantiation
            Binary b3 = b1 + b2;
            b3.Show();
        }*/
    }
}
