using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _345_Launcher.ModMarket.Firebase_Models
{
    class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }

        private static string error = "Kullanıcı adı geçersiz!";

        public static void ShowError()
        {
            System.Windows.Forms.MessageBox.Show(error);
        }
        public static bool IsEqual(Login user1, Login user2)
        {
            if (user1 == null || user2 == null) { return false; }

            if (user1.Username != user2.Username)
            {
                error = "Kullanıcı adı geçersiz!";
                return false;
            }

            else if (user1.Password != user2.Password)
            {
                error = "Kullanıcı adı ve şifre uyuşmuyor.";
                return false;
            }

            return true;
        }
    }
}
