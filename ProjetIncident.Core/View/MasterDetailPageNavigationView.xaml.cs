using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ProjetIncident.Core.View
{
    public partial class MasterDetailPageNavigationView : MasterDetailPage
    {
        private static MasterDetailPageNavigationView _currentNavigation = null;
        public static MasterDetailPageNavigationView GetInstance()
        {
            if (_currentNavigation == null)
            {
                _currentNavigation = new MasterDetailPageNavigationView();
            }
            return _currentNavigation;
        }

        public void NextPage(Type pPage){
            if (pPage == typeof(ConnexionView))
            {
                Application.Current.MainPage = new ConnexionView(); 
            }
            else
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(pPage));
            }
        }

        public MasterDetailPageNavigationView()
        {
            this.BindingContext = new ViewModel.MasterDetailPageNavigationViewModel(); 
            InitializeComponent();
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(DescriptionIncidentView)));
        }

        // Event for Menu Item selection, here we are going to handle navigation based
        // on user selection in menu ListView
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (Model.MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;

            NextPage(page);
            IsPresented = false;
        }
    }
}
