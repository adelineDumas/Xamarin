using System;
using System.Windows.Input;
using ProjetIncident.Core.View;
using Xamarin.Forms;

namespace ProjetIncident.Core.ViewModel
{
    public class CreateAccountViewModel
    {
        public ICommand CreateAccount { protected set; get; }
        public ICommand Retour { protected set; get; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }

        public CreateAccountViewModel()
        {
            CreateAccount = new Command(() =>
            {
                if (String.IsNullOrEmpty(Nom) || String.IsNullOrEmpty(Prenom) || String.IsNullOrEmpty(Mail) || String.IsNullOrEmpty(Password))
                {
                   //toast vide  
                }
                else {
                    Application.Current.MainPage = MasterDetailPageNavigationView.GetInstance();
                }
            });

            Retour = new Command(() =>
            {
                Application.Current.MainPage = new ConnexionView();
            });
        }
    }
}
