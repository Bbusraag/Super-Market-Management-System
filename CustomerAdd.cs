using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassActivity2.Model;
//using DAL.Models;
namespace ClassActivity
{
    public partial class CustomerAdd : Form
    {
        private DbHomeworkContext db;
        public CustomerAdd()
        {
            InitializeComponent();
            db = new DbHomeworkContext();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            try
            {
                

                    string firstname = tbName.Text.Trim();
                    string lastname = tbSurname.Text.Trim();
                    string email = tbEmail.Text.Trim();


                    TblCustomer cu = new TblCustomer();
                    cu.CustomerIdPk = 0;
                    cu.FirstName = firstname;
                    cu.LastName = lastname;
                    cu.Email = email;

                    db.TblCustomer.Add(cu);
                    db.SaveChanges();

                    ShowData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            /* using (DbHomeworkContext db = new DbHomeworkContext())
             {
                 TblCustomer tblCustomer = new TblCustomer();
                 tblCustomer.FirstName = tbName.Text.Trim();
                 tblCustomer.LastName = tbSurname.Text.Trim();
                 tblCustomer.Email = tbEmail.Text.Trim();
                 db.TblCustomer.Add(tblCustomer);
                 db.SaveChanges();
                 lblMessage.Text = "Kayıt Oldunuz";
                 tbName.Text = "";
                 tbSurname.Text = "";
                 tbEmail.Text = "";

             }
         }*/
            
        //TblCustomer customer = new TblCustomer();
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int rowindex = dataGridView1.SelectedRows[0].Index;
                    int custıd = int.Parse(dataGridView1.Rows[rowindex].Cells[0].Value.ToString());


                    var c = db.TblCustomer
                        .FirstOrDefault(x => x.CustomerIdPk == custıd);

                    db.TblCustomer.Remove(c);
                    db.SaveChanges();

                    ShowData();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /* int id = Convert.ToInt32(TxtID.Text);
         customer = db.TblCustomer.First(b => b.CustomerIdPk == id);
         db.TblCustomer.Remove(customer);
         db.SaveChanges();
         lblMessage.Text = "Deleted";
     }*/
        private void ShowData()
        {

            var custList = db.TblCustomer.ToList();
            dataGridView1.DataSource = custList;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int custıd = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    string firstname = tbName.Text.Trim();
                    string lastname = tbSurname.Text.Trim();
                    string email = tbEmail.Text.Trim();
                  

                    var cust = db.TblCustomer.FirstOrDefault(x => x.CustomerIdPk == custıd);
                    cust.FirstName = firstname;
                    cust.LastName = lastname;
                    cust.Email = email;

                    db.TblCustomer.Update(cust);
                    db.SaveChanges();
                    ShowData();


                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

        /*try
        {
            using (DbHomeworkContext db = new DbHomeworkContext())
            {
                TblCustomer tblCustomer = new TblCustomer();
                tblCustomer.FirstName = tbName.Text.Trim();
                tblCustomer.LastName = tbSurname.Text.Trim();
                tblCustomer.Email = tbEmail.Text.Trim();
                 db.TblCustomer.Update(tblCustomer);
                    db.SaveChanges();
                lblMessage.Text = "Updated";
                TxtID.Text = "";
                tbName.Text = "";
                tbSurname.Text = "";
                tbEmail.Text = "";


            }



        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }*/
    

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TblCustomer.ToList();

            try
            {
                dataGridView1.DataSource = (from c in db.TblCustomer
                                            select new
                                            {
                                                c.CustomerIdPk,
                                                c.Email,
                                                c.FirstName,
                                                c.LastName
                                            }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string searchtext = tbSearch.Text.Trim();

                dataGridView1.DataSource = db.TblCustomer
                      .Where(x => x.FirstName.StartsWith(searchtext))
                      .ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
    }
    


