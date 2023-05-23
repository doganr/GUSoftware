using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Storage;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUSoftware
{
    public partial class MainWindow : Form
    {
        private UserCredential kullanici_kimligi;
        private FirebaseClient firebase_istemci;
        FirebaseStorage firebase_depolama;
        private Config ayarlar;
        private int secili_id = -1;

        public MainWindow(UserCredential kullanici_kimligi)
        {
            InitializeComponent();
            ayarlar = new Config();

            this.kullanici_kimligi = kullanici_kimligi;
            this.Text = this.Text + " | Kullanıcı: " + kullanici_kimligi.User.Info.Email;

            try
            {
                firebase_istemci = new FirebaseClient(ayarlar.FireBaseDomain,
                                                    new FirebaseOptions
                                                    {
                                                        AuthTokenAsyncFactory = () => kullanici_kimligi.User.GetIdTokenAsync()
                                                    });

                firebase_depolama = new FirebaseStorage(ayarlar.FireStorageDomain,
                                         new FirebaseStorageOptions
                                         {
                                             AuthTokenAsyncFactory = () => kullanici_kimligi.User.GetIdTokenAsync(),
                                             ThrowOnCancel = true,
                                         });
                ogrenci_listele();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Mesaj:" + exc.Message, "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void ogrenci_ekle_Click(object sender, EventArgs e)
        {
            OgrenciEkleDuzenle oekle = new OgrenciEkleDuzenle(firebase_istemci, kullanici_kimligi);
            oekle.ShowDialog();

            ogrenci_listele();
        }

        private async void ogrenci_listele()
        {
            status_lbl.Text = "Öğrenci listesi sunucudan çekiliyor...";
            status_pb.Visible = true;

            IReadOnlyCollection<FirebaseObject<Ogrenci>> ogrenciler = await firebase_istemci.Child("ogrenciler").OrderByKey().OnceAsync<Ogrenci>();

            DataTable ogrenciler_table = new DataTable();
            ogrenciler_table.Columns.Add("Numara", typeof(string));
            ogrenciler_table.Columns.Add("Ad", typeof(string));
            ogrenciler_table.Columns.Add("Soyad", typeof(string));


            foreach (FirebaseObject<Ogrenci> ogrenci in ogrenciler)
            {
                ogrenciler_table.Rows.Add(ogrenci.Key, ogrenci.Object.Ad, ogrenci.Object.Soyad);
            }

            ogrenciler_dgw.DataSource = ogrenciler_table;

            status_lbl.Text = "";
            status_pb.Visible = false;
        }

        private void datagrid_cms_Opening(object sender, CancelEventArgs e)
        {
            int x = datagrid_cms.Bounds.Location.X - this.Location.X - ogrenciler_dgw.Location.X - 8;
            int y = datagrid_cms.Bounds.Location.Y - this.Location.Y - ogrenciler_dgw.Location.Y - 32;

            secili_id = ogrenciler_dgw.HitTest(x, y).RowIndex;

            ogrenciler_dgw.ClearSelection();
            ogrenciler_dgw.Rows[secili_id].Selected = true;

        }

        private async void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status_pb.Visible = true;

            if (secili_id != -1)
            {
                int selected = secili_id;

                string numara = ogrenciler_dgw.Rows[selected].Cells["Numara"].Value.ToString();
                string ad = ogrenciler_dgw.Rows[selected].Cells["Ad"].Value.ToString();
                string soyad = ogrenciler_dgw.Rows[selected].Cells["Soyad"].Value.ToString();


                OgrenciEkleDuzenle oekle = new OgrenciEkleDuzenle(firebase_istemci, kullanici_kimligi);
                oekle.Text = "Öğrenci Bilgilerini Güncelle";
                oekle.numara_txt.Text = numara;
                oekle.ad_txt.Text = ad;
                oekle.soyad_txt.Text = soyad;
                oekle.ogrenciekle_btn.Text = "Güncelle";

                try
                {
                    string resim_url = await firebase_depolama.Child("profil_resimleri")
                                                              .Child(numara)
                                                              .Child("profil.png").GetDownloadUrlAsync();

                    WebClient istemci = new WebClient();
                    Stream raw_dosya = istemci.OpenRead(resim_url);
                    Bitmap resim = new Bitmap(raw_dosya);

                    oekle.resim_pB.Image = resim;

                    raw_dosya.Flush();
                    raw_dosya.Close();
                    istemci.Dispose();

                }
                catch (Exception ex) { }


                status_pb.Visible = false;
                oekle.ShowDialog();

                ogrenci_listele();
            }

            status_pb.Visible = false;
        }

        private async void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status_pb.Visible = true;
            if (secili_id != -1)
            {
                int selected = secili_id;

                string numara = ogrenciler_dgw.Rows[selected].Cells["Numara"].Value.ToString();
                string ad = ogrenciler_dgw.Rows[selected].Cells["Ad"].Value.ToString();
                string soyad = ogrenciler_dgw.Rows[selected].Cells["Soyad"].Value.ToString();

                string mesaj = String.Format("{0} numaralı {1} {2} isimli kişiyi silmek üzeresiniz. Silme işlemini onaylıyormusunuz?",numara, ad, soyad);

                if(MessageBox.Show(mesaj,"DİKKAT!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes) 
                {
                    //öğrencinin resmi siliniyor
                    try
                    {
                        string resim_url = await firebase_depolama.Child("profil_resimleri")
                                                                  .Child(numara)
                                                                  .Child("profil.png").GetDownloadUrlAsync();

                        await firebase_depolama.Child("profil_resimleri")
                                               .Child(numara)
                                               .Child("profil.png").DeleteAsync();
                    }
                    catch (Exception ex) { }


                    //öğrencinin bilgileri siliniyor
                    await firebase_istemci.Child("ogrenciler").Child(numara).DeleteAsync();

                    string mesaj2 = String.Format("{0} numaralı {1} {2} isimli kişi sistemden silinmiştir.", numara, ad, soyad);

                    ogrenci_listele();
                    status_pb.Visible = false;

                    MessageBox.Show(mesaj2, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show("Silme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            status_pb.Visible = false;
        }
    }
}
