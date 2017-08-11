using System;

using Xamarin.Forms;

namespace CrossPlat.Views.Tables
{
    public class ImageCellPage : ContentPage
    {
        public ImageCellPage ()
        {
            IProduct[] products = 
            {
                new IProduct("Dev Services", "Service", 
                    "Do you need a mobile app, website, or both? Count on Mooseworks Software to collaborate with you at every stage of the project lifecycle, from concept to completion to support. ",
                    "http://mooseworkssoftware.com/wordpress/wp-content/uploads/2013/11/services1.png"),
                new IProduct("Graph", "Product",
                    "The Graph Control provides every graphing feature you could want: Legends, Zooming, Date/Time, Logarithmic, Inverted axes, Right and Left Y-Axes, Markers, Cursor Values, Alarms, and more, while still providing excellent performance.", 
                    "http://mooseworkssoftware.com/wordpress/wp-content/uploads/2013/12/graphimage.png"),
                new IProduct("Instrumentation", "Product",
                    "The Instrumentation Control suite includes everything you need to create eye catching and easy to use displays.",
                    "http://mooseworkssoftware.com/wordpress/wp-content/uploads/2013/11/Screenshot1.png"),
                new IProduct("Trend Graph", "Product", 
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

            foreach (IProduct product in products)
            {
                if (product.Category == "Service")
                {
                    sectionServices.Add(new ImageCell
                        {
                            ImageSource = product.ImageUrl,
                            Text = product.Name,
                            TextColor = Color.Black,
                            Detail = product.Description,
                            DetailColor = Color.Navy
                        });
                }
                else
                {
                    sectionProducts.Add(new ImageCell
                        {
                            ImageSource = product.ImageUrl,
                            Text = product.Name,
                            TextColor = Color.Black,
                            Detail = product.Description,
                            DetailColor = Color.Navy
                        });
                }
            }
            tableProducts.Root.Add(new TableSection[]{sectionServices, sectionProducts});

            this.Padding = new Thickness(10, Device.OnPlatform(20, 10, 10), 10, 10);
            this.BackgroundColor = Color.White;

            this.Content = new StackLayout {
                Children = {
                    lblHeader,
                    tableProducts
                }
            };
        }
    }

    class IProduct
    {
        public IProduct(string Name, string Category, string Description, string ImageUrl)
        {
            this.Name = Name;
            this.Category = Category;
            this.Description = Description;
            this.ImageUrl = ImageUrl;
        }

        public string Name { private set; get; }
        public string Category { private set; get; }
        public string Description { private set; get; }
        public string ImageUrl { private set; get; }

        public override string ToString()
        {
            return Name;
        }
    }

}

