﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTrader.EntityFramework
{
    public class SimpleTraderDbContextFactory : IDesignTimeDbContextFactory<SimpleTraderDbContext>
    {
        //public SimpleTraderDbContext CreateDbContext(string[] args)
        //{
        //    var options = new DbContextOptionsBuilder<SimpleTraderDbContext>();
        //    options.UseSqlServer("Server=.\\SQLEXPRESS; Database=SimpleTraderDB;Trusted_Connection=True;");
        //    return new SimpleTraderDbContext(options.Options);
        //}

        public SimpleTraderDbContext CreateDbContext (string[] args = null)
        {
            var options = new DbContextOptionsBuilder<SimpleTraderDbContext>();
            options.UseSqlServer("Server=.\\SQLEXPRESS; Database=SimpleTraderDB;Trusted_Connection=True;");
            return new SimpleTraderDbContext(options.Options);
        }
    }
}
