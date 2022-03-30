using System;
namespace Classwork
{
     class Student:Person
    {
        public int IQRank;
        public int LanguageRank;

        public Student(string name,string surename,int age,int iqrank,int languagerank):base(name,surename,age)
        {
            IQRank = iqrank;
            LanguageRank = languagerank;
            if (name==""||name==" "|| surename == "" || surename == " " ||iqrank==0||languagerank==0)
            {
                Console.WriteLine("Student yaratmaq mumkun deyil");
            }
            if (age<6||age>20)
            {
                Console.WriteLine("Melumatlari dxil ede bilmezsiniz");
            }
        }
        public void ExamResult()
        {
            if (IQRank + LanguageRank < 120)
            {
                Console.WriteLine("Bu sagird sinifde qaldi");
            }
            else
            {
                Console.WriteLine($"Name: {Name}, Surename: {Surename},Age:{Age}, Iq rank{IQRank},Language rank:{LanguageRank}");
            }
        }

    }
}
