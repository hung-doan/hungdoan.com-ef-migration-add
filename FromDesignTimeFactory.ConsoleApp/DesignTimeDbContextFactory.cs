using FromDesignTimeFactory.ConsoleApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace FromDesignTimeFactory.ConsoleApp
{
    public class MyDbContextFactory : IDesignTimeDbContextFactory<MyDbContext>
    {
        public MyDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyDbContext>();
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MyDb;Integrated Security=True;");

            return new MyDbContext(optionsBuilder.Options);
        }
    }
}
