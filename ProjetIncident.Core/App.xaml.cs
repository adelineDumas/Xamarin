using ProjetIncident.Core.View;
using Xamarin.Forms;

namespace ProjetIncident.Core
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ConnexionView();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
