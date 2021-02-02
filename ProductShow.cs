using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace ClassActivity
{
    public partial class ProductShow : Form
    {
        public ProductShow()
        {
            InitializeComponent();
        }

        private void GENEL_Enter(object sender, EventArgs e)
        {

        }





        public static string GidenBilgi { get; }
        public SqlCommand SqlCommand { get; private set; }

        SqlConnection baglanti = new SqlConnection(@"Server=.;Database=Super Market; Integrated Security=true;");
        private SqlCommand komut;




        private void Kapa_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }




        private void button9_Click(object sender, EventArgs e)
        {

            groupBox3.Visible = false;
            groupBox4.Visible = true;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;


        }

        private void Bakla_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = true;
            groupBox6.Visible = false;
            groupBox7.Visible = false;


        }

        private void Adetli_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = true;
            groupBox7.Visible = false;


        }

        private void Et_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;

        }

        private void Profil_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;


        }

        private void STOK_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = true;

        }


        private void Form1_Load(object sender, EventArgs e)
        {


            groupBox3.Dock = DockStyle.Fill;
            groupBox4.Dock = DockStyle.Fill;
            groupBox5.Dock = DockStyle.Fill;
            groupBox6.Dock = DockStyle.Fill;
            groupBox7.Dock = DockStyle.Fill;



        }

        private void button82_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '7'", baglantı);

            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglanti.Close();
        }







        private void Arien_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ProductShow GirisFormu = new ProductShow();
            GirisFormu.ShowDialog();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '46'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }






        private void listele()
        {
            tablo.Clear();
            baglantı.Open();
            komut = new SqlCommand("select * from Bilgiler", baglantı);
            adtr = new SqlDataAdapter(komut);
            adtr.Fill(tablo);

            baglantı.Close();

        }

        public void verilerigörüntüle()
        {


        }


        private void GOSTER_Click(object sender, EventArgs e)
        {

        }


        SqlConnection baglantı = new SqlConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb");
        SqlDataAdapter adtr;
        SqlCommand sqlCommand;
        DataTable tablo = new DataTable();
        private void button2_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }
        SqlConnection baglantı2 = new SqlConnection(@"Server=.;Database=Super Market; Integrated Security=true;");
        SqlCommand komut2;
        SqlDataAdapter adtr2;
        DataTable tablo2 = new DataTable();

        private void listele2()
        {
            tablo2.Clear();
            baglantı2.Open();
            komut2 = new SqlCommand("select * from Bilgiler", baglantı2);
            adtr2 = new SqlDataAdapter(komut2);
            adtr2.Fill(tablo2);

            baglantı2.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listele2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglantı2.Open();

            komut2.ExecuteNonQuery();
            baglantı2.Close();
            listele2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglantı2.Open();
            komut2.ExecuteNonQuery();
            baglantı2.Close();
            listele2();


        }




        //--------------------------------HESAP MAKİNESİ----------------------------------
        string islem;
        double sayi, sayi2, sonuc;
        private void button6_Click_1(object sender, EventArgs e)
        {
            if (textBox13.Text == "0")
            {
                textBox13.Text = "1";
            }
            else
            {
                textBox13.Text += "1";
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (textBox13.Text == "0")
            {
                textBox13.Text = "2";
            }
            else
            {
                textBox13.Text += "2";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox13.Text == "0")
            {
                textBox13.Text = "3";
            }
            else
            {
                textBox13.Text += "3";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox13.Text == "0")
            {
                textBox13.Text = "4";
            }
            else
            {
                textBox13.Text += "4";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox13.Text == "0")
            {
                textBox13.Text = "5";
            }
            else
            {
                textBox13.Text += "5";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox13.Text == "0")
            {
                textBox13.Text = "6";
            }
            else
            {
                textBox13.Text += "6";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox13.Text == "0")
            {
                textBox13.Text = "7";
            }
            else
            {
                textBox13.Text += "7";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox13.Text == "0")
            {
                textBox13.Text = "8";
            }
            else
            {
                textBox13.Text += "8";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox13.Text == "0")
            {
                textBox13.Text = "9";
            }
            else
            {
                textBox13.Text += "9";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox13.Text == "0")
            {
                textBox13.Text = "0";
            }
            else
            {
                textBox13.Text += "0";
            }
        }

        private void button22_Click_1(object sender, EventArgs e)
        {

            islem = "+";
            sayiYaz1();
        }

        private void button23_Click(object sender, EventArgs e)
        {

            islem = "x";
            sayiYaz1();
        }

        private void Button9_Click(object sender, EventArgs e)
        {

            islem = "/";
            sayiYaz1();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            islem = "-";
            sayiYaz1();
        }
        void sayiYaz1()
        {
            if (textBox13.Text != "")
            {
                sayi = Convert.ToDouble(textBox13.Text);
                label13.Text = sayi.ToString() + islem.ToString();
                textBox13.Text = "";

            }
            else
            {
                label13.Text = "Sayı boş bir değer alamaz";
            }


        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.Text == "Geçmişi Göster")
            {
                groupBox11.Visible = true;
                button15.Text = "Geçmili Gizle";
            }
            else
            {
                groupBox11.Visible = false;
                button15.Text = "Geçmişi Göster";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox13.Text = "";
            label13.Text = "";
        }

        private void button54_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '42'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();



        }

        private void Meyve_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Meyve_Leave(object sender, EventArgs e)
        {

        }

        private void button53_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '43'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '1'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void ELMA_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '2'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void UZUM_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '3'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void KIRAZ_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '4'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void CILEK_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '5'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void KARPUZ_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '6'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void ANANAS_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '8'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void PATATES_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '9'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void DOMATES_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '10'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void SOGAN_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '11'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void LIMON_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '12'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void PATLICAN_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '13'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void BIBER_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '14'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }



        private void HAVUC_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '16'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void sut_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '17'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void acıksut_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '18'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void yesilzeytin_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '19'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void siyahzeytin_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '20'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void DomatZeytini_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '21'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void Tulum_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '22'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void SızmaZeytinyagı_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '23'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void Ezine_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '24'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void Zeytinyagı_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '25'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void Mercimek_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '26'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void Pilav_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '27'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void FiyonkMakarna_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '28'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void Spagetti_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '29'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void kurubakla_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '30'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void baklaa_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '31'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void Nohut_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '32'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void Bulgur_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '33'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void Bezelye_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '34'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void Tuz_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '35'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void Seker_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '36'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void Fındık_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '37'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void Fıstık_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '38'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void AntepFıstıgı_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '39'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void Badem_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '40'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void Leblebi_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '41'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void button52_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '44'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '45'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '47'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '48'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '49'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '50'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void button63_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '51'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void button62_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '52'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '53'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void button60_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '54'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void button59_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '55'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void button58_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '56'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '57'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void button56_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '58'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void button55_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand = new SqlCommand("SELECT Fiyat FROM Bilgiler where Numara = '59'", baglantı);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            if (reader.Read())
            {
                double i = double.Parse(reader[0].ToString());
                textBox13.Text = i.ToString();


            }

            baglantı.Close();
        }

        private void Meyve_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void Bakla_Click_1(object sender, EventArgs e)
        {

        }

        void sayiYaz2()
        {
            label13.Text = sayi.ToString() + islem.ToString() + sayi2.ToString() + "=" + sonuc.ToString();
            textBox13.Text = sonuc.ToString();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox13.Text != "") sayi2 = Convert.ToDouble(textBox13.Text);
            else label13.Text = "Sayı Girmediniz...";
            switch (islem)
            {
                case "+":
                    sonuc = sayi + sayi2;
                    sayiYaz2();
                    break;

                case "-":
                    sonuc = sayi - sayi2;
                    sayiYaz2();

                    break;

                case "/":
                    sonuc = sayi / sayi2;
                    sayiYaz2();

                    break;

                case "x":
                    sonuc = sayi * sayi2;
                    sayiYaz2();

                    break;


            }
            listBox1.Items.Add(label13.Text);
        }
    }
}