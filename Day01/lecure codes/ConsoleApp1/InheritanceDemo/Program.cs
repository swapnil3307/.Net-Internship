using System.Security.Cryptography.X509Certificates;

namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person P = new Student();
            P.Accept();
            Student s1 = new Student();
        }
    }

    class Person
    {

        public virtual void Accept()
        {
            
        }

    }


    class Student:  Person
    {
        public override void Accept()
        {
            Console.WriteLine("in student");
        }
    }

    
}
