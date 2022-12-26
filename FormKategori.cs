using Npgsql;
using System.Data;

namespace Otel2
{
    public partial class FormKategori : Form
    {
        public FormKategori()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432;Database=dbOtel2;userid=postgres;password=125678943aS");

        private void listelebtn_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from kategoriler order by kategoriid";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into kategoriler (kategoriid,kategoriad) values (@p1,@p2)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(kategoriidtxt.Text));
            komut1.Parameters.AddWithValue("@p2", kategoriadtxt.Text);
            komut1.ExecuteNonQuery(); //degisiklikleri veritabanýna yansitiyoruz.
            baglanti.Close();
            MessageBox.Show("Kategori ekleme iþlemi baþarýlý.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("Delete from kategoriler where kategoriid=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(kategoriidtxt.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategori silme iþlemi baþarýlý bir þekilde gerçekleþti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut4 = new NpgsqlCommand("Update kategoriler set kategoriad=@p1 where kategoriid=@p2", baglanti);
            komut4.Parameters.AddWithValue("@p1", kategoriadtxt.Text);
            komut4.Parameters.AddWithValue("@p2", int.Parse(kategoriidtxt.Text));
            komut4.ExecuteNonQuery();
            MessageBox.Show("Kategori güncelleme iþlemi baþarýlý bir þekilde gerçekleþti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            baglanti.Close();
        }

        private void arabtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut4 = new NpgsqlCommand("select * from kategoriler where kategoriad=@p1", baglanti);
            komut4.Parameters.AddWithValue("@p1", kategoriadtxt.Text);
            komut4.ExecuteNonQuery();
            MessageBox.Show("Aranan oda bulundu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut4);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void odabtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOda formOda= new FormOda();
            formOda.Show();
        }

        private void musteribtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMusteri formMusteri = new FormMusteri();
            formMusteri.Show();
        }
    }
    }
