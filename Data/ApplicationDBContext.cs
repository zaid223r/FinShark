using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext : DbContext //Inherit from DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions) 
        {
            //Inherit all options
        }

        public DbSet<Stock> Stock { get; set;} //make Stock table
        public DbSet<Comment> Comments { get; set;} //make Comments table

    }
}