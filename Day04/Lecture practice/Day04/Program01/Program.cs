using Program02_maths_;
using System.Numerics;
namespace Program01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            choice = 0;

            Console.WriteLine("Enter value of A :");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter value of B :");
            int b = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("\n 1.Addition \n 2.Substaction \n 3.Multiplication \n 4.Division");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("choice : "+choice);
               

                switch (choice)
                {
                 
                    case 1:
                            Class1 c = new Class1();
                            Console.WriteLine("Addition: " + c.Addition(a,b));
                            break;

                    case 2: Class1 d = new Class1();
                            Console.WriteLine("Substraction: "+ d.SubStraction(a,b));
                            break;
                    case 3: Class1 e = new Class1();
                            Console.WriteLine("Multiplication" +e. Multiply(a,b));
                            break;

                    case 4: Class1 f = new Class1();
                            Console.WriteLine("Division" + f.Division(a, b));
                            break;
                }   

            }while (choice > 0);
        }
    }
}
