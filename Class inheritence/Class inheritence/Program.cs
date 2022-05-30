using System;

namespace Class_inheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-ci Tapsiriq******************************************************************************************
            //  1.Aşağıdakı classları yaradırsınız:
            //  Vehicle class:
            //  - Brand
            //  - Model
            //  - Millage
            //  Car class:
            //  - FuelCapacity
            //  - AddFuel() - parametr olaraq neçə litr benzin əlavə etmək istənildiyi 
            //  daxil edilməlidir və capacity-ni aşmırsa əlavə edilməlidir

            Car car1 =new Car();
            car1.FuelCapacity = 20;
            car1.CurrentFuel = 5;
            car1.Brand = "Mersedes";
            car1.AddFuel(10);
            car1.AddFuel(5);
            #endregion

            #region 2-ci Tapsiriq******************************************************************************************
                    // Store classinin addPhone metodunu isletdikde icine gonderdiyimiz phone arqumentini eger arrayda
                    // yer varsa ora elave edir.  dersde verdiyiniz tapsiriq
            Store newStore = new Store(3);

            newStore.AddPhone(new Phone(1000) { Brand = "Samsung", Name = "Galaxy S22" });
            newStore.AddPhone(new Phone(2000) { Brand = "Apple", Name = "Iphone X" });
            newStore.AddPhone(new Phone(500) { Brand = "Xiaomi", Name = "Note 10 Pro" });


            #endregion

            #region 3-ci Tapsiriq******************************************************************************************
            //  Human class:
            //  - FullName
            //  - Age
            //  Employee:Human - Salary
            //  - Position  
            //  Layihe run olanda bizden say istesin.Daha sonra hemin say qeder employee  datalari daxil 
            //  etmeyimizi istesinbutun employeeri daxil etdikden sonra filterleme aparib aparmaq istemediyimi 
            //  sorussun aparmaq istemesek butun employeeleri gostersin aparsaq filtirlenmis employeeleri 
            //  gostersin.Adı təyin olunmamış Human yaradıla bilminməz.

            Console.WriteLine("Say daxil edin");
            int count = int.Parse(Console.ReadLine());


            Employee[] employees = new Employee[count];

            for (int i = 0; i < employees.Length; i++)
            {
                
                Console.WriteLine($"{i + 1} -ci iscinin adini daxil edin");
                string fullName = Console.ReadLine();
                employees[i] = new Employee(fullName);
                Console.WriteLine($"{i + 1} -ci iscinin maasini daxil edin");
                employees[i].Salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{i + 1} -ci iscinin pozisiyasini daxil edin");
                employees[i].Position = Console.ReadLine();


            }

            Console.WriteLine("Filtirleme aparmaq isteyirsinizmi?  ( he / yox )");

            string test = Console.ReadLine();
            if (test == "yox")
            {
                for (int i = 0; i < employees.Length; i++)
                {
                    Console.WriteLine($"{employees[i].FullName} - {employees[i].Salary}");
                }
            }

            else if (test == "he")
            {
                Console.WriteLine("Min maasi girin");

                int minPrice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Max maasi girin");
                int maxPrice = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < employees.Length; i++)
                {
                    if (employees[i].Salary >= minPrice && employees[i].Salary <= maxPrice)
                    {
                        Console.WriteLine($"{employees[i].FullName} {employees[i].Salary}");
                    }
                }


            }
            else
            {
                Console.WriteLine("Cavab duzgun deyil");
            }
            #endregion
        }

    }
}
