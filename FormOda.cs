using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel2
{
    public partial class FormOda : Form
    {
        public FormOda()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432;Database=dbOtel2;userid=postgres;password=125678943aS");
        private void FormOda_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("Select * from kategoriler",baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            kategoricb.DisplayMember = "kategoriad";
            kategoricb.ValueMember = "kategoriid";
            kategoricb.DataSource = dt; //Kaynaktan gelen verileri dt ye attık.
            baglanti.Close();
        }

        private void listelebtn_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from odalar";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu,baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            //odatipitxt.Text = kategoricb.SelectedValue.ToString();
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into odalar (odaid,odatipi,bosodasayisi,odafiyat,odagorsel,kategori) " +
                "values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1",int.Parse(odaidtxt.Text));
            komut.Parameters.AddWithValue("@p2", odatipitxt.Text);
            komut.Parameters.AddWithValue("@p3",int.Parse(odasayisinud.Value.ToString()));
            komut.Parameters.AddWithValue("@p4", double.Parse(odafiyatitxt.Text));
            komut.Parameters.AddWithValue("@p5", gorseltxt.Text);
            komut.Parameters.AddWithValue("@p6",int.Parse(kategoricb.SelectedValue.ToString()));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oda kaydınız başarılı bir şekilde gercekleşti","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("Delete from odalar where odaid=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1",int.Parse(odaidtxt.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oda silme işlemi başarılı bir şekilde gerçekleşti.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Stop);
        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("Update odalar set bosodasayisi=@p1, odafiyat=@p2 where odaid=@p3",baglanti);
            komut3.Parameters.AddWithValue("@p1",int.Parse(odasayisinud.Value.ToString()));
            komut3.Parameters.AddWithValue("@p2",double.Parse(odafiyatitxt.Text));
            komut3.Parameters.AddWithValue("@p3",int.Parse(odaidtxt.Text));
            komut3.ExecuteNonQuery();
            MessageBox.Show("Oda güncelleme işlemi başarılı bir şekilde gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            baglanti.Close();
        }

        private void arabtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut4 = new NpgsqlCommand("select * from public.odalistesi where odatipi=@p1", baglanti);
            komut4.Parameters.AddWithValue("@p1", odatipitxt.Text);
            komut4.ExecuteNonQuery();
            MessageBox.Show("Aranan oda bulundu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut4);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void menubtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut5 = new NpgsqlCommand("Select * from odalistesi",baglanti);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut5);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void kategoribtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKategori formKategori= new FormKategori();
            formKategori.Show();
        }

        private void musteribtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMusteri formMusteri= new FormMusteri();
            formMusteri.Show();
        }
    }
}
