
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

namespace ClassActivity
{
    public partial class Adreess : Form
    {
        private DbHomeworkContext db;
        public Adreess()
        {
            InitializeComponent();
           db = new DbHomeworkContext();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TblAddress.ToList();

            try
            {
                dataGridView1.DataSource = (from c in db.TblAddress
                                            select new
                                            {
                                                c.AddressIdPk,
                                                c.City,
                                                c.Country,
                                                c.State,
                                                c.Zip,
                                                c.Street
                                            }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchtext = tbSearch.Text.Trim();

                dataGridView1.DataSource = db.TblAddress
                      .Where(x => x.City.StartsWith(searchtext))
                      .ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int rowindex = dataGridView1.SelectedRows[0].Index;
                    int custıd = int.Parse(dataGridView1.Rows[rowindex].Cells[0].Value.ToString());


                    var c = db.TblAddress
                        .FirstOrDefault(x => x.AddressIdPk == custıd);

                    db.TblAddress.Remove(c);
                    db.SaveChanges();

                    ShowData();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ShowData()
        {

            var custList = db.TblAddress.ToList();
            dataGridView1.DataSource = custList;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {


                string Country = tbCountry.Text.Trim();
                string State = tbState.Text.Trim();
                string Street = tbStreet.Text.Trim();
                int Zip = Convert.ToInt32(tbZip.Text.Trim());
                string City = tbCity.Text.Trim();


               TblAddress cu = new TblAddress();
                cu.AddressIdPk = 0;
                cu.Country = Country;
                cu.State = State;
                cu.Street = Street;
               cu.Zip = Zip;
                cu.City = City;


                db.TblAddress.Add(cu);
                db.SaveChanges();

                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int custıd = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    string city = tbCity.Text.Trim();
                    string country = tbCountry.Text.Trim();
                    string state = tbState.Text.Trim();
                    string street = tbStreet.Text.Trim();
                    int zip = Convert.ToInt32(tbZip.Text.Trim());
                    var cust = db.TblAddress.FirstOrDefault(x => x.AddressIdPk == custıd);
                    cust.City = city;
                    cust.Country = country;
                    cust.State = state;
                    cust.Street = street;
                    cust.Zip = zip;

                    db.TblAddress.Update(cust);
                    db.SaveChanges();
                    ShowData();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }

