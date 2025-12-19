using System.Diagnostics;
using System.Dynamic;
using System.Reflection;

namespace Program03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\internship.net\\Days\\Day04\\Lecture practice\\Day04\\Program01\\bin\\Debug\\net8.0\\Program01.dll";
            Assembly assembly = Assembly.LoadFrom(path);

            Type[] allTypesInAssambly = assembly.GetTypes();

            foreach (Type type in allTypesInAssambly)
            {
                Console.WriteLine("full Name : "+ type .FullName);

                MethodInfo[] allMethods = type.GetMethods();

                assembly.CreateInstance(type.FullName);

                Console.WriteLine("Methods: ");
                Console.WriteLine();

                foreach (MethodInfo method in allMethods)
                {

                    Console.Write("----"+ method.ReturnType.ToString() +" " + method.Name);
                    
                    ParameterInfo[] allparams = method.GetParameters();

                    foreach (ParameterInfo para in allparams)
                    {
                        Console.Write(para.ParameterType.ToString() +" " + para.Name);

                    }
                  /* ParameterInfo[] allParams = method.GetParameters();
                    object[] arguments = new object[allParams.Length];
                    foreach (int i = 0; i < allParams.Length; i++)
                    {
                        ParameterInfo para = allparams[i];
                        Console.WriteLine("Enter data of type "para.ParameterType.ToString() + " for" + para.Name + " ");
                    
                        string data = Console.ReadLine();
                        arguments[i] = Convert.ChangeType(data, para.ParameterType);

                    
                        object output = type.InvokeMember(method.Name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, DynamicObject, arguments);
                        Console.WriteLine(output);
                        Console.WriteLine("---------------------------------");
                    } */

                    Console.Write(")");
                    Console.WriteLine() ;

                }
            }
        }
    }
}
