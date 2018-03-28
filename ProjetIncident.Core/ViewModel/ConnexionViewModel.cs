﻿using System;
using System.Windows.Input;
using ProjetIncident.Core.View;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace ProjetIncident.Core.ViewModel
{
    public class ConnexionViewModel
    {
        public ICommand Connexion { protected set; get; }
        public ICommand CreateAccount { protected set; get; }
        public string Mail { get; set; }
        public string Password { get; set; }


        public ConnexionViewModel()
        {
            Connexion = new Command (() =>
            {
                if (String.IsNullOrEmpty(Mail) || String.IsNullOrEmpty(Password))
                {
                    
                }
                else {

                    Application.Current.MainPage = MasterDetailPageNavigationView.GetInstance();
                }
             });

            CreateAccount = new Command(() =>
            {
                Application.Current.MainPage = new CreateAccountView(); 
            }); 
        }
    }
}
