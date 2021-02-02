
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
    public partial class Basket : Form
    {
        private DbHomeworkContext db;
        public Basket()
        {
            InitializeComponent();
            db = new DbHomeworkContext();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TblBasket.ToList();

            try
            {
                dataGridView1.DataSource = (from c in db.TblBasket
                                            select new
                                            {
                                                c.BasketId,
                                                c.BasketBarkod,
                                                c.Piece,
                                                c.Price,
                                                
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
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int rowindex = dataGridView1.SelectedRows[0].Index;
                    int custıd = int.Parse(dataGridView1.Rows[rowindex].Cells[0].Value.ToString());


                    var c = db.TblBasket

                        .FirstOrDefault(x => x.BasketId == custıd);

                    db.TblBasket.Remove(c);
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

            var custList = db.TblBasket.ToList();
            dataGridView1.DataSource = custList;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
               int searchtext = Convert.ToInt32(tbSearch.Text.Trim());

                dataGridView1.DataSource = db.TblBasket
                      .Where(x => x.BasketId.Equals(searchtext))
                      .ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {


                int Barkod = Convert.ToInt32(tbBarkod.Text.Trim());
                int price = Convert.ToInt32(tbPrice.Text.Trim());
                 int piece = Convert.ToInt32(tbPiece.Text.Trim());


                TblBasket cu = new TblBasket();
                cu.BasketId = 0;
                cu.BasketBarkod = Barkod;
                cu.Price = price;
                cu.Piece = piece;

                db.TblBasket.Add(cu);
                db.SaveChanges();

                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int custıd = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    int Barkod = Convert.ToInt32(tbBarkod.Text.Trim());
                    int Price = Convert.ToInt32(tbPrice.Text.Trim());
                    int Piece = Convert.ToInt32(tbPiece.Text.Trim());

                    var cust = db.TblBasket.FirstOrDefault(x => x.BasketId == custıd);
                    cust.BasketBarkod = Barkod;
                    cust.Price = Price;
                    cust.Piece = Piece;

                    db.TblBasket.Update(cust);
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


