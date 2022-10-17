using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace StockCardApplication.Models
{
    public class DbServicesContext:DbContext
    {
        public DbSet<User> Tbl_user { get; set; }
        public DbSet<StockCard> Tbl_stockcard { get; set; }
    }
}