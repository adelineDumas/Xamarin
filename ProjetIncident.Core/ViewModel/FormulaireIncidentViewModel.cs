using System;
using System.Windows.Input;
using ProjetIncident.Core.View;
using Xamarin.Forms;
using Plugin.Media;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ProjetIncident.Core.ViewModel
{
    public class FormulaireIncidentViewModel
    {
        public string Titre { get; set; }
        public string Description { get; set; }
        public Image PhotoImage { get; set; }
        public DateTime Date { get; set; }
        public ICommand Submit { protected set; get; }
        public ICommand AddPhotos { protected set; get; }

        public FormulaireIncidentViewModel()
        {
            var lViewModelDescription = new DescriptionIncidentViewModel();


            Submit = new Command(async () =>
            {
                var lDb = await DAL.IncidentDbContext.GetCurrent(); 
                if (String.IsNullOrEmpty(Titre) || String.IsNullOrEmpty(Description))
                {
                    await Application.Current.MainPage.DisplayAlert("Attention", "Veuillez remplir tous les champs", "OK");
                }
                else {
                    var lIncident = new Model.Incident(Description, Date); 
                    lDb.Add(lIncident);
                    lDb.SaveChanges(); 
                    MasterDetailPageNavigationView.GetInstance().NextPage(typeof(DescriptionIncidentView));
                }
            }); 

            /*AddPhotos = new Command(async () =>
            {
                await CrossMedia.Current.Initialize();
                var photo = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions()
                {
                    DefaultCamera = Plugin.Media.Abstractions.CameraDevice.Rear,
                    RotateImage = true,
                    AllowCropping = true

                });

                /*if (photo != null)
                {
                    this.PhotoImage.Source = ImageSource.FromStream(photo.GetStream);
                }
            }); */
            
        }
    }
}
