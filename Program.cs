using Basic.ObjectAsReturnTypeAndArgument;
using System;

namespace Basic
{
    class Program
    {
       public static void Main(string[] args)
        {
            Employee ob = new Employee(234,"ddd");
            
            EmpService obj = new EmpService();
                obj.Save(ob);
            Employee e = obj.getEmp();
            Console.WriteLine(e.getId() + "" + e.getName());
        }
    }
}
