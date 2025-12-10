namespace ClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Student s1 = new Student();
            s1.Name = "Swapnil";
            string name = s1.Name;
            Console.WriteLine("Name: "+name);
        }
    }
}

//by default data member //fields and
class Student
{
    private int _rollno;
    private string _name;
    private string _course;

    public Student()
    {

    }
    public string Name
    {
        set { this._name = value; }
        get { return this._name; }
    }
}