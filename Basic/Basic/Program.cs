using Basic.Generics;
using Basic.ObjectAsReturnTypeAndArgument;
using System;
using Basic.TicTacGame;

namespace Basic
{
    class Program
    {
       public static void Main(string[] args)
        {
           
            Console.WriteLine("1-> object as return type and argument");
            Console.WriteLine("2-> generics");
            Console.WriteLine("3-> tic tac");
            Console.WriteLine("choose your option");
            int k = Convert.ToInt32(Console.ReadLine());
            switch (k)
            {
                case 1:
                    Employee ob = new Employee(234, "ddd");

                    EmpService obj2 = new EmpService();
                    obj2.Save(ob);

                    Employee em = obj2.getEmp();
                    Console.WriteLine(em.getId() + "" + em.getName());
                    break;
                case 2:
                    ////string type
                    Generics<string> obj = new Generics<string>();
                    string s=obj.Datas = "123";
                    string s2=  obj.Name = "shan";
                    Console.WriteLine(s);
                    Console.WriteLine(s2);
                   
                    ////int type 
                    Generics<int> obj1 = new Generics<int>();
                   int result =obj1.Datas = 12343;
                    Console.WriteLine(result);
                    int result1=obj1.Name = 360;
                    Console.WriteLine(result1);
                    break;
                case 3:
                    TicTacToy obt = new TicTacToy();
                    obt.PrintBoard();
                    break;
            }
        }
    }
}
