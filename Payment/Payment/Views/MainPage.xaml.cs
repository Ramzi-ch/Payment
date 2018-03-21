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
	public partial class MainPage : ContentPage
	{   int p;
		public MainPage ()
		{
			InitializeComponent ();

            Step.Content = new Step1();
            FrameStart.BackgroundColor = Color.Gray;
            p = 1;

        }

        void NextClicked(object sender, EventArgs e)
        {
            if(p==1)
            {
                Step.Content = new Step2();
                FrameCenter.BackgroundColor = Color.Gray;
                FrameCercle1.BackgroundColor = Color.Gray;
                p = 2;
            }
            else if (p==2)
            {
                Step.Content = new Step3();
                FrameEnd.BackgroundColor = Color.Gray;
                FrameCercle2.BackgroundColor = Color.Gray;
                BtnNext.Text = "Pay";
                p = 3;
            }
            
        }
         void BackClicked(object sender, EventArgs e)
         {
            if (p == 2)
            {
                Step.Content = new Step1();
                FrameCercle1.BackgroundColor = Color.White;
                FrameCenter.BackgroundColor = Color.Silver;
                p = 1;
            }
            else if (p == 3)
            {
                Step.Content = new Step2();
                FrameCercle2.BackgroundColor = Color.White;
                FrameEnd.BackgroundColor = Color.Silver;
                p = 2;
            }
         }

    }
}