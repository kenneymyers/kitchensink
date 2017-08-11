using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CrossPlat.Views.Pages
{
    public partial class ProductDetailPage : ContentPage
    {   
        public ProductDetailPage ()
        {
            InitializeComponent ();

            lblName.SetBinding(Label.TextProperty, "Name");
            imgProduct.SetBinding(Image.SourceProperty, "ImageUrl");
            lblDescription.SetBinding(Label.TextProperty, "Description");

        }
    }
}
