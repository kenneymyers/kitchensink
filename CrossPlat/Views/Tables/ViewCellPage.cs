using System;

using Xamarin.Forms;

namespace CrossPlat.Views.Tables
{
    public class ViewCellPage : ContentPage
    {
        private VProduct[] products;

        public ViewCellPage ()
        {
            products = new VProduct[]
            {
                new VProduct("Dev Services", "Service", true,
                    "Do you need a mobile app, website, or both? Count on Mooseworks Software to collaborate with you at every stage of the project lifecycle, from concept to completion to support. ",
                    "http://mooseworkssoftware.com/wordpress/wp-content/uploads/2013/11/services1.png"),
                new VProduct("Graph", "Product", true,
                    "The Graph Control provides every graphing feature you could want: Legends, Zooming, Date/Time, Logarithmic, Inverted axes, Right and Left Y-Axes, Markers, Cursor Values, Alarms, and more, while still providing excellent performance.", 
                    "http://mooseworkssoftware.com/wordpress/wp-content/uploads/2013/12/graphimage.png"),
                new VProduct("Instrumentation", "Product", false,
                    "The Instrumentation Control suite includes everything you need to create eye catching and easy to use displays.",
                    "http://mooseworkssoftware.com/wordpress/wp-content/uploads/2013/11/Screenshot1.png"),
                new VProduct("Trend Graph", "Product",  true,
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
                Root = new TableRoot ("Products and Services"),
                RowHeight = 135
            };

            TableSection sectionServices = new TableSection("Services");
            TableSection sectionProducts = new TableSection("Products");

            foreach (VProduct product in products)
            {
                Entry txtName = new Entry ();
                txtName.BindingContext = product;
                txtName.SetBinding (Entry.TextProperty, "Name", BindingMode.TwoWay);

                Switch swInStock = new Switch ();
                swInStock.BindingContext = product;
                swInStock.SetBinding (Switch.IsToggledProperty, "InStock", BindingMode.TwoWay);
                swInStock.HorizontalOptions = LayoutOptions.StartAndExpand;

                Image imgProduct = new Image ();
                imgProduct.Source = product.ImageUrl;
                imgProduct.HeightRequest = 125;

                ViewCell vc = new ViewCell () {
                    View = new StackLayout {
                        Orientation = StackOrientation.Horizontal,
                        HorizontalOptions = LayoutOptions.StartAndExpand,
                        Children = {
                            imgProduct,
                            new StackLayout {
                                HorizontalOptions = LayoutOptions.EndAndExpand,
                                Children = {
                                    txtName,
                                    new Label {
                                        Text = "In Stock?",
                                        Font = Font.SystemFontOfSize(NamedSize.Large)
                                    },
                                    swInStock
                                }
                            }
                        }
                    }
                };

                if (product.Category == "Service")
                {
                    sectionServices.Add(vc);
                }
                else
                {
                    sectionProducts.Add(vc);
                }
            }
            tableProducts.Root.Add(new TableSection[]{sectionServices, sectionProducts});

            Button btnSubmit = new Button {
                Text = "Submit",
                HorizontalOptions = LayoutOptions.Center
            };
            btnSubmit.Clicked += (object sender, EventArgs e) => {
                string message = "";
                foreach (VProduct product in products)
                {
                    message += product.Name + (product.InStock ? " - in stock" : " - out of stock") + ", ";
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

    class VProduct
    {
        public VProduct(string Name, string Category, bool InStock, string Description, string ImageUrl)
        {
            this.Name = Name;
            this.Category = Category;
            this.Description = Description;
            this.ImageUrl = ImageUrl;
            this.InStock = InStock;
        }

        public string Name { set; get; }
        public string Category { set; get; }
        public string Description { set; get; }
        public string ImageUrl { set; get; }
        public bool InStock { set; get; }

        public override string ToString()
        {
            return Name;
        }
    }

}

