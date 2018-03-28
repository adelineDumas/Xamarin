using System;
using System.Collections.Generic;
using ProjetIncident.Core.View;
using Xamarin.Forms;

namespace ProjetIncident.Core.ViewModel
{
    public class MasterDetailPageNavigationViewModel : BaseViewModel
    {
        public List<Model.MasterPageItem> menuList { get; set; }

        public MasterDetailPageNavigationViewModel()
        {
            menuList = new List<Model.MasterPageItem>();
            menuList.Add(new Model.MasterPageItem() { Title = "Accueil", IconSource = "home.png", TargetType = typeof(DescriptionIncidentView) });
            menuList.Add(new Model.MasterPageItem() { Title = "Ajouter un incident", IconSource = "warning.png", TargetType = typeof(FormulaireIncidentView) });
            menuList.Add(new Model.MasterPageItem() { Title = "Déconnexion", IconSource = "logout.png", TargetType = typeof(ConnexionView) });

        }

    }
}
