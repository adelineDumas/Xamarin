using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ProjetIncident.Core.View
{
    public partial class FormulaireIncidentView : ContentPage
    {
        public FormulaireIncidentView()
        {
            this.BindingContext = new ViewModel.FormulaireIncidentViewModel(); 
            InitializeComponent();
        }

    }
}
