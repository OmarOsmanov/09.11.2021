using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
   class DepartmentServiceClass : IDepaInterface
    {
        private DepartmentOzellikleri[] Departments = new DepartmentOzellikleri[0];

        public DepartmentOzellikleri Create(DepartmentOzellikleri department)
        {
            Array.Resize(ref Departments, Departments.Length + 1);
            Departments[Departments.Length - 1] = department;
            return department;

        }

        public bool Dalete(int Id)
        {
           Departments= Array.FindAll(Departments, a => a.Id! == Id);
            return true;
        }

        public DepartmentOzellikleri Find(int Id)
        {
           DepartmentOzellikleri departmentOzellikleri= Array.Find(Departments, a => a.Id == Id);
            return departmentOzellikleri;
        }

        public int FindId()
        {
            if(Departments.Length==0)
            {
                return 1;
            }
            return Departments[Departments.Length - 1].Id + 1;
        }

        public DepartmentOzellikleri[] Read()
        {
            return this.Departments;
        }

        public DepartmentOzellikleri Update(int Id, DepartmentOzellikleri department)
        {
            DepartmentOzellikleri updateDepartmentOzellikleri = Array.Find(Departments, a => a.Id == Id);
            updateDepartmentOzellikleri = department;
            return updateDepartmentOzellikleri;

        }
    }
}
