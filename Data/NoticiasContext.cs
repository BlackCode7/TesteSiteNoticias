using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteSiteNoticias.Models;

namespace TesteSiteNoticias.Data
{
    public class NoticiasContext : DbContext
    {
        public NoticiasContext(DbContextOptions<NoticiasContext> options)
            : base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Blog> Blogs { get; set; }
    }

}


