using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel2
{
    public partial class FormMusteri : Form
    {
        public FormMusteri()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432;Database=dbOtel2;userid=postgres;password=125678943aS");
        private void listelebtn_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from musteriler order by musteriid";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into musteriler (musteriid,musteriad,musterisoyad,musteritelno,musteriemail) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(musteriidtxt.Text));
            komut1.Parameters.AddWithValue("@p2", musteriadtxt.Text);
            komut1.Parameters.AddWithValue("@p3", musterisoyadtxt.Text);
            komut1.Parameters.AddWithValue("@p4", musteritelnotxt.Text);
            komut1.Parameters.AddWithValue("@p5", musteriemailtxt.Text);
            komut1.ExecuteNonQuery(); //degisiklikleri veritabanına yansitiyoruz.
            baglanti.Close();
            MessageBox.Show("Müşteri kaydınız başarılı bir şekilde gercekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("Delete from musteriler where musteriid=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(musteriidtxt.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri silme işlemi başarılı bir şekilde gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("Update musteriler set musteriad=@p1,musterisoyad=@p2,musteritelno=@p3,musteriemail=@p4 where musteriid=@p5", baglanti);
            komut3.Parameters.AddWithValue("@p1", musteriadtxt.Text);
            komut3.Parameters.AddWithValue("@p2", musterisoyadtxt.Text);
            komut3.Parameters.AddWithValue("@p3", musteritelnotxt.Text);
            komut3.Parameters.AddWithValue("@p4", musteriemailtxt.Text);
            komut3.Parameters.AddWithValue("@p5", int.Parse(musteriidtxt.Text));
            komut3.ExecuteNonQuery();
            MessageBox.Show("Müşteri güncelleme işlemi başarılı bir şekilde gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            baglanti.Close();
        }

        private void arabtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut4 = new NpgsqlCommand("select * from musteriler where musteriad=@p1 or musterisoyad=@p2", baglanti);
            komut4.Parameters.AddWithValue("@p1",musteriadtxt.Text);
            komut4.Parameters.AddWithValue("@p2",musterisoyadtxt.Text);
            komut4.ExecuteNonQuery();
            MessageBox.Show("Aranan müşteri bulundu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut4);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void kategoribtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKategori formKategori = new FormKategori();
            formKategori.Show();
        }

        private void odabtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOda formOda = new FormOda();
            formOda.Show();
        }
    }
}
