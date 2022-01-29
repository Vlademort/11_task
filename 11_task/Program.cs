using System;


namespace _11_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найти X уравнения 0 = kX + b");
            Console.WriteLine();
            Console.Write("Введите значение b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение k: ");
            double k = Convert.ToDouble(Console.ReadLine());
            Equation equation = new Equation(k, b);
            equation.Root();


            Console.ReadKey();
        }       
    }

    struct Equation
    {
        double k;
        double b;

        public double K
        {
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("Значение k не должно быть нулём!");                    
                }
                else
                {
                    k = value;
                }
            }
            get
            {
                return k;
            }
        }

        public Equation (double k, double b)
        {
            this.k = k;
            this.b = b;
            K = k;
        }
        public void Root()
        {
            if (k==0)
            {
                Console.WriteLine("");
            }
            else
            {
                double X = -b / k;
                Console.WriteLine("Значение X равно {0}", X);
            }             
        }
    }
}
