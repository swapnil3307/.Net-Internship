using System.Xml.Serialization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");

            //use "+"
            Console.WriteLine("hello :" + "riya");

            //placeholder
            string name = "riya";
            string city = "kolhapur";
            Console.WriteLine("City:{0} Name:{1}", city, name);

            //string imterpolation
            Console.WriteLine($"City:{city} Name:{name}");
            #region InputMethod.ReadLine()
            string name1 = Console.ReadLine();
            Console.WriteLine("Name:" + name1);

            int num1 = 10;
            int num2;
            Console.WriteLine("enter the value:for num2");
            String value = Console.ReadLine();
            num2 = int.Parse(value);           //parsing method
            //num2=convert.ToInt32(value);
            Console.WriteLine("num2:" + num2);
            #endregion
        }
    }
}