using Microsoft.EntityFrameworkCore;
using System;
using Ancestry.AncestryDB.Models;

namespace Ancestry.AncestryDB
{
    public class TreeDbContext : DbContext
    {
        public TreeDbContext(DbContextOptions<TreeDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        public DbSet<Human> HumanDbSet { get; set; }
        public DbSet<Node> TreeDbSet { get; set; }
    }
}
