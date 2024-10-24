
using Microsoft.EntityFrameworkCore;
using ShardsOfMonolith.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShardsOfMonolith.Data
{
    public class ShardsOfMonolithContext : DbContext
    {
        public ShardsOfMonolithContext(DbContextOptions<ShardsOfMonolithContext> options) : base(options) {}
        public DbSet<Stalker> Stalkers { get; set; }
        public DbSet<FileToDatabase> FilesToDatabase { get; set; }
    }
}
