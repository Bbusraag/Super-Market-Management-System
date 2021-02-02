using ClassActivity2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using DAL.Models;

namespace ClassActivity
{
    public partial class Customer_Login : Form
    {
        TblEmployee employee1 = new TblEmployee();
        TblEmployee employee2 = new TblEmployee();

            
            
        private DbHomeworkContext db;
        public Customer_Login()
        {

            InitializeComponent();
            db = new DbHomeworkContext();
        }
        /* private void btnLogin_Click(object sender, EventArgs e)
         {
             Gösterge_paneli form = new Gösterge_paneli();
             form.ShowDialog();
         }*/
       private Gösterge_paneli form;
        private void button1_Click(object sender, EventArgs e)
        {
            string userName = tbUserName.Text;
            string password = tbPassword.Text;
            try
            {
                employee1 = db.TblEmployee.First(u => u.FirstName == userName);
                employee2 = db.TblEmployee.First(p => p.Password == Convert.ToInt32(password));
                {

                    if (employee1.FirstName == userName && employee2.Password == Convert.ToInt32(password))
                    {
                        form = new Gösterge_paneli();
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("User Name or Password Wrong");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
       private CustomerRegister customerRegister;
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            customerRegister = new CustomerRegister();
            customerRegister.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }
















       /* private void tbEmail_Enter(object sender, EventArgs e)
        {
            if (tbEmail = "")
            {
                tbEmail.Text = "";
                tbEmail.ForeColor = Color.LightGray;
            }
        }
        */


       

       /* private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                tbEmail.Text = "Kullanıcı adı";
                tbEmail.ForeColor = Color.DimGray;
            }

        }
        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Password")
            {
                tbPassword.Text = "";
                tbPassword.ForeColor = Color.LightGray;
            }
        }
        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "";
                tbPassword.ForeColor = Color.DimGray;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}*/
