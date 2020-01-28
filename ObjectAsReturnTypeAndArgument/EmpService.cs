using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.ObjectAsReturnTypeAndArgument
{
    class EmpService
    {
        /// <summary>
        /// Saves the specified e.
        /// employe as a argument
        /// </summary>
        /// <param name="e">The e.</param>
        public void Save(Employee e)
        {
            Console.WriteLine(e.getName()+""+e.getId());
        }
        /// <summary>
        /// Gets the emp.
        /// employee as a return type
        /// </summary>
        /// <returns></returns>
        public Employee getEmp()
        {
            Employee obj = new Employee(101, "shan");
            return obj;
        }
    }
}
