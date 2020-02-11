using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.ObjectAsReturnTypeAndArgument
{
    class Employee
    {
        int empId;
        string empName; 
        public Employee(int id,string name)
        {
            this.empId = id;
            this.empName = name;
        }
        public int getId()
        {
            return empId;
        }
        public string getName()
        {
            return empName;
        }
            
    }
}
