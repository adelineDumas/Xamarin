using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using ProjetIncident.Core.View;
using Xamarin.Forms;

namespace ProjetIncident.Core.ViewModel
{
    public class DescriptionIncidentViewModel : BaseViewModel
    {
        public string Titre { get; set; }
        public string Description { get; set; }
        public ICommand Submit { protected set; get; }
        public ICommand Add { protected set; get; }


        public ObservableCollection<DTO.DescriptionIncident> ListeDescriptionIncident
        {
            get => GetProperty<ObservableCollection<DTO.DescriptionIncident>>();
            set { SetProperty(value); }
        }

        public DescriptionIncidentViewModel()
        {
            ListeDescriptionIncident = new ObservableCollection<DTO.DescriptionIncident>();
            ListeDescriptionIncident.Add(new DTO.DescriptionIncident("Dégradation de banc", "Avenue Maginot, un banc a été abimé. RIP"));
            ListeDescriptionIncident.Add(new DTO.DescriptionIncident("Dégats", "Suite à l'ouragan qui est passé hier à Bourg en Bresse, tout est abimé."));

            Submit = new Command (() =>
            {
                ListeDescriptionIncident.Add(new DTO.DescriptionIncident(Titre, Description));
                MasterDetailPageNavigationView.GetInstance().NextPage(typeof(DescriptionIncidentView)); 
             }); 

            Add = new Command (() =>
            {
                MasterDetailPageNavigationView.GetInstance().NextPage(typeof(FormulaireIncidentView)); 
               
             }); 
        }

    }
}
