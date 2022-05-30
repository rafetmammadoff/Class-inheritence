using System;
using System.Collections.Generic;
using System.Text;

namespace Class_inheritence
{
    internal class Store
    {
        public Store(int phoneCount)
        {
            phones = new Phone[phoneCount];
        }


        Phone[] phones;
        
        public void AddPhone(Phone phone)
        {
            int count = 0;
            int index = -1;
            for (int i = 0; i < phones.Length; i++)
            {
                if (phones[i] != null)
                {
                    count++;
                    index = i;
                }
            }

            if (phones.Length > count)
            {
                phones[index+1]=phone;
                Console.WriteLine($"Brand - {phones[index+1].Brand}  - Name - {phones[index+1].Name}  - Price - {phones[index + 1].Price} AZN");
            }
            else
            {
                Console.WriteLine("Elave etmek ucun yer yoxdur!!!!!");
                return;
            }
            
        }
    }
}
