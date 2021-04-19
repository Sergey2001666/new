using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическое_занятие_1
{
    class Chet
    {
        static Chet[] a = new Chet[1000];
        static int n;

        public string Name { get; set; }
        public int Number { get; set; }
        public double Sum { get; set; }

        internal void add()
        {
            Console.WriteLine();
            Console.Write("Введите кол-во записей: ");
            n = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                a[i] = new Chet();
                Console.Write("Название счета: ");
                a[i].Name = Console.ReadLine();
                Console.Write("Номер счета: ");
                a[i].Number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Сумма: ");
                a[i].Sum = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
            }
        }

        internal void print()
        {
            Console.WriteLine();
            Console.WriteLine("Список счетов:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Название счета:" + a[i].Name);
                Console.WriteLine("Номер счета:" + a[i].Number);
                Console.WriteLine("Сумма:" + a[i].Sum);

            }
            Console.WriteLine();
        }
    }
}
