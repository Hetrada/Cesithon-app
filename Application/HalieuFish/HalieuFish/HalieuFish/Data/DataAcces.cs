using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace HalieuFish.Data
{
    public class DataAcces:DbContext
    {
        public readonly IDbConn dbConn;
        public DataAcces()
        {
            dbConn = new DbConn
            {
                server_dbname = "HalieuFishBDD",
                server_name = "192.168.51.67",
                server_pass = "AdminPass",
                server_user = "sa"
            };

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ///base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(dbConn.Connection);
        }
    }
}
