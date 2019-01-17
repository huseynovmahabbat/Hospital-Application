using HospitalApp.DAL;
using HospitalApp.Forms;
using HospitalApp.Helpers;
using HospitalApp.Infrastructures;
using HospitalApp.Models;
using HospitalApp.Models.ViewModels;
using System;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace HospitalApp
{
    public partial class LoginForm : Form
    {
        HospitalDbContext db = null;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
           
            if(Session.GetValue("MainForm")==null)
            {
                Session.SetValue("MainForm", this);
             
            }
            Hide();
            RegisterForm form = new RegisterForm();
            form.Show();



        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            LoginModel user = new LoginModel
            {
                Login = txbx_login.Text,
                Password = txbx_pwd.Text
            };
            bool validate = CustomValidator.TryValidateObject(user, lbl_errors);
            if (validate)
            {
                
                if (checkBox1.Checked)
                {
                    try
                    {
                        db = new HospitalDbContext();
                        Doctor currentDoctor = await db.Doctors.Where(x => x.PIN.ToLower() == user.Login && x.Password == user.Password).FirstOrDefaultAsync();
                        if (currentDoctor != null)
                            ShowForm(typeof(DoctorForm), "Doctor", currentDoctor);
                        else
                            MessageBox.Show("You don't have doctor profile");
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
                else
                {
                    try
                    {
                        db = new HospitalDbContext();
                        Patient patient = await db.Patients.Where(x => x.Email.ToLower() == user.Login && x.Password == user.Password).FirstOrDefaultAsync();
                        if (patient != null)

                            ShowForm(typeof(PatientForm), "Patient", patient);
                        else
                            MessageBox.Show("You don't have patient profile");
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
 
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (Session.GetValue("MainForm") != null)
                ((LoginForm)Session.GetValue("MainForm")).Show();
            txbx_pwd.PasswordChar = '*';
        }
        private void ShowForm(Type form,string key,object obj)
        {
            if (Session.GetValue("MainForm") == null && Session.GetValue(key) == null)
            {
                Session.SetValue("MainForm", this);
                Session.SetValue(key, obj);

            }

            Hide();

            ((Form)Activator.CreateInstance(form)).Show();
        }
    }
}
