using System.Linq;
//using TokenSecured.ProductApi.Models;

namespace TokenSecured.ProductApi.Repository
{
    public class Employees//:ApplicationDbContexts
    {
        //Get employees data from the Employees table in your database
        public dynamic GetEmployees()
        {
            return null;//ApplicationDbContext.Employees.AsEnumerable().Select(x => new { x.EmloyeeName, Designation=x.Designation.Name, x.Address,x.Salary }).ToList();

        }
    }
}