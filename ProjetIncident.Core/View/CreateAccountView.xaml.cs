using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ProjetIncident.Core.View
{
    public partial class CreateAccountView : ContentPage
    {
        public CreateAccountView()
        {
            this.BindingContext = new ViewModel.CreateAccountViewModel(); 
            InitializeComponent();
        }
    }
}
