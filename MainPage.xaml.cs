using System.Threading.Tasks;

namespace MauiApp3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void ShowPassword(object sender, CheckedChangedEventArgs e)
        {
            // e.Value = true if checked, false if unchecked
            txtPassword.IsPassword = !e.Value;

        }



        private async void btnLogIn_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                await DisplayAlert("Error", "Please enter both username and password.", "OK");
                return;
            }

            if (txtUsername.Text == "admin" && txtPassword.Text == "123")
            {
                await DisplayAlert("Success", "Login successful!", "OK");

                // Navigate to HomePage
                await Navigation.PushAsync(new HomePage());
            }
            else
            {
                await DisplayAlert("Error", "Invalid username or password.", "OK");
            }
        }

    }
}
