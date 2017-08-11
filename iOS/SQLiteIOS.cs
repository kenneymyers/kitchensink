using System;
using CrossPlat.Views;
using Xamarin.Forms;
using CrossPlat.iOS;
using System.IO;
using SQLite.Net;
using SQLite.Net.Attributes;
using SQLite.Net.Platform;

[assembly: Dependency (typeof (SQLiteIOS))]

/* SLITE.NET Extensions PCL MUST BE INSTALLED as well as the ASYNC PCL */
namespace CrossPlat.iOS
{

    public class SQLiteIOS : ISQLite
    {
        public SQLiteIOS ()
        {
        }

        public SQLite.Net.SQLiteConnection GetConnection ()
        {
			var fileName = "sqlite.sqlite";
			var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var libraryPath = Path.Combine(documentsPath, "..", "Library");
			var path = Path.Combine(libraryPath, fileName);

			var platform = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
			var connection = new SQLite.Net.SQLiteConnection(platform, path);

			return connection;

        }
    }
}
