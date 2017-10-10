using Xamarin.Forms;

namespace App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            
        }

        private async void Triangle(object sender, System.EventArgs e)
        {
             await Navigation.PushAsync(new Triangle());
        }

        private async void Square(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Square());
        }

        private async void Pentagon(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Pentagon());
        }
    }
}
