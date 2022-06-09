using Kolokwium2.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Kolokwium2.Contexts
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions options) : base(options)
        {
        }

        protected MainDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //Przykład danych zawarcia dwóch kluczy głównych oraz zasedowanie db
            /*
            modelBuilder.Entity<Prescription_Medicament> (pm => 
                {
                    pm.HasKey(k => new { k.IdMedicament, k.IdPrescription });
                    pm.HasData(new Prescription_Medicament { IdMedicament = 1, IdPrescription = 1, Dose = 10, Details = "" });
                    
                }
            );
            */
        }

        //Sekcja z DbSet
        //public DbSet<Doctor> Doctors { get; set; }
    }
}
