using System;
using System.Collections.Generic;
using System.Text;

namespace Class_inheritence
{
    internal class Phone : Product
    {
        public Phone(int price) : base(price)
        {

        }
        public string Camera;
        public string SimCount;
    }
}
