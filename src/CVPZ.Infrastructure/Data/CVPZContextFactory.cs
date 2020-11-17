using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CVPZ.Infrastructure.Data
{
    public class CVPZContextFactory : IDesignTimeDbContextFactory<CVPZContext>
    {
        public CVPZContext CreateDbContext(string[] args)
        {
            //ToDo :: specify Sqlite or Sql server and take the connection string from config files.
            var optionsBuilder = new DbContextOptionsBuilder<CVPZContext>()
                //.UseSqlServer("Data Source=.,8433;Initial Catalog=CVPZ;User Id=sa;Password=yourStrong(!)Password");
                .UseSqlite("Data Source=CVPZ.db");

            return new CVPZContext(optionsBuilder.Options);
        }
    }
}
