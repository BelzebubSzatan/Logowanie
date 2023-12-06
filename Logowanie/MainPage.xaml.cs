using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Logowanie
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }

    public partial class MainPage : ContentPage
    {
        private List<User> users = new List<User>()
        {
            new User() {Login = "Admin", Password = "AdminPassword"},
            new User() {Login = "User1", Password = "User1Password"}
        };

        public MainPage()
        {
            InitializeComponent();
        }

        public void LoginClick(object sender, EventArgs args)
        {
            if (string.IsNullOrEmpty(Login.Text) || string.IsNullOrEmpty(Password.Text))
                return;
            if(users.Any(e => e.Login == Login.Text && e.Password == Password.Text))
            {
                DisplayAlert("Logowanie", "Pomyślnie zalogowano", "OK");
            }
            else
            {
                DisplayAlert("Logowanie", "Niepoprawne dane logowania", "OK");
            }
        }
    }
}
