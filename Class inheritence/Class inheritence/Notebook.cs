using System;
using System.Collections.Generic;
using System.Text;

namespace Class_inheritence
{
    internal class Notebook : Product
    {
        public Notebook(int price) : base(price)
        {

        }
        public string CPU;
        public string RAM;
        public string Storage;
    }
}
