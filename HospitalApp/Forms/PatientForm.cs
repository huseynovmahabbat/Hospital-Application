using HospitalApp.DAL;
using HospitalApp.Infrastructures;
using HospitalApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HospitalApp.Forms
{
    public partial class PatientForm : Form
    {
        List<Doctor> doctors = new List<Doctor>();

       
        public PatientForm()
        {
            InitializeComponent();
           
        }


        
        private async void PatientForm_Load(object sender, EventArgs e)
        {
           
            try
            {

               List<string> specialtiesName = new List<string>();
              
                using (HospitalDbContext db = new HospitalDbContext())
                {
                    await db.Specialties.ForEachAsync(x => specialtiesName.Add(x.Name));
               
                }
       
                cmbx_disease.DataSource=specialtiesName;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            
        }

        private async void cmbx_disease_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            List<string> doctorNames = new List<string>();
            try
            {
                
                Patient currentPatient = (Patient)Session.GetValue("Patient");

                using (HospitalDbContext db = new HospitalDbContext())
                {
                    DoctorSpecialty selectedSpecialty = await db.Specialties.Where(x => x.Name == cmbx_disease.SelectedItem.ToString()).FirstOrDefaultAsync();
                    doctors = await db.Doctors.Where(x => x.SpecialtyId == selectedSpecialty.Id).ToListAsync();
                    doctors.ForEach(x => doctorNames.Add($"{x.Name} {x.Surname}"));
                  
                }
   
                cbmx_doctors.DataSource = doctorNames; //
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

       

        private async void btn_add_Click(object sender, EventArgs e)
        {
            List<RadioButton> allTimes = new List<RadioButton>
            {
            rdbtn_time1,rdbtn_time2,rdbtn_time3,rdbtn_time4,rdbtn_time5,rdbtn_time6,rdbtn_time7,rdbtn_time8,rdbtn_time9
            };

             RadioButton selectedTime =  allTimes.Where(x => x.Checked == true && x.BackColor != Color.Red).FirstOrDefault();
             string selectedDateTime = $"{dtp_doctor_time.Value.ToString("yyyy/MM/dd")}  {selectedTime.Text}:00";
            Doctor selectedDoctor = doctors.Where(x => $"{x.Name} {x.Surname}".ToString() == cbmx_doctors.SelectedItem.ToString()).FirstOrDefault();
            try
            {
                PatientNote note = new PatientNote
                {
                    DoctorId = selectedDoctor.Id,
                    PatientId = ((Patient)Session.GetValue("Patient")).Id,
                    RecieptTime = DateTime.Parse(selectedDateTime),
                };
                
                using (HospitalDbContext db = new HospitalDbContext())
                {
                    db.PatientNotes.Add(note);
                    await db.SaveChangesAsync();

                }
                MessageBox.Show("Your offer has been saved.");
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private  void dtp_doctor_time_ValueChanged(object sender, EventArgs e)
        {
   
            TimeControl();

        }



        private async void TimeControl()
        {
            List<PatientNote> patientNotes = null;
            List<RadioButton> allTimes = new List<RadioButton>
            {
            rdbtn_time1,rdbtn_time2,rdbtn_time3,rdbtn_time4,rdbtn_time5,rdbtn_time6,rdbtn_time7,rdbtn_time8,rdbtn_time9
            };
            allTimes.Where(x => x.BackColor == Color.Red && x.Appearance == Appearance.Button).ToList().ForEach(x => { x.Appearance = Appearance.Normal; x.BackColor = SystemColors.Control; });

            try
            {
                
                    
                    {
                        Doctor selectedDoctor = doctors.FirstOrDefault(x => $"{x.Name} {x.Surname}".ToString() == cbmx_doctors.SelectedItem.ToString());
                        using (HospitalDbContext db = new HospitalDbContext())
                        {
                            patientNotes = await db.PatientNotes.Where(x => x.DoctorId == selectedDoctor.Id).ToListAsync();
                        }
                        foreach (RadioButton item in allTimes)
                        {
                            foreach (PatientNote receiptTime in patientNotes)
                            {
                                if (dtp_doctor_time.Value.ToString("yyyy/MM/dd") == receiptTime.RecieptTime.ToString("yyyy/MM/dd"))
                                    if (item.Text == $"{receiptTime.RecieptTime.Hour}:00")
                                    {

                                        item.Appearance = Appearance.Button;
                                        item.BackColor = Color.Red;
                                    }
                            }

                        }
                    }
             
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (ArgumentNullException ex)
            {

                MessageBox.Show(ex.Message);
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

    

        private void cbmx_doctors_SelectedIndexChanged(object sender, EventArgs e)
        {
             TimeControl();
        }

        private void PatientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((LoginForm)Session.GetValue("MainForm")).Close();
        }
    }
}
