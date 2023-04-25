using Firebase.Auth;
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
                //MessageBox.Show("Firebase Realtime Database için istemci oluşturuldu...", "Başarılı!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception exc) 
            {
                MessageBox.Show("Mesaj:"+exc.Message, "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            Ogrenci ogr1 = new Ogrenci();
            ogr1.Ad = "Erdem";
            ogr1.Soyad = "Dalca";

            Ogrenci ogr2 = new Ogrenci();
            ogr2.Ad = "Cankat";
            ogr2.Soyad = "Çiftçi";

            await firebase_istemci.Child("ogrenciler").Child("2107231029").PutAsync(ogr1);
            await firebase_istemci.Child("ogrenciler").Child("2107231037").PutAsync(ogr2);

            //await firebase_istemci.Child("ogrenciler").Child("2107231029").Child("Ad").PutAsync<string>("Erdem");
            //await firebase_istemci.Child("ogrenciler").Child("2107231029").Child("Soyad").PutAsync<string>("Dalca");
            //await firebase_istemci.Child("ogrenciler").Child("2107231037").Child("Ad").PutAsync<string>("Cankat");
            //await firebase_istemci.Child("ogrenciler").Child("2107231037").Child("Soyad").PutAsync<string>("Çiftçi");



        }
    }
}
