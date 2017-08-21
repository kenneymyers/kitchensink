using System;
using System.Collections.Generic;
using System.Linq;
using SQLite.Net;
using Xamarin.Forms;
using SQLite.Net.Attributes;
using System.Collections.ObjectModel;

namespace CrossPlat.Views.Other
{

	public class ProductsRepository
	{
		readonly DevExpress.Mobile.Core.Containers.BindingList<DProduct> products;

		public ProductsRepository(Collection<DProduct> dp)
		{
			this.products = new DevExpress.Mobile.Core.Containers.BindingList<DProduct>(dp);
		}

		public DevExpress.Mobile.Core.Containers.BindingList<DProduct> Products
		{
			get { return products; }
		}
	}

    public partial class DevExpressPage : ContentPage
    {
		private SQLiteConnection datab;
 		private Collection<DProduct> cp;
        private List<DProduct> lp;
        private DProduct[] prods;

		public DevExpressPage()
        {
            datab = DependencyService.Get<ISQLite>().GetConnection();
            InitializeComponent();
            CreateDatabase();
            DeleteRecords();
            WriteToDatabase();
            cp = GetProducts();
            ProductsRepository dp = new ProductsRepository(cp);
            this.BindingContext = dp;
        }

		private Collection<DProduct> GetProducts()
		{
			lp = datab.Table<DProduct>().Select(p => p).ToList();
            Collection<DProduct> dp = new Collection<DProduct>(lp.ToList());
            return dp;

		}

		private void CreateDatabase()
		{
			datab.CreateTable<DProduct>();
		}

		private void DeleteRecords()
		{
			datab.DeleteAll<DProduct>();
		}

		private void WriteToDatabase()
		{
			prods = new DProduct[]
			{
				new DProduct("Dev Services", "Service", true,
					"Do you need a mobile app, website, or both? Count on Mooseworks Software to collaborate with you at every stage of the project lifecycle, from concept to completion to support. ",
					"http://mooseworkssoftware.com/wordpress/wp-content/uploads/2013/11/services1.png"),
				new DProduct("Graph", "Product", true,
					"The Graph Control provides every graphing feature you could want: Legends, Zooming, Date/Time, Logarithmic, Inverted axes, Right and Left Y-Axes, Markers, Cursor Values, Alarms, and more, while still providing excellent performance.",
					"http://mooseworkssoftware.com/wordpress/wp-content/uploads/2013/12/graphimage.png"),
				new DProduct("Instrumentation", "Product", false,
					"The Instrumentation Control suite includes everything you need to create eye catching and easy to use displays.",
					"http://mooseworkssoftware.com/wordpress/wp-content/uploads/2013/11/Screenshot1.png"),
				new DProduct("Trend Graph", "Product",  true,
					"The Trend Graph Control provides real time, scrollable charting capabilities. Memory is handled by the Trend Graph’s circular buffer, so you can add points in real time without worrying about memory growing out of control as time goes on. ",
					"http://mooseworkssoftware.com/wordpress/wp-content/uploads/2013/12/TrendGraph2.png")
			};

			datab.InsertAll(prods);
		}


    }


}
