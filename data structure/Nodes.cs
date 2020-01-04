using System;
using System.Collections.Generic;
using System.Text;

namespace LList
{
    class Nodes
    {
        public int info;
        public Nodes link;
        Nodes next;
        private int data;

        public Nodes(int data)
        {
            this.data = data;
        }
    }
}
