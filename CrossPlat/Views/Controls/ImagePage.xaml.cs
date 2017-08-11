using System;
using System.Collections.Generic;
using System.Reflection;
using Xamarin.Forms;

namespace CrossPlat.Views.Controls
{
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();

            //CrossPlat.fr.jpg
            var assembly = typeof(ImagePage).GetTypeInfo().Assembly;
            foreach (var res in assembly.GetManifestResourceNames())
                System.Diagnostics.Debug.WriteLine("Found resource: " + res);

            ImageSource imageSource = ImageSource.FromResource("CrossPlat.fr.jpg");
            imgEmbedded.Source = imageSource;
            imgEmbedded.Aspect = Aspect.AspectFill;
            imgEmbedded.BackgroundColor = Color.Blue;
            imgRemote.Source = "http://fanreact.com/wp-content/uploads/2017/06/ken-myers.jpg";
            imgRemote.Aspect = Aspect.AspectFit;
            imgRemote.BackgroundColor = Color.Blue;

        }
    }
}
