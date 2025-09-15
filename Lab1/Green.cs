using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;
            // code here
            if (Math.Abs(d) >= 1)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;
            if ((d + f) / 2 > 0)
            {
                answer = true;
            }

            // code here

            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if ((a + b) > (Math.Abs(a) + Math.Abs(b)) / 2)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            // code here
            int temp_mx = Math.Max(a, b);
            answer = Math.Max(temp_mx, c);
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (Math.Abs(x) <= 1)
            {
                answer = Math.Pow(x, 2) - 1;
            }
            // end

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            if (((x < 0 && y <= 1 + x) || (x >= 0 && y <= 1 - x)) && 0 <= y && y <= 1 && Math.Abs(x) <= 1)
            {
                answer = true;
            }
            // end
            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here
            if (n >= 0)
            {
                if (n % 2 == 0)
                {
                    answer = false;
                }
            }
            else
            {
                answer = false;
            }
            // end

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;
            // code here
            if (X >= 7)
            {
                /*int wake_up = 7;
                int go_to_sleep_hours = (X + 1) / 2 * Y / 60;
                double mins_go = (X + 1) / 2 * Y % 60 / 60;
                double temp = go_to_sleep_hours + mins_go;
                if (-2 <= 7 - temp && 7 - temp <= 0)
                {
                    answer = true;
                } */
                int hours = (X + 1) / 2 * Y / 60;
                decimal mins = (X + 1) / 2 * Y % 60 / 60m;
                decimal temp = 4 - hours - mins;
                if ((7 - temp >= 7) && (7 - temp <= 9))
                {
                    answer = true;
                }
            }
            return answer;
            /*decimal kolvo = ((decimal)(Y / 60) + 1) * ((X + 1) / 2) + X / 2;
            answer = (((4 - kolvo) <= 0) && ((4 - ko) >= -2)) ; */
            // y - заснуть на y минут раньше. пьёт через день
            // каждый день на час раньше
            // end      
        }
    }
}