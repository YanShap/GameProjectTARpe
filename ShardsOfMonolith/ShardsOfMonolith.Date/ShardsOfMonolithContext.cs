
using Microsoft.EntityFrameworkCore;
using ShardsOfMonolith.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShardsOfMonolith.Date
{
    public class ShardsOfMonolithContext : DbContext
    {
        public DbSet<Stalker> Stalkers { get; set; }
    }
}
