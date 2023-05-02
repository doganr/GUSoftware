using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUSoftware
{
    public partial class MainWindow : Form
    {
        private UserCredential kullanici_kimligi;
        private FirebaseClient firebase_istemci;

        public MainWindow(UserCredential kullanici_kimligi)
        {
            InitializeComponent();
            this.kullanici_kimligi = kullanici_kimligi;
            this.Text = this.Text + " | Kullanıcı: " + kullanici_kimligi.User.Info.Email;

            try
            {
                firebase_istemci = new FirebaseClient("https://gusoftware-doganr-default-rtdb.firebaseio.com/",
                                                    new FirebaseOptions
                                                    {
                                                        AuthTokenAsyncFactory = () => kullanici_kimligi.User.GetIdTokenAsync()
                                                    });
                ogrenci_listele();
            } catch (Exception exc) 
            {
                MessageBox.Show("Mesaj:"+exc.Message, "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void ogrenci_ekle_Click(object sender, EventArgs e)
        {
            OgrenciEkleDuzenle oekle = new OgrenciEkleDuzenle(firebase_istemci);
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

        private void ogrenciler_dgw_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selected = e.RowIndex;

            OgrenciEkleDuzenle oekle = new OgrenciEkleDuzenle(firebase_istemci);
            oekle.Text = "Öğrenci Bilgilerini Güncelle";
            oekle.numara_txt.Text = ogrenciler_dgw.Rows[selected].Cells["Numara"].Value.ToString();
            oekle.ad_txt.Text = ogrenciler_dgw.Rows[selected].Cells["Ad"].Value.ToString();
            oekle.soyad_txt.Text = ogrenciler_dgw.Rows[selected].Cells["Soyad"].Value.ToString();
            oekle.ogrenciekle_btn.Text = "Güncelle";
            oekle.ShowDialog();

            ogrenci_listele();
        }
    }
}
