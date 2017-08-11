using System;

using Xamarin.Forms;

namespace CrossPlat.Views.Tables
{
    public class EntryCellPage : ContentPage
    {
        private EProduct[] products;

        public EntryCellPage ()
        {
            products = new EProduct[]
            {
                new EProduct("Dev Services", "Service", 
                    "Do you need a mobile app, website, or both? Count on Mooseworks Software to collaborate with you at every stage of the project lifecycle, from concept to completion to support. ",
                    "http://mooseworkssoftware.com/wordpress/wp-content/uploads/2013/11/services1.png"),
                new EProduct("Graph", "Product",
                    "The Graph Control provides every graphing feature you could want: Legends, Zooming, Date/Time, Logarithmic, Inverted axes, Right and Left Y-Axes, Markers, Cursor Values, Alarms, and more, while still providing excellent performance.", 
                    "http://mooseworkssoftware.com/wordpress/wp-content/uploads/2013/12/graphimage.png"),
                new EProduct("Instrumentation", "Product",
                    "The Instrumentation Control suite includes everything you need to create eye catching and easy to use displays.",
                    "http://mooseworkssoftware.com/wordpress/wp-content/uploads/2013/11/Screenshot1.png"),
                new EProduct("Trend Graph", "Product", 
                    "The Trend Graph Control provides real time, scrollable charting capabilities. Memory is handled by the Trend Graph’s circular buffer, so you can add points in real time without worrying about memory growing out of control as time goes on. ", 
                    "http://mooseworkssoftware.com/wordpress/wp-content/uploads/2013/12/TrendGraph2.png")
            };
                
            Label lblHeader = new Label
            {
                Text = "Table View",
                Font = Font.SystemFontOfSize(NamedSize.Large, FontAttributes.Bold),
                HorizontalOptions = LayoutOptions.Center
            };

            TableView tableProducts = new TableView {
                Intent = TableIntent.Data,
                Root = new TableRoot ("Products and Services")
            };

            TableSection sectionServices = new TableSection("Services");
            TableSection sectionProducts = new TableSection("Products");

            foreach (EProduct product in products)
            {
                EntryCell ec = new EntryCell ();
                ec.BindingContext = product;
                ec.Label = "Product Name";
                ec.SetBinding (EntryCell.TextProperty, "Name", BindingMode.TwoWay);
                if (product.Category == "Service")
                {
                    sectionServices.Add(ec);
                }
                else
                {
                    sectionProducts.Add(ec);
                }
            }
            tableProducts.Root.Add(new TableSection[]{sectionServices, sectionProducts});

            Button btnSubmit = new Button {
                Text = "Submit",
                HorizontalOptions = LayoutOptions.Center
            };
            btnSubmit.Clicked += (object sender, EventArgs e) => {
                string message = "";
                foreach (EProduct product in products)
                {
                    message += product.Name + ", ";
                }
                DisplayAlert("Products", message, "OK");
            };

            this.Padding = new Thickness(10, Device.OnPlatform(20, 10, 10), 10, 10);

            this.Content = new StackLayout {
                Children = {
                    lblHeader,
                    tableProducts,
                    btnSubmit
                }
            };
        }
    }

    class EProduct
    {
        public EProduct(string Name, string Category, string Description, string ImageUrl)
        {
            this.Name = Name;
            this.Category = Category;
            this.Description = Description;
            this.ImageUrl = ImageUrl;
        }

        public string Name { set; get; }
        public string Category { set; get; }
        public string Description { set; get; }
        public string ImageUrl { set; get; }

        public override string ToString()
        {
            return Name;
        }
    }

}

