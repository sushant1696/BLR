using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Generics
{
    class Generics<T>
    {
        private T data;
        private T name;
        public T Datas
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }
        public T Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
                    
            }
        }

    }
}
