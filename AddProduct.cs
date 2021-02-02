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
    public partial class AddProduct : Form
    {
        private DbHomeworkContext db;
        public AddProduct()
        {
            InitializeComponent();
            db = new DbHomeworkContext();
        }





        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            try
            {


                string name = tbProductName.Text.Trim();
                int price = Convert.ToInt32(tbPrice.Text.Trim());
                string qantity = tbProductQuantity.Text.Trim();


                TblProduct cu = new TblProduct();
                cu.ProductIdPk = 0;
                cu.Name = name;
                cu.Price = price;
                cu.ProductQuantity = qantity;

                db.TblProduct.Add(cu);
                db.SaveChanges();

                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
        private void ShowData()
        {

            var custList = db.TblProduct.ToList();
            dataGridView1.DataSource = custList;

        }


        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int rowindex = dataGridView1.SelectedRows[0].Index;
                    int custıd = int.Parse(dataGridView1.Rows[rowindex].Cells[0].Value.ToString());


                    var c = db.TblProduct
                        .FirstOrDefault(x => x.ProductIdPk == custıd);

                    db.TblProduct.Remove(c);
                    db.SaveChanges();

                    ShowData();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
           

            private void btnShow_Click(object sender, EventArgs e)
            {
            dataGridView1.DataSource = db.TblProduct.ToList();

            try
            {
                dataGridView1.DataSource = (from c in db.TblProduct
                                            select new
                                            {
                                                c.ProductIdPk,
                                                c.Name,
                                                c.Price,
                                                c.ProductQuantity
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

                dataGridView1.DataSource = db.TblProduct
                      .Where(x => x.Name.StartsWith(searchtext))
                      .ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int custıd = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    string name = tbProductName.Text.Trim();
                    int Price =Convert.ToInt32(tbPrice .Text.Trim());
                    string quantity = tbProductQuantity.Text.Trim();

                    var cust = db.TblProduct.FirstOrDefault(x => x.ProductIdPk == custıd);
                    cust.Name = name;
                    cust.Price = Price;
                    cust.ProductQuantity =quantity;

                    db.TblProduct.Update(cust);
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
        
    

