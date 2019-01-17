using HospitalApp.DAL;
using HospitalApp.Helpers;
using HospitalApp.Infrastructures;
using HospitalApp.Models;
using HospitalApp.Models.ViewModels;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace HospitalApp.Forms
{
    public partial class RegisterForm : Form
    {
        HospitalDbContext db = null;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            RegisterModel model = new RegisterModel
            {
                Name = txbx_name.Text,
                Email = txbx_email.Text,
                Surname = txbx_surname.Text,
                Password = txbx_pwd.Text,
                ConfirmPassword = txbx_cpwd.Text
            };
              bool validate =   CustomValidator.TryValidateObject(model,lbl_errors);
            if (validate)
            {
               
                try
                {
                    Patient patient = model;
                    db = new HospitalDbContext();
                    Patient findedPatient = db.Patients.Where(x => x.Email == patient.Email).FirstOrDefault();
                    if (findedPatient == null)
                    {
                        db.Patients.Add(patient);
                        db.SaveChanges();
                        LoginForm login = Session.GetValue("MainForm") as LoginForm;
                        login.Show();
                        Close();

                    }
                    else
                        MessageBox.Show("There is profile with this email");
                 
                }
                catch (SqlException ex)
                {

                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if(db!=null)
                    db.Dispose();
                }
            }
          
            

        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm login = (LoginForm)Session.GetValue("MainForm");
            login.Show();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            txbx_pwd.PasswordChar = '*';
            txbx_cpwd.PasswordChar = '*';
        }
    }
}
