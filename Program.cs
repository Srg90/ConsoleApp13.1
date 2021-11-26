using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MultiBuilding multiBuilding = new MultiBuilding();
            multiBuilding.Print();
            
            Console.ReadKey();
            
        }
    }

    class Building
    {
        public string Address { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Building()
        {
            Address = "Университет ИТМО, по адресу: г.Санкт-Петербург, Кронверкский переулок, дом 49.";
            Length = 300;
            Width = 30;
            Height = 12;

        }

        public virtual void Print()
        {
            Console.WriteLine("Информация о здании: ");
            Console.WriteLine();
            Console.WriteLine("{0} ", Address);
            Console.WriteLine("Длина главного корпуса составляет {0} метров.", Length);
            Console.WriteLine("Ширина {0} и высота {1} метров.", Width, Height);

                
        }

    }

    sealed class MultiBuilding : Building
    {
        public double Floor { get; set; }


        public MultiBuilding()
            :base()
        {
            Floor = 3;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Здание имеет {0} этажа.", Floor);
        }

    }
}






