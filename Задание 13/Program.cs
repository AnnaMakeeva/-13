using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_13
{
    class Program
    {
        static void Main(string[] args)
        {
             //создаем объект класса

            Building stroyBuilding_1 = new Building("Думенко", 20, 5, 10);   
            stroyBuilding_1.Print(); // метод вызываем

            Console.ReadKey();

            MultiBuilding stroyBuilding_2 = new MultiBuilding(6, "Стахановская", 20, 5, 10); //объект дочернего класса
            stroyBuilding_2.Print();


            Console.ReadKey();
        }
    }

    class Building
    {                                                 
        public string A { get; set; }
        public double L { get; set; }
        public double S { get; set; }
        public double H { get; set; }


        public Building(string A, double L, double S, double H)    //конструктор с параметрами
        {
            this.A = A;   //адрес
            this.L = L;   //длина здания
            this.S = S;    //ширина здания
            this.H = H;   //высота здания
        }

        public void Print()
        {
            Console.WriteLine("Здание по адресу {0}, длина {1}, ширина {2}, высота {3}", A, L, S, H);
        }

           
    }
   sealed class MultiBuilding : Building
    {
        public double F { get; set; }

        public MultiBuilding(double F, string A, double L, double S, double H) : base(A, L, S, H)   //конструктор с параметрами
        {
            this.F = F;
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine("Этаж {0}", F);
        }

    }


}
