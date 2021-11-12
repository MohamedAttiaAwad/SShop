using Microsoft.EntityFrameworkCore;
using SShop.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SShop.Web.Data
{
    public class CatalogContext : DbContext
    {
        #region Entities
        public DbSet<CatalogItem> CatalogItems { get; set; }
        public DbSet<CatalogType> CatalogTypes { get; set; } 
        #endregion


        public CatalogContext(DbContextOptions options) : base(options)
        {

        }
    }
}
