using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.PrototypeDesign
{
   public class Person
    {
        public int age;
        public DateTime Date;
        public string Name;
        public IdInfo Idinfo;

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        [Obsolete]
        public Person DeepCopy()
        {
          Person clone = (Person)this.MemberwiseClone();
            clone.Idinfo = new IdInfo(Idinfo.IdNumber);
            clone.Name = string.Copy(Name);
            return clone;
        }
        
    }
}
