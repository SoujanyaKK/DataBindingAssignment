using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinSampleTwo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1()
		{
			InitializeComponent();
			//Content = new Button
			//{
			//	Text = "Start",
			//	HorizontalOptions = LayoutOptions.Center,
			//	VerticalOptions = LayoutOptions.Center,
			//};
			slider1.Value = 0.5;
		}

		private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
		{
			label1.Text = string.Format("Value is {0:f2}", e.NewValue);
		}

		private void EntryText_TextChanged(object sender, TextChangedEventArgs e)
		{
			label2.Text = e.NewTextValue;
		}

		private void slider4_ValueChanged(object sender, ValueChangedEventArgs e)
		{
			label4.FontSize = slider4.Value;
		}

	}
}