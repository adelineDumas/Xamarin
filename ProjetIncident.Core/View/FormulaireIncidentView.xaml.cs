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
            CameraButton.Clicked += CameraButton_Clicked;
        }

        private async void CameraButton_Clicked(object sender, EventArgs e)
        {
            await Plugin.Media.CrossMedia.Current.Initialize();
            var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions()
            {
                DefaultCamera = Plugin.Media.Abstractions.CameraDevice.Rear,
                RotateImage = true,
                AllowCropping = true

            });

            if (photo != null)
                PhotoImage.Source = ImageSource.FromStream(() => { return photo.GetStream(); });
        }

    }
}
