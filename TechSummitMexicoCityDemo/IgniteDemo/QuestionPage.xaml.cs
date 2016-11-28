using System;
using System.Collections.Generic;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;

using Xamarin.Forms;

namespace IgniteDemo
{
	public partial class QuestionPage : ContentPage
	{
		
		public QuestionPage()
		{
			InitializeComponent();


		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			var answers = new List<Answer>();
			answers.Add(new Answer() { Name = "Chapultepec", PhotoResource="IgniteDemo.Images.PlacesOfInterest.Chapultepec.jpg" });
			answers.Add(new Answer() { Name = "National Museum of Anthropology", PhotoResource = "IgniteDemo.Images.PlacesOfInterest.AnthroplolgyMuseum.jpg" });
			answers.Add(new Answer() { Name = "Historic Center of Mexico City", PhotoResource = "IgniteDemo.Images.PlacesOfInterest.HistoricCenter.jpg" });
			answers.Add(new Answer() { Name = "Zocalo", PhotoResource = "IgniteDemo.Images.PlacesOfInterest.Zocalo.jpg" });
			answers.Add(new Answer() { Name = "Palacio de Bellas Artes", PhotoResource = "IgniteDemo.Images.PlacesOfInterest.Palacio.jpg" });
			answers.Add(new Answer() { Name = "Frida Kahlo Museum", PhotoResource = "IgniteDemo.Images.PlacesOfInterest.FridaKahloMuseum.jpg" });
			answers.Add(new Answer() { Name = "Great Pryamid of Tenochtitlan", PhotoResource = "IgniteDemo.Images.PlacesOfInterest.GreatPyramid.jpg" });
			answers.Add(new Answer() { Name = "Metropolitan Cathedral", PhotoResource = "IgniteDemo.Images.PlacesOfInterest.MetropolitanCathedral.jpg" });
			listView.ItemsSource = answers;

			btnCancel.Clicked += async (sender, e) =>
		   {
			   await Navigation.PopAsync();
		   };
			btnNext.Clicked += async (sender, e) =>
			{
				string eventName = "Attractions: ";
				Answer item = (Answer) listView.SelectedItem;
				eventName += item.Name;
				//HockeyApp.MetricsManager.TrackEvent(eventName);

				if (item.Name != "Great Pryamid of Tenochtitlan" && item.Name != "Historic Center of Mexico City")
				{
					MexicoCityAttractions();
				}

				await Navigation.PopAsync();
			};
		}

		protected void MexicoCityAttractions()
		{
			throw new Exception("No details on Mexico City attraction");
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			DependencyService.Get<IHockeyAppHelpers>()?.SendFeedback();
		}
	}
}
