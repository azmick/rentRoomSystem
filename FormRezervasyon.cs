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
    public partial class FormRezervasyon : Form
    {
        public FormRezervasyon()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432;Database=dbOtel2;userid=postgres;password=125678943aS");
        private void eklebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into rezervasyonlar (rezid,musteriid,odaid) values (@p1,@p2,@p3)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(rezidtxt.Text));
            komut1.Parameters.AddWithValue("@p2", int.Parse(musteriidtxt.Text));
            komut1.Parameters.AddWithValue("@p3", int.Parse(odaidtxt.Text));
            komut1.ExecuteNonQuery(); //degisiklikleri veritabanına yansitiyoruz.
            baglanti.Close();
            MessageBox.Show("Rezervasyon kaydınız başarılı bir şekilde gercekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void arabtn_Click(object sender, EventArgs e)
        {

        }
    }
}
