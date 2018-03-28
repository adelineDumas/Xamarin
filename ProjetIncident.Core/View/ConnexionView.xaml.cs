using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ProjetIncident.Core.View
{
    public partial class ConnexionView : ContentPage
    {
        public ConnexionView()
        {
            this.BindingContext = new ViewModel.ConnexionViewModel(); 
            InitializeComponent();
        }
    }
}
