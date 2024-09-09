using FIT.Data;
using FIT.Data.IB190103;
using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace FIT.Infrastructure
{
    public class DLWMSDbContext : DbContext
    {
        private readonly string dbPutanja;

        public DLWMSDbContext()
        {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSBaza"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
    
        public DbSet<Student> Studenti { get; set; }
        public DbSet<PredmetiIB190103> Predmeti { get; set; }
        public DbSet<PolozeniPredmetiIB190103> PolozeniPredmeti { get; set; }
        public DbSet<SemestriIB190103> Semestri { get; set; }
        public DbSet<StudentiUvjerenjaIB190103> StudentiUvjerenjaIB190103 { get; set; }

    }
}