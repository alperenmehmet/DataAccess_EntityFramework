using Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
            //In the below code line you have to write your local db server name, you have to named a database name.   
            Database.Connection.ConnectionString = @"Server = ; Database = ; Integrated Security=True";
        }

        public DbSet<AppUser>AppUsers { get; set; }
        public DbSet<Article>Articles { get; set; }
        public DbSet<Category>Categories { get; set; }
        public DbSet<Comment>Comments { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
