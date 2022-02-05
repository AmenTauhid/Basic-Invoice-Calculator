using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace W2A_InvoiceCalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //string name = "Ayman";
            //decimal tax = 13;
            //Decimal.Parse(subtotal.Text) 
            //result.Text = $"{Decimal.Parse(subtotal.Text) + Decimal.Parse(tips.Text) + Decimal.Parse(subtotal.Text) * (13 / 100)}";
        }

        //Ayman 
        void Button_Clicked(object sender, EventArgs e)
        {
            InvoiceCalculator calculator = new InvoiceCalculator();

            try
            {
                calculator.Subtotal = double.Parse(subtotal.Text);
                calculator.TipPercentage = double.Parse(tips.Text);
                
                result.Text = $"Tip amount: ${calculator.GetTipAmount()}\n" +
                              $"Tax Amount: ${calculator.GetHst()}" +
                              $"\nTotal Amount: ${calculator.GetTotal()}";
            }
            catch (Exception)
            {
               result.Text = $"Input error";
            }
            

        }

        private void Subtotal_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            result.Text = " ";
        }

        private void Tips_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            result.Text = " ";
        }
    }
}
