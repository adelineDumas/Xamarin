using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetIncident.Core.DAL
{
    public class IncidentDbContext : DbContext
    {
        private static IncidentDbContext _context = null; 

        public async static Task<IncidentDbContext> GetCurrent(){
            if (_context == null){
                _context = new IncidentDbContext(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "incidents.db"));
                await _context.Database.MigrateAsync(); 
            }
            return _context; 
        }

        public string DatabasePath { get;}
        public DbSet<Model.User> Users { get; set; }
        public DbSet<Model.Incident> Incidents { get; set; }
        public DbSet<Model.Category> Categories { get; set; }
        public DbSet<Model.Photo> Photos { get; set; }


        private  IncidentDbContext(string pDatabasePath)
        {
            DatabasePath = pDatabasePath; 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite($"Filename={DatabasePath}");
        }
    }
}
