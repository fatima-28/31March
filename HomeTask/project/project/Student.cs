using System;

namespace project
{
    class Student
    {
        public string Name;
        public string Surename;
        public int Age;
        public int Point;
        public int Id;
        //{
        //    get { return Id + 1; }
        //}
        public Student()
        {

        }
        public Student(string name, string surename, int age, int point)
        {
            Name = name;
            Age = age;
            Point = point;
            //Console.WriteLine($"{Id + 1}");
            this.Id = System.Threading.Interlocked.Increment(ref Id);//static 
        }

        public void ShowInfo()
        {
            if (Name == "" || Name == " " || Surename == "" || Surename == " " || Age == 0 || Point == 0)
            {
                Console.WriteLine("You cant creating object without values!");
            }
            Console.WriteLine($"Name:{Name}, Surename:{Surename},Age:{Age},Point:{Point}");
        }
    }
}
