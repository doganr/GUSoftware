using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUSoftware
{
    public partial class OgrenciEkleDuzenle : Form
    {
        FirebaseClient istemci;

        public OgrenciEkleDuzenle(FirebaseClient istemci)
        {
            InitializeComponent();

            this.istemci = istemci;
        }

        private async void ogrenciekle_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Ogrenci yeni_ogrenci = new Ogrenci();
                yeni_ogrenci.Numara = numara_txt.Text;
                yeni_ogrenci.Ad = ad_txt.Text;
                yeni_ogrenci.Soyad = soyad_txt.Text;

                await istemci.Child("ogrenciler").Child(yeni_ogrenci.Numara).PutAsync(yeni_ogrenci);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mesaj:" + ex.Message, "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
                this.Close();
            }

        }
    }
}
