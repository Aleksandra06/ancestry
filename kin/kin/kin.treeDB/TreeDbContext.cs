using Microsoft.EntityFrameworkCore;
using System;
using Kin.TreeDB.Models;

namespace Kin.TreeDB
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
        public DbSet<Tree> TreeDbSet { get; set; }
    }
}
