using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestPage.Migrations;
using TestPage.Models;

namespace TestPage.Context
{
    public class Context : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        public Context()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Configuration>());
        }
    }
}