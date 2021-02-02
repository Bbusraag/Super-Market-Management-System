
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

namespace ClassActivity
{
    public partial class CustomerRegister : Form
    {
        private DbHomeworkContext db;
        public CustomerRegister()
        {
            InitializeComponent();
            db = new DbHomeworkContext();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
         TblEmployee employee = new TblEmployee();
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                employee.FirstName = tbUsername.Text;
                employee.LastName = tbSurname.Text;
                employee.Password = Convert.ToInt32(tbPassword.Text);
                employee.Email = tbEmail.Text;
                
                db.TblEmployee.Add(employee);
                db.SaveChanges();
                MessageBox.Show("Sign Up Is Successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_Login GirisForm = new Customer_Login();
            GirisForm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CustomerRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
