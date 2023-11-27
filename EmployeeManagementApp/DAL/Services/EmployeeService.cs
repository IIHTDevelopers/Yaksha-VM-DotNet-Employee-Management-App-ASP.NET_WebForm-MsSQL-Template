using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using EmployeeManagementApp.DAL.Interfaces;
using EmployeeManagementApp.Model;

namespace EmployeeManagementApp.DAL.Services
{
    public class EmployeeService : Interfaces.IEmployeeService
    {
        private Interfaces.IEmployeeRepository _repository;

        public EmployeeService(Interfaces.IEmployeeRepository repository)
        {
            _repository = repository;
        }


        public string GetAll()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public string Add()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public string Update()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public string Delete()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public EmployeeModel GetById(string id)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}