using CosmeticServer.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Serialization;

namespace CosmeticServer.DataContext
{
    public class AspnetNoteDbContext : DbContext
    {

        public AspnetNoteDbContext(DbContextOptions<AspnetNoteDbContext> options) : base(options)
        {

        }

        public DbSet<User>Users { get; set; }

        public DbSet<Note> Notes { get; set; }

        
    }
}
