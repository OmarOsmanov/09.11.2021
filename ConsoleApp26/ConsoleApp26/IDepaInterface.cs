using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    interface IDepaInterface
    {
        DepartmentOzellikleri Create(DepartmentOzellikleri department);
        DepartmentOzellikleri Update(int Id, DepartmentOzellikleri department);
        bool Dalete(int Id);
        DepartmentOzellikleri[] Read();
        DepartmentOzellikleri Find(int Id);

        int FindId();
        

    }
}