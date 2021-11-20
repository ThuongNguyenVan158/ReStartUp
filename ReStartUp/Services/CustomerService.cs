using ReStartUp.Data;
using ReStartUp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReStartUp.Services
{
    public class CustomerService:ICustomerService
    {
        private readonly REDbContext _context;
        public CustomerService(REDbContext context)
        {
            _context = context;
        }
        public void UpdatetoDbAsync(string E)
        {

            var newemail = new Email()
            {
                Id = System.Guid.NewGuid(),
                email = E,
            };
            _context.EMAIL.Add(newemail);
            _context.SaveChanges();
        }
    }
}
