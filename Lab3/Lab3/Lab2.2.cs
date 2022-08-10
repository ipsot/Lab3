using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main()
        {
            //(e^-x)-((x-1)^2)
            const float e = 0.01f;
            double exp,exp1,exp2;
            float x0, x1, x2 = 0, fx0,fx1, fx2;
            Console.WriteLine("Введите начало и конец числвого промежутка");
            x0 = Convert.ToSingle(Console.ReadLine());
            x1 = Convert.ToSingle(Console.ReadLine());
            exp = Math.Exp(-x0);
            exp1 = Math.Exp(-x1);
            exp2 = Math.Exp(-x2);
            while (Math.Abs(x1-x0)>e)
            {
                fx0 = Convert.ToSingle(exp) - ((x0 - 1)*(x0-1));
                fx1 = Convert.ToSingle(exp1) - ((x1 - 1) * (x1 - 1));
                x2 = x0 - (x1 - x0) / (fx1 - fx0) * fx0;
                fx2= Convert.ToSingle(exp2) - ((x2 - 1) * (x2 - 1));
                if (fx0*fx2<0)
                {
                    x1 = x2;
                }
                else
                {
                    x0 = x2;
                }
                Console.WriteLine("Значение корня уравнения на заданном числовом промежутке ={0}", x2);
                Console.Read();
            }
            
            Console.ReadKey();
        }
    }
}
