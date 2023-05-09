using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUSoftware
{
    public partial class OgrenciEkleDuzenle : Form
    {
        private FirebaseClient istemci;
        private UserCredential kimlik;
        private Config ayarlar;
        private string resim_url = "";

        public OgrenciEkleDuzenle(FirebaseClient istemci, UserCredential kullanici_kimligi)
        {
            InitializeComponent();

            ayarlar = new Config();
            this.istemci = istemci;
            this.kimlik = kullanici_kimligi;
        }

        private async void ogrenciekle_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.Numara = numara_txt.Text;
                ogrenci.Ad = ad_txt.Text;
                ogrenci.Soyad = soyad_txt.Text;
                ogrenci.Resim = String.Format("profil_resimleri/{0}/profil.png", ogrenci.Numara);


                if (resim_url != "")
                {
                    FirebaseStorage depolama = new FirebaseStorage(ayarlar.FireStorageDomain,
                                         new FirebaseStorageOptions
                                         {
                                             AuthTokenAsyncFactory = () => kimlik.User.GetIdTokenAsync(),
                                             ThrowOnCancel = true,
                                         });

                    FileStream stream = File.Open(resim_url, FileMode.Open);

                    FirebaseStorageTask gonder = depolama.Child("profil_resimleri")
                                                         .Child(ogrenci.Numara)
                                                         .Child("profil.png")
                                                         .PutAsync(stream);

                    gonder.Progress.ProgressChanged += (s, evnt) => ogrenci_prbar.Value = evnt.Percentage;

                }

                await istemci.Child("ogrenciler").Child(ogrenci.Numara).PutAsync(ogrenci);
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

        private void resimsec_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog resimsec = new OpenFileDialog();
            if (resimsec.ShowDialog() == DialogResult.OK) 
            {
                FileStream stream = File.Open(resimsec.FileName, FileMode.Open);

                Image resim = (Image)Image.FromStream(stream).Clone();
                resim_pB.Image = resim;

                stream.Close();

                resim_url = resimsec.FileName;
            }
        }
    }
}
