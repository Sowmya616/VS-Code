using System;
using System.Reflection;

namespace Assignment8
{
    public class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type type = Type.GetType("Assignment8.MyClass");
            Object obj = (MyClass)Activator.CreateInstance(type);

            Console.WriteLine("\n---------Types----------");
            Console.WriteLine(type);

            Console.WriteLine("\n---------Fields----------");
            FieldInfo[] fields1 = type.GetFields();
            Console.WriteLine(fields1[0]);

            MethodInfo mI = type.GetMethod("GetMyName");
            Console.WriteLine("\n---------Methods----------");
            string[] str = new string[2];
            str[0] = "Isan";
            str[1] = "Bain";
            Console.WriteLine(mI.Invoke(obj, str));

            Console.ReadLine();
        }
    }

    public class MyClass
    {
        public string fullName;
        public string GetMyName(string first, string last)
        {
            this.fullName = first + " " + last;
            return this.fullName;
        }

    }
}
