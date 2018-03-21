using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Payment
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Step3 : ContentView
	{
        List<ListProduct> ListP;
        public Step3 ()
		{
			InitializeComponent ();
            ListP = new List<ListProduct>
            {
                new ListProduct{Id="1",Close="close.png",Image="bag.png", Name="Gucci Hand Bag Light Brown", Type="NEW PRADA", Price="3000.00 SAR"},
                new ListProduct{Id="2",Close="close.png",Image="bag2.png", Name="Andre Hand Bag Light Brown", Type="NEW PRADA", Price="3000.00 SAR"},
                new ListProduct{Id="3",Close="close.png",Image="bag3.png", Name="Prada Hand Bag Light Brown", Type="NEW PRADA", Price="3000.00 SAR"}
            };
            List1.ItemsSource = ListP;
        }


        void ImageClose_Tapped(object sender, EventArgs e)
        {
            List<ListProduct> resultList = new List<ListProduct>();
            Image closeImage = sender as Image;
            var itemSelected = closeImage.BindingContext as ListProduct;

            //foreach(ListProduct pp in ListP.ToList())
            //{
            //    if (pp.Id.Equals(itemSelected.Id))
            //    {
            //        ListP.Remove(pp);
            //    }
            //    else
            //    {
            //        resultList.Add(pp);
            //    }
            //}

            for (int i = 0; i < ListP.Count; i++)
            {
                if (ListP[i].Id.Equals(itemSelected.Id))
                {
                    ListP.Remove(ListP[i]);
                }
                else
                {
                    resultList.Add(ListP[i]);
                }
            }

            List1.ItemsSource = resultList;

            
            
        }

    }
}