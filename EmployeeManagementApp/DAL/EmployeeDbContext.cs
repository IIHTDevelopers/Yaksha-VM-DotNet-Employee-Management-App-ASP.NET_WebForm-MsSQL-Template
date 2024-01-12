using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using EmployeeManagementApp.Model;

namespace EmployeeManagementApp.DAL
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Model.EmployeeModel> EmployeeModels { get; set; }

        public EmployeeDbContext() : base("ConnStr")
        {
        }
    }
}