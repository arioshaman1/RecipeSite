using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Model;

namespace WebApplication2.Data
{
    public class WebApplication2Context1 : DbContext
    {
        public WebApplication2Context1 (DbContextOptions<WebApplication2Context1> options)
            : base(options)
        {
        }

        public DbSet<WebApplication2.Model.User> User { get; set; } = default!;
    }
}
