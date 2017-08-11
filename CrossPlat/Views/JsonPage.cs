using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CrossPlat.Views
{

	public class ContactsResult
	{
		public List<Contact> GetContactsResult { get; set; }
	}

	public class Contact
	{
		public Contact()
		{
		}

		public int ID { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public string DisplayName { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public string Title { get; set; }
		public string Picture { get; set; }

	}

	public class JsonPage : ContentPage
	{
		private TableView tblContacts;

		public JsonPage()
		{
			Label lblHeader = new Label
			{
				Text = "JSON",
				Font = Font.SystemFontOfSize(NamedSize.Large, FontAttributes.Bold),
				HorizontalOptions = LayoutOptions.Center
			};

			tblContacts = new TableView
			{
				Intent = TableIntent.Data,
				Root = new TableRoot("Contacts")
			};

			Button btnReadContacts = new Button
			{
				Text = "Read Contacts"
			};
			btnReadContacts.Clicked += (object sender, EventArgs e) => ReadContacts();

			this.Padding = new Thickness(10, Device.OnPlatform(20, 10, 10), 10, 10);
			this.BackgroundColor = Color.White;

			this.Content = new StackLayout
			{
				Children = {
					lblHeader,
					btnReadContacts,
					tblContacts
				}
			};

		}

		private async void ReadContacts()
		{
			var client = new System.Net.Http.HttpClient();
			client.BaseAddress = new Uri("https://www.changeofaddressform.com/jsontest.php");
			var response = await client.GetAsync("");
			string jsonString = response.Content.ReadAsStringAsync().Result;

			// for debug only
			// jsonString = "{\"GetContactsResult\":[{\"DisplayName\":\"Keith Welch\",\"FirstName\":\"Keith\",\"ID\":1,\"LastName\":\"Welch\",\"MiddleName\":null,\"Password\":\"moose\",\"Picture\":\"KeithWelch.jpg\",\"Title\":null,\"UserName\":\"keith\"},{\"DisplayName\":\"Jane Doe\",\"FirstName\":\"Jane\",\"ID\":1,\"LastName\":\"Doe\",\"MiddleName\":null,\"Password\":\"jd\",\"Picture\":null,\"Title\":null,\"UserName\":\"jd\"}]}";

			ContactsResult result = Newtonsoft.Json.JsonConvert.DeserializeObject<ContactsResult>(jsonString);
			List<Contact> contacts = result.GetContactsResult;

			TableSection section = new TableSection("Contacts");

			foreach (Contact contact in contacts)
			{
				section.Add(new TextCell
				{
					Text = contact.DisplayName,
					TextColor = Color.Black,
					Detail = contact.UserName,
					DetailColor = Color.Navy
				});
			}
			tblContacts.Root.Add(new TableSection[] { section });
		}

	}
}

