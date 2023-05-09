using Firebase.Auth.Providers;
using Firebase.Auth.Repository;
using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUSoftware.Controls;

namespace GUSoftware
{
    public partial class Login : Form
    {
        private string AuthDomain, ApiKey;
        private Config ayarlar;
        private CreateUserUC createUC;
        private LoginUC loginUC;
        private FirebaseAuthClient client;

        public Login(Config ayarlar)
        {
            InitializeComponent();

            this.AuthDomain = ayarlar.AuthDomain;
            this.ApiKey = ayarlar.ApiKey;
            this.ayarlar = ayarlar;

            createUC = new CreateUserUC();
            loginUC = new LoginUC();

            importloginBtn_Click(this, EventArgs.Empty);

            this.loginUC.loginBtn.Click += LoginBtn_Click;
            this.createUC.createBtn.Click += CreateBtn_Click;


            FirebaseAuthConfig config = new FirebaseAuthConfig
            {
                ApiKey = ApiKey,
                AuthDomain = AuthDomain,
                Providers = new FirebaseAuthProvider[]{ new EmailProvider()},

            };

            this.client = new FirebaseAuthClient(config);
        }

        private async void CreateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var kullanici_kimligi = await client.CreateUserWithEmailAndPasswordAsync(this.createUC.emailTxt.Text.Trim(), 
                                                                                      this.createUC.paswordTxt.Text.Trim());

                MessageBox.Show(kullanici_kimligi.User.Uid);
            }
            catch (Exception exc)
            {
                MessageBox.Show("HATA:" + exc.Message);
            }
            finally
            {

            }
        }

        private async void LoginBtn_Click(object sender, EventArgs e)
        {          
            try
            {
                loginUC.loginBtn.Enabled = false;
                loginUC.loginPb.Visible = true;

                UserCredential kullanici_kimligi = await client.SignInWithEmailAndPasswordAsync(this.loginUC.emailTxt.Text.Trim(),
                                                                                   this.loginUC.paswordTxt.Text.Trim());
               
                this.Hide();

                MainWindow nesne = new MainWindow(kullanici_kimligi);
                nesne.Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show("HATA:"+exc.Message);
                loginUC.loginBtn.Enabled = true;
                loginUC.loginPb.Visible = false;
            }
            finally 
            {
                loginUC.loginBtn.Enabled = true;
                loginUC.loginPb.Visible = false;
            }

        }

        private void importcreateBtn_Click(object sender, EventArgs e)
        {          
            panel1.Controls.Clear();
            panel1.Controls.Add(createUC);
        }

        private void importloginBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(loginUC);
        }


    }
}
