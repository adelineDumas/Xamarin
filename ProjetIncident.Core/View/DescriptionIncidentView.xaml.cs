using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ProjetIncident.Core.View
{
    public partial class DescriptionIncidentView : ContentPage
    {
        public DescriptionIncidentView()
        {
            this.BindingContext = new ViewModel.DescriptionIncidentViewModel(); 
            InitializeComponent();
        }
    }
}
