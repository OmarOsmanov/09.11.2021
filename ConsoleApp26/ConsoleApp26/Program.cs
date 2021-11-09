using System;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            byte saygac = 255;

            DepartmentServiceClass depa = new DepartmentServiceClass();
            DepartmentOzellikleri depasoz = new DepartmentOzellikleri();

            Console.WriteLine("salam proqrama xos geldiniz:");
            Console.WriteLine();
            do
            {
               
                Console.WriteLine("reqemi daxil edin emeliyyata uygun:");
                Console.WriteLine("1.create department");
                Console.WriteLine("2.delate department");
                Console.WriteLine("3.update department");
                Console.WriteLine("4.Find department");
                Console.WriteLine("5.read departments");
                Console.WriteLine("0.exit");

                if (byte.TryParse(Console.ReadLine(), out saygac)) 
                {
                    switch (saygac)
                    {
                        case 1:
                            DepartmentOzellikleri newDepartmenOzellikleri = new DepartmentOzellikleri();

                            newDepartmenOzellikleri.Id = depa.FindId();
                            
                            Console.WriteLine("Departamentin adini daxil edin");
                            newDepartmenOzellikleri.Name = Console.ReadLine();

                            Console.WriteLine("Departamentin adresini daxil edin");
                            newDepartmenOzellikleri.Adress = Console.ReadLine();

                            Console.WriteLine("Departamentin isci sayini daxil edin");
                            newDepartmenOzellikleri.EmployeCount = Convert.ToInt32 (Console.ReadLine());

                            Console.WriteLine("Departamentin telefon nomresini daxil edin");
                            newDepartmenOzellikleri.PhoneNumber = Console.ReadLine();

                            depa.Create(newDepartmenOzellikleri);

                            break;
                       
                        
                        case 2:
                            Console.WriteLine("departamentin id sini daxil et ve hemin idiye gore melumatlari bazadan silin");
                            DepartmentOzellikleri[] ozellik2 = depa.Read();
                            for (int i = 0; i < ozellik2.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}. Id:{ozellik2[i].Id},Name:{ozellik2[i].Id},Adresss:{ozellik2[i].Adress},Phone number{ozellik2[i].PhoneNumber},EmployeCount{ozellik2[i].EmployeCount}");
                            }
                            int id2 = Convert.ToInt32(Console.ReadLine());
                            DepartmentOzellikleri departs1 = depa.Find(id2);
                            Console.WriteLine("silme prosessi ugurla basa catdi");
                            break;
                        
                        
                        
                        case 3:
                            Console.WriteLine("update etmek istediyiniz id ni secin");
                            foreach (var item in depa.Read())
                            {
                                Console.WriteLine($" Id:{item.Id},Name:{item.Id},Adresss:{item.Adress},Phone number{item.PhoneNumber},EmployeCount{item.EmployeCount}");
                            }
                            int empId = Convert.ToInt32(Console.ReadLine());
                            DepartmentOzellikleri depart = depa.Find(empId);
                            Console.WriteLine($"yeni adi daxil edin{depart.Name}");
                            depart.Name = Console.ReadLine();

                            Console.WriteLine($"yeni unvani daxil edin{depart.Adress}");
                            depart.Adress = Console.ReadLine();

                            Console.WriteLine($"yeni nomreni daxil edin{depart.PhoneNumber}");
                            depart.PhoneNumber = Console.ReadLine();

                            depa.Update(empId, depart);
                            Console.WriteLine("update ugurludur!");

                            break;
                        
                        
                        
                        case 4:
                            Console.Write("haqqinda melumat almaq istediyiniz DEpartamentin idsini daxil edin");
                            int id = Convert.ToInt32 (Console.ReadLine());
                            DepartmentOzellikleri departs2 = depa.Find(id);
                            Console.WriteLine($"Id:{departs2.Id},Name:{departs2.Id},Adresss:{departs2.Adress},Phone number{departs2.PhoneNumber},EmployeCount{departs2.EmployeCount}");

                            break;
                       
                        
                        
                        case 5:
                            DepartmentOzellikleri[] ozellik = depa.Read();
                            for (int i = 0; i < ozellik.Length; i++)
                            {
                                Console.WriteLine($"{i+1}. Id:{ozellik[i].Id},Name:{ozellik[i].Id},Adresss:{ozellik[i].Adress},Phone number{ozellik[i].PhoneNumber},EmployeCount{ozellik[i].EmployeCount}");
                            }

                            break;
                        
                        
                        case 0:
                            Console.WriteLine("exit");
                            break;

                        default:
                            Console.WriteLine("uuh");
                            break;
                    }
                }


                else
                {
                    Console.WriteLine("zehmet ");
                    saygac = 255;
                }

            } while (saygac!=0);

        }
    }
}
