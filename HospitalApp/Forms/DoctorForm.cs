using HospitalApp.DAL;
using HospitalApp.Infrastructures;
using HospitalApp.Models;
using HospitalApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalApp.Forms
{
    public partial class DoctorForm : Form
    {
        Doctor currentDoctor = (Doctor)Session.GetValue("Doctor");
        List<DoctorPanel> allPatients = new List<DoctorPanel>();
        DoctorPanel selectedPatient = null;
        public DoctorForm()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            
            using (HospitalDbContext db = new HospitalDbContext())
            { 
                db.PatientNotes.Where(x => x.DoctorId == currentDoctor.Id && x.RecieptTime==selectedPatient.receiptTime).FirstOrDefault().Description = rtxbx_description.Text;
               await db.SaveChangesAsync();
               
            }
        }

        private async void DoctorForm_Load(object sender, EventArgs e)
        {
            try
            {
                List<PatientNote> Notes = null;
                using (HospitalDbContext db = new HospitalDbContext())
                {
                    Notes = await db.PatientNotes.Where(x => x.DoctorId == currentDoctor.Id).ToListAsync();
                }
                List<int> patientsId = new List<int>();
                Notes.ForEach(x => patientsId.Add(x.PatientId));
                List<Patient> Patients = new List<Patient>();
                using (HospitalDbContext db = new HospitalDbContext())
                {
                    foreach (int item in patientsId)
                    {
                        Patients.Add(await db.Patients.Where(x => x.Id == item).FirstOrDefaultAsync());
                    }
                }
               
                foreach (Patient item in Patients)
                {
                    foreach (PatientNote note in Notes)
                    {
                        if (note.PatientId == item.Id)
                            allPatients.Add(new DoctorPanel
                            {
                                Name = item.Name,
                                Surname = item.Surname,
                                receiptTime = note.RecieptTime,
                                Description = note.Description

                            });
                    }
                }

                List<string> fullNames = new List<string>();
                foreach (DoctorPanel item in allPatients)
                {
                    fullNames.Add($"{item.Name} {item.Surname}");
                };
                cbmx_patients.DataSource = fullNames;
                dtp_receipttime.Format = DateTimePickerFormat.Custom;
                dtp_receipttime.CustomFormat = "dd/MM/yyyy HH:mm";
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }

        private void cbmx_patients_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPatient = allPatients.Where(x => $"{x.Name} {x.Surname}".ToString() == cbmx_patients.SelectedItem.ToString()).FirstOrDefault();
            dtp_receipttime.Value = selectedPatient.receiptTime;
            rtxbx_description.Text = selectedPatient.Description;


        }

        private void DoctorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((LoginForm)Session.GetValue("MainForm")).Close();
        }
    }
}
