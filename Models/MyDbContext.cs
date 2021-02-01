using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

namespace BMIWeb.Models
{

    public class MyDbContext : DbContext
    {
        public DbSet<User_account> userAccount { get; set; }
    }
}