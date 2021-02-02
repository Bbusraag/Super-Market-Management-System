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
    public partial class EmployeeAdd : Form
    {
        private DbHomeworkContext db;
       public EmployeeAdd() { 
        
            InitializeComponent();
            db = new DbHomeworkContext();
        }
   
        //TblEmployee employee = new TblEmployee();
        private void btnEmployeeDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int rowindex = dataGridView1.SelectedRows[0].Index;
                    int custıd = int.Parse(dataGridView1.Rows[rowindex].Cells[0].Value.ToString());


                    var c = db.TblEmployee
                        .FirstOrDefault(x => x.EmployeIdPk == custıd);

                    db.TblEmployee.Remove(c);
                    db.SaveChanges();

                    ShowData();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            /* int id = Convert.ToInt32(TxtID.Text);
             employee = db.TblEmployee.First(b => b.EmployeIdPk == id);
             db.TblEmployee.Remove(employee);
             db.SaveChanges();
             lblMesaage.Text = "Deleted";*/
        }

        private void btnEmployeADD_Click(object sender, EventArgs e)
        {
            try
            {


                string firstname = tbName.Text.Trim();
                string lastname = tbSurname.Text.Trim();
                string email = tbEmail.Text.Trim();
                int password = Convert.ToInt32(tbPassword.Text.Trim());

                TblEmployee cu = new TblEmployee();
                cu.EmployeIdPk = 0;
                cu.FirstName = firstname;
                cu.LastName = lastname;
                cu.Email = email;
                cu.Password = password;

                db.TblEmployee.Add(cu);
                db.SaveChanges();

                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*try
            {
                using (DbHomeworkContext db = new DbHomeworkContext())
                {
                    TblEmployee tblEmploye = new TblEmployee();
                    tblEmploye.FirstName = tbName.Text.Trim();
                    tblEmploye.LastName = tbSurname.Text.Trim();
                    tblEmploye.Email = tbEmail.Text.Trim();
                    tblEmploye.Password = employee.Password = Convert.ToInt32(tbPassword.Text);
                    db.TblEmployee.Add(tblEmploye);
                    db.SaveChanges();
                    lblMesaage.Text = "Kayıt Oldunuz";
                    tbName.Text = "";
                    tbSurname.Text = "";
                    tbPassword.Text = "";
                    tbEmail.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
        private void ShowData()
        {

            var custList = db.TblEmployee.ToList();
            dataGridView1.DataSource = custList;

        }



        private void btnEmployeeUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int custıd = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    string firstname = tbName.Text.Trim();
                    string lastname = tbSurname.Text.Trim();
                    string email = tbEmail.Text.Trim();
                    int password =Convert.ToInt32( tbPassword.Text.Trim());


                    var cust = db.TblEmployee.FirstOrDefault(x => x.EmployeIdPk == custıd);
                    cust.FirstName = firstname;
                    cust.LastName = lastname;
                    cust.Email = email;
                    cust.Password = password;
                    db.TblEmployee.Update(cust);
                    db.SaveChanges();
                    ShowData();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*try
            {
                using (DbHomeworkContext db = new DbHomeworkContext())
                {
                    TblEmployee tblEmploye = new TblEmployee();
                    tblEmploye.FirstName = tbName.Text.Trim();
                    tblEmploye.LastName = tbSurname.Text.Trim();
                    tblEmploye.Email = tbEmail.Text.Trim();
                    tblEmploye.Password = employee.Password=Convert.ToInt32(tbPassword.Text);
                    db.TblEmployee.Update(tblEmploye);
                    db.SaveChanges();
                    lblMesaage.Text = "Updated";
                    TxtID.Text = "";
                    tbName.Text = "";
                    tbSurname.Text = "";
                    tbEmail.Text = "";
                    tbPassword.Text = "";
                }
 }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchtext = tbSearch.Text.Trim();

                dataGridView1.DataSource = db.TblEmployee
                      .Where(x => x.FirstName.StartsWith(searchtext))
                      .ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TblEmployee.ToList();

            try
            {
                dataGridView1.DataSource = (from c in db.TblEmployee
                                            select new
                                            {
                                                c.EmployeIdPk,
                                                c.FirstName,
                                                c.LastName,
                                                c.Email
                                            }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }
    

