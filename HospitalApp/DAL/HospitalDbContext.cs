using HospitalApp.Models;
using System.Data.Entity;

namespace HospitalApp.DAL
{
    public class HospitalDbContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorSpecialty> Specialties { get; set; } 
        public DbSet<PatientNote> PatientNotes { get; set; }
        public HospitalDbContext() : base("db") { }
       

    }
}
