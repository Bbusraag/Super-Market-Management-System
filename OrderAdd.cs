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
    public partial class OrderAdd : Form
    {
        private DbHomeworkContext db;
        public OrderAdd()
        {

            InitializeComponent();
            db = new DbHomeworkContext();
        }
        TblOrder order = new TblOrder();
        private void btnOrderDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbOrderID.Text);
            order = db.TblOrder.First(b => b.OrderIdPk == id);
            db.TblOrder.Remove(order);
            db.SaveChanges();
            lblMessage.Text = "Deleted";
        }


        private void btnOrderUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int orderıd = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    DateTime ınvoiceDate = Convert.ToDateTime(tbCreationDate.Text);
                    DateTime deliveryDate = Convert.ToDateTime(tbDeliveryDate.Text);
                    DateTime paymentDate = Convert.ToDateTime(tbPaymentDate.Text);


                    var ord = db.TblOrder.FirstOrDefault(x => x.OrderIdPk == orderıd);
                    ord.InvoiceCreationDate = ınvoiceDate;
                    ord.DeliveryDueDate = deliveryDate;
                    ord.PaymentDueDate = paymentDate;

                    db.TblOrder.Update(ord);
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
                    TblOrder tblOrder = new TblOrder();
                    tblOrder.OrderIdPk = order.OrderIdPk = Convert.ToInt32(tbOrderID.Text);
                    tblOrder.InvoiceCreationDate = order.InvoiceCreationDate = Convert.ToDateTime(tbCreationDate.Text);
                    tblOrder.DeliveryDueDate = order.DeliveryDueDate = Convert.ToDateTime(tbDeliveryDate.Text);
                    tblOrder.InvoiceCreationDate = order.InvoiceCreationDate = Convert.ToDateTime(tbCreationDate.Text);
                    tblOrder.PaymentDueDate = order.PaymentDueDate = Convert.ToDateTime(tbPaymentDate.Text);
                    db.TblOrder.Update(tblOrder);
                    db.SaveChanges();
                    lblMessage.Text = "Updated";
                    tbOrderID.Text = "";
                    tbCreationDate.Text = "";
                    tbDeliveryDate.Text = "";
                    tbPaymentDate.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/


        }

        private void btnOrderAdd_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime ınvoicedate = Convert.ToDateTime(tbCreationDate.Text);
                DateTime deliverydate = Convert.ToDateTime(tbDeliveryDate.Text);
                DateTime paymentdate = Convert.ToDateTime(tbPaymentDate.Text);


                TblOrder o = new TblOrder();
                o.OrderIdPk = 0;
                o.InvoiceCreationDate = ınvoicedate;
                o.DeliveryDueDate = deliverydate;
                o.PaymentDueDate = paymentdate;

                db.TblOrder.Add(o);
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
                    TblOrder tblOrder = new TblOrder();
                    tblOrder.OrderIdPk = order.OrderIdPk = Convert.ToInt32(tbOrderID.Text);
                    tblOrder.InvoiceCreationDate = order.InvoiceCreationDate = Convert.ToDateTime(tbCreationDate.Text);
                    tblOrder.DeliveryDueDate = order.DeliveryDueDate = Convert.ToDateTime(tbDeliveryDate.Text);
                    tblOrder.InvoiceCreationDate = order.InvoiceCreationDate = Convert.ToDateTime(tbCreationDate.Text);
                    tblOrder.PaymentDueDate = order.PaymentDueDate = Convert.ToDateTime(tbPaymentDate.Text);
                    db.TblOrder.Add(tblOrder);
                    db.SaveChanges();
                    lblMessage.Text = "Kayıt Oldunuz";
                    tbOrderID.Text = "";
                    tbCreationDate.Text = "";
                    tbDeliveryDate.Text = "";
                    tbPaymentDate.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void btnOrderDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int rowindex = dataGridView1.SelectedRows[0].Index;
                    int custıd= int.Parse(dataGridView1.Rows[rowindex].Cells[0].Value.ToString());


                    var c = db.TblOrder
                        .FirstOrDefault(x => x.OrderIdPk == custıd);

                    db.TblOrder.Remove(c);
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

            var custList = db.TblOrder.ToList();
            dataGridView1.DataSource = custList;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime searchtext = Convert.ToDateTime(tbSearch.Text.Trim());

                dataGridView1.DataSource = db.TblOrder
                      .Where(x => x.InvoiceCreationDate.Equals(searchtext))
                      .ToList();

            }
           
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TblOrder.ToList();

            try
            {
                dataGridView1.DataSource = (from c in db.TblOrder
                                            select new
                                            {
                                                c.OrderIdPk,
                                                c.InvoiceCreationDate,
                                                c.DeliveryDueDate,
                                                c.PaymentDueDate
                                            }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

       

       