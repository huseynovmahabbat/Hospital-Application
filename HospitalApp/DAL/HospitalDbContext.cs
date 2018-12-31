using HospitalApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
