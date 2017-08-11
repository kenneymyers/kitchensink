using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CrossPlat.Views.ComplexControls
{
    public class Product
    {
        public Product(int ProductID, string Description, bool InStock)
        {
            this.ProductID = ProductID;
            this.Description = Description;
            this.InStock = InStock;
        }

        public int ProductID { private set; get; }

        public string Description { private set; get; }

        public bool InStock { private set; get; }

        public string InStockString { get { return InStock ? "In Stock" : "Not Available"; } }
    }

    public class ListViewOptionsPage : ContentPage
    {
        private List<Product> products;

        public ListViewOptionsPage ()
        {
            Label lblHeader = new Label
            {
                Text = "ListView",
                Font = Font.SystemFontOfSize(NamedSize.Large, FontAttributes.Bold),
                HorizontalOptions = LayoutOptions.Center
            };

            products = GetProducts ();

            ListView listView = new ListView {
                ItemsSource = products,
                HasUnevenRows = true,

                ItemTemplate = new DataTemplate (() => {
                    Label lblID = new Label ();
                    lblID.SetBinding (Label.TextProperty, new Binding("ProductID", BindingMode.OneWay, 
                        null, null, "{0:d}"));

                    Label lblDescription = new Label ();
                    lblDescription.SetBinding (Label.TextProperty, "Description");

                    Label lblInStock = new Label ();
                    lblInStock.SetBinding (Label.TextProperty, "InStockString");

                    Switch swInStock = new Switch ();
                    swInStock.SetBinding (Switch.IsToggledProperty, "InStock");

                    return new ViewCell {
                        Height = 100,
                        View = new StackLayout {
                            Orientation = StackOrientation.Horizontal,
                            HorizontalOptions = LayoutOptions.StartAndExpand,
                            Children = {
                                new StackLayout {
                                    VerticalOptions = LayoutOptions.Center,
                                    Spacing = 0,
                                    Children = {
                                        lblID,
                                        swInStock
                                    }
                                },
                                new StackLayout {
                                    VerticalOptions = LayoutOptions.Center,
                                    Spacing = 4,
                                    Children = {
                                        lblDescription,
                                        lblInStock
                                    }
                                }
                            }
                        }
                    };
                })
            };
            listView.ItemTapped += (object sender, ItemTappedEventArgs e) => {
                if (e.Item != null) {
                    DisplayAlert ("Item Selected", ((Product)e.Item).Description, "OK", "");
                    //listView.SelectedItem = null;
                }
            };

            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 10, 10), 10, 10);

            // Build the page.
            this.Content = new StackLayout {
                Children = {
                    lblHeader,
                    listView
                }
            };

        }

        private List<Product> GetProducts()
        {
            return new List<Product> {
                new Product (1, "iPad", true),
                new Product (2, "iPad Mini", true),
                new Product (3, "iPhone 6", false),
                new Product (4, "iPhone 6 Plus", false),
                new Product (5, "Galaxy 5", true),
                new Product (6, "Galaxy Note", false)
            };
        }
    }
}

