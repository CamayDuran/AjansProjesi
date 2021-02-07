using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneAjansProjesi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Ajans ajans = new Ajans();
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-DE6TC4RE;Initial Catalog=Ajans;Integrated Security=True");
        private void Form3_Load(object sender, EventArgs e)
        {
            SqlDataAdapter musteri_da = new SqlDataAdapter("Select adi,musaitlik,isAdi,baslamaTarih,bitisTarih,maas,izinGunu,firmaID from tblMusteri", baglanti);
            SqlDataAdapter firma_da = new SqlDataAdapter("Select * from tblFirma", baglanti);
            SqlDataAdapter maliDurum_da = new SqlDataAdapter("Select * from tblMaliDurum", baglanti);
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();
            DataSet ds3 = new DataSet();

            musteri_da.Fill(ds1);
            firma_da.Fill(ds2);
            maliDurum_da.Fill(ds3);
            dataGridView1.DataSource = ds1.Tables[0];
            dataGridView2.DataSource = ds2.Tables[0];

            //iş sayısı 3ten fazla olanları göster
            SqlDataAdapter goster = new SqlDataAdapter("Select * from tblFirma where isSayisi>=3 ", baglanti);
            DataSet ds = new DataSet();
            goster.Fill(ds);
            dataGridView4.DataSource = ds.Tables[0];

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //iş sayısı 3ten fazla olanlara %20 indirim yap
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update tblFirma set alinacakPara = (alinacakPara-(alinacakPara*20/100))", baglanti);
            guncelle.ExecuteNonQuery();

            SqlDataAdapter goster = new SqlDataAdapter("Select * from tblFirma where isSayisi>=3 ", baglanti);
            DataSet ds = new DataSet();
            goster.Fill(ds);
            dataGridView4.DataSource = ds.Tables[0];

            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter goster = new SqlDataAdapter("Select tarih,gelir,gider,(gelir-gider) as 'kar-zarar' from tblMaliDurum ", baglanti);
            DataSet ds = new DataSet();
            goster.Fill(ds);
            dataGridView5.DataSource = ds.Tables[0];
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();


            SqlCommand guncelle = new SqlCommand("Update tblMusteri set izinGunu=@izinGunu where calisanID=@id ", baglanti);
            guncelle.Parameters.AddWithValue("@izinGunu", textBox_izinGunu.Text);
            guncelle.Parameters.AddWithValue("@id", textBox_id.Text);
            guncelle.ExecuteNonQuery();

            SqlDataAdapter goster = new SqlDataAdapter("Select adi,musaitlik,isAdi,baslamaTarih,bitisTarih,maas,izinGunu,firmaID from tblMusteri ", baglanti);
            DataSet ds = new DataSet();
            goster.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglanti.Close();
        }
    }
}
