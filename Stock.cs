
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
    public partial class Stock : Form
    {
        private DbHomeworkContext db;
        public Stock()
        {
            InitializeComponent();
            db = new DbHomeworkContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TblStock.ToList();

            try
            {
                dataGridView1.DataSource = (from c in db.TblStock
                                            select new
                                            {
                                                c.StockId,
                                                c.StockName,
                                                c.StockPiece,
                                                c.StockPrice
                                            }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ShowData()
        {

            var custList = db.TblStock.ToList();
            dataGridView1.DataSource = custList;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int rowindex = dataGridView1.SelectedRows[0].Index;
                    int custıd = int.Parse(dataGridView1.Rows[rowindex].Cells[0].Value.ToString());


                    var c = db.TblStock
                        .FirstOrDefault(x => x.StockId == custıd);

                    db.TblStock.Remove(c);
                    db.SaveChanges();

                    ShowData();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            try
                {
                string name =(tbStockName.Text.Trim());
                int price = Convert.ToInt32(tbPrice.Text.Trim());
                int piece = Convert.ToInt32(tbPiece.Text.Trim());


                TblStock cu = new TblStock();
                cu.StockId = 0;
                cu.StockName = name;
                cu.StockPrice = price;
                cu.StockPiece = piece;

                db.TblStock.Add(cu);
                db.SaveChanges();

                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string searchtext = tbSearch.Text.Trim();

                dataGridView1.DataSource = db.TblStock
                      .Where(x => x.StockName.StartsWith(searchtext))
                      .ToList();

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
                    string name = tbStockName.Text.Trim();
                    int Price = Convert.ToInt32(tbPrice.Text.Trim());
                    int piece = Convert.ToInt32(tbPiece.Text.Trim());

                    var cust = db.TblStock.FirstOrDefault(x => x.StockId == custıd);
                    cust.StockName = name;
                    cust.StockPrice = Price;
                    cust.StockPiece = piece;

                    db.TblStock.Update(cust);
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

