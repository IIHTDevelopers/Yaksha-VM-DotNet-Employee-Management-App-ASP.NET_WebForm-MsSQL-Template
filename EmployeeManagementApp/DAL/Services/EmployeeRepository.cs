using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EmployeeManagementApp.DAL.Interfaces;

namespace EmployeeManagementApp.DAL.Services
{
    public class EmployeeRepository : Interfaces.IEmployeeRepository
    {
        private EmployeeDbContext _context;

        public EmployeeRepository(EmployeeDbContext context)
        {
            _context = context;
        }

        public Model.EmployeeModel GetById(string id)
        {
            return _context.EmployeeModels.FirstOrDefault(t => t.Id == int.Parse(id));
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
    }
}