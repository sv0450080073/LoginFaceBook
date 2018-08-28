using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webapplication1.Models.Entities;

namespace Webapplication1.Data
{
    public class ApplicationDbContext :IdentityDbContext<AppUser>
    {
        public ApplicationDbContext (DbContextOptions options) :base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
    }
}
