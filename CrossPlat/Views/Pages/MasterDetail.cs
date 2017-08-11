using System;

using Xamarin.Forms;

namespace CrossPlat.Views.Pages
{
    public class MasterDetail : MasterDetailPage
    {
        public MasterDetail ()
        {
            Label header = new Label
            {
                Text = "MasterDetailPage",
                Font = Font.SystemFontOfSize(NamedSize.Large, FontAttributes.Bold),
                HorizontalOptions = LayoutOptions.Center
            };

            // Assemble an array of NamedColor objects.
            Product[] products = 
            {
                new Product("Dev Services", 
                    "Do you need a mobile app, website, or both? Count on Mooseworks Software to collaborate with you at every stage of the project lifecycle, from concept to completion to support. ",
                    "http://mooseworkssoftware.com/wordpress/wp-content/uploads/2013/11/services1.png"),
                new Product("Graph", 
                    "The Graph Control provides every graphing feature you could want: Legends, Zooming, Date/Time, Logarithmic, Inverted axes, Right and Left Y-Axes, Markers, Cursor Values, Alarms, and more, while still providing excellent performance.", 
                    "http://mooseworkssoftware.com/wordpress/wp-content/uploads/2013/12/graphimage.png"),
                new Product("Instrumentation", 
                    "The Instrumentation Control suite includes everything you need to create eye catching and easy to use displays.",
                    "http://mooseworkssoftware.com/wordpress/wp-content/uploads/2013/11/Screenshot1.png"),
                new Product("Trend Graph", 
                    "The Trend Graph Control provides real time, scrollable charting capabilities. Memory is handled by the Trend Graph’s circular buffer, so you can add points in real time without worrying about memory growing out of control as time goes on. ", 
                    "http://mooseworkssoftware.com/wordpress/wp-content/uploads/2013/12/TrendGraph2.png")
            };

            // Create ListView for the master page.
            ListView listView = new ListView
            {
                ItemsSource = products
            };

            // Create the master page with the ListView.
            this.Master = new ContentPage
            {
                Padding = new Thickness(10, Device.OnPlatform(40, 10, 10), 10, 10),
                Title = "Master Page",
                Content = new StackLayout
                {
                    Children = 
                    {
                        header, 
                        listView
                    }
                }
            };
            this.BackgroundColor = Color.White;

            // Create the detail page
            ProductDetailPage detailPage = new ProductDetailPage();
            this.Detail = detailPage;

            // For Android & Windows Phone, provide a way to get back to the master page.
            if (Device.OS != TargetPlatform.iOS)
            {
                TapGestureRecognizer tap = new TapGestureRecognizer();
                tap.Tapped += (sender, args) =>
                {
                    this.IsPresented = true;
                };

                detailPage.Content.BackgroundColor = Color.Transparent;
                detailPage.Content.GestureRecognizers.Add(tap);
            }

            listView.ItemSelected += (sender, args) =>
            {
                // Set the BindingContext of the detail page.
                this.Detail.BindingContext = args.SelectedItem;

                // Show the detail page.
                this.IsPresented = false;
            };

            listView.SelectedItem = products[0];
        }   
    }

    class Product
    {
        public Product(string Name, string Description, string ImageUrl)
        {
            this.Name = Name;
            this.Description = Description;
            this.ImageUrl = ImageUrl;
        }

        public string Name { private set; get; }
        public string Description { private set; get; }
        public string ImageUrl { private set; get; }

        public override string ToString()
        {
            return Name;
        }
    }
}

