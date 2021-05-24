using _345_Launcher.ModMarket.Firebase_Models;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Windows.Forms;

namespace _345_Launcher.ModMarket
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "s2G65KdBO86Lua5t2j9dNTq7BZ7bambB9XF9it0L",//Bakma ayıp
            BasePath = "https://launcher-8fb95-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        public IFirebaseClient client;

        public FirebaseResponse response;

        private async void login()
        {
            client = new FireSharp.FirebaseClient(config);
            response = await client.GetAsync("Users/" + guna2TextBox2.Text);
            Login user = response.ResultAs<Login>();

            try
            {

                Login CurUser = new Login() // USER GIVEN INFO
                {
                    Username = guna2TextBox2.Text,
                    Password = guna2TextBox1.Text,
                };

                if (Login.IsEqual(user, CurUser))
                {
                    Main_Form real = new Main_Form();
                    this.Hide();
                    real.Show();
                }
                else
                {
                    Login.ShowError();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

