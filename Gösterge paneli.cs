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
    public partial class Gösterge_paneli : Form
    {
        private DbHomeworkContext db;
        public Gösterge_paneli()
        {
            InitializeComponent();
            db = new DbHomeworkContext();
        }

        private void Meyve_Click(object sender, EventArgs e)
        {
            try
            {
                ProductShow form = new ProductShow();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Peynir_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerAdd form = new CustomerAdd();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Bakla_Click(object sender, EventArgs e)
        {
            try
            {
                AddProduct form = new AddProduct();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Adetli_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeAdd form = new EmployeeAdd();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Et_Click(object sender, EventArgs e)
        {
            try
            {
                OrderAdd form = new OrderAdd();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Profil_Click(object sender, EventArgs e)
        {
            try
            {
                Stock form = new Stock();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private Help help;
        private void STOK_Click(object sender, EventArgs e)
        {
            help = new Help();
            help.Show();

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBasket_Click(object sender, EventArgs e)
        {
            try
            {
                Basket form = new Basket();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Altaindir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Kapa_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Adreess form = new Adreess();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

 



