using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Payment.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Step1 : ContentView
    {
        public Step1()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_CreditCard(object sender, EventArgs e)
        {
            ImageFrame1.BackgroundColor = Color.Black;
            ImageFrame2.BackgroundColor = Color.White;

        }

        private void TapGestureRecognizer_BankTransfer(object sender, EventArgs e)
        {
            ImageFrame1.BackgroundColor = Color.White;
            ImageFrame2.BackgroundColor = Color.Black;

        }
        private void TapGestureRecognizer_Express(object sender, EventArgs e)
        {
            ImageFrame3.BackgroundColor = Color.Black;
            ImageFrame4.BackgroundColor = Color.White;

        }
        private void TapGestureRecognizer_Normal(object sender, EventArgs e)
        {
            ImageFrame3.BackgroundColor = Color.White;
            ImageFrame4.BackgroundColor = Color.Black;

        }
    }
}