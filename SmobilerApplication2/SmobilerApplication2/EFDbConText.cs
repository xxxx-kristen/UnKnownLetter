using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SmobilerApplication2
{
    public class EFDbContext:DbContext
    {
        public EFDbContext() : base("UserDataBase") { }
        public DbSet<User> Users { set; get; }
    }
}
