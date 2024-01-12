using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagementApp.Model;

namespace EmployeeManagementApp.DAL.Interfaces
{
    public interface IEmployeeRepository
    {
        string GetAll();
        string Add();
        string Update();
        string Delete();

        EmployeeModel GetById(string id);

    }
}
