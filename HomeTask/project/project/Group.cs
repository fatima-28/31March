using System;
using System.Threading;
namespace project

{
    class Group : Student
    {

        public int No;
        Student[] StuArr;
        public Group()
        {
            No = 201;
            this.No = System.Threading.Interlocked.Increment(ref No);//static 
            
        }
        public void AddStu()
        {
            int i = 0;
            Array.Resize(ref StuArr, StuArr.Length + 1);
            StuArr[i] = StuArr[i + 1];
            foreach (var item in StuArr)
            {
                Console.WriteLine(item);
            }
        }
        public void GetAllStudent()
        {
        }

        public void Sorting()
        {
            Array.Sort(StuArr);

            Console.WriteLine(StuArr);
        }

    }
}

