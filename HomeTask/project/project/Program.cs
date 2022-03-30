using System;
using System.Threading;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {

            Student stu1 = new Student("Fatime", "Bayramova", 19, 92);
            Student stu2 = new Student("Gunay", "Abbasova", 21, 98);
            Student stu3 = new Student("Mehemmed", "Ceferzade", 19, 95);

            stu1.ShowInfo();
            stu2.ShowInfo();
            stu3.ShowInfo();

        }
    }

}