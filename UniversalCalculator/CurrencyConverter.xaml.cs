using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class Currency : Page
	{
		public Currency()
		{
			this.InitializeComponent();
		}

		private void exitButton_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Exit();
		}

		private void calcButton_Click(object sender, RoutedEventArgs e)
		{

			// Get the input amount and selected currencies
			double amount = Convert.ToDouble(amountTextBox.Text);
			string fromCurrency = ((ComboBoxItem)currencyFrom.SelectedItem).Content.ToString();
			string toCurrency = ((ComboBoxItem)currencyTo.SelectedItem).Content.ToString();

			// Conversion rates
			double usdToEuro = 0.85189982;
			double usdToGBP = 0.72872436;
			double usdToINR = 74.257327;
			double euroToUSD = 1.1739732;
			double euroToGBP = 0.8556672;
			double euroToINR = 87.00755;
			double gbpToUSD = 1.371907;
			double gbpToEuro = 1.1686692;
			double gbpToINR = 101.68635;
			double inrToUSD = 0.011492628;
			double inrToEuro = 0.013492774;
			double inrToGBP = 0.0098339397;

			// Perform the conversion
			double result = 0;
			switch (fromCurrency)
			{
				case "USD - US Dollar":
					switch (toCurrency)
					{
						case "EUR - Euro":
							result = amount * usdToEuro;
							break;
						case "GBP - British Pound":
							result = amount * usdToGBP;
							break;
						case "INR - Indian Rupee":
							result = amount * usdToINR;
							break;
					}
					break;
				case "EUR - Euro":
					switch (toCurrency)
					{
						case "USD - US Dollar":
							result = amount * euroToUSD;
							break;
						case "GBP - British Pound":
							result = amount * euroToGBP;
							break;
						case "INR - Indian Rupee":
							result = amount * euroToINR;
							break;
					}
					break;
				case "GBP - British Pound":
					switch (toCurrency)
					{
						case "USD - US Dollar":
							result = amount * gbpToUSD;
							break;
						case "EUR - Euro":
							result = amount * gbpToEuro;
							break;
						case "INR - Indian Rupee":
							result = amount * gbpToINR;
							break;
					}
					break;
				case "INR - Indian Rupee":
					switch (toCurrency)
					{
						case "USD - US Dollar":
							result = amount * inrToUSD;
							break;
						case "EUR - Euro":
							result = amount * inrToEuro;
							break;
						case "GBP - British Pound":
							result = amount * inrToGBP;
							break;
					}
					break;
			}

			// Display the result
			displayTextBlock.Text = $"Converted {amount} from {fromCurrency} to {toCurrency}:";
			resultTextBlock.Text = $"{result} {toCurrency}";

		}
	}



}
