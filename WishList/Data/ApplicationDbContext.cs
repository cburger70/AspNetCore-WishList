using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WishList.Data
{
    public class ApplicationDbContext : DbContext
    {   
        public AppliationDbContext(DbContextOptions) : base(Options)
        {

        }
    }
}
