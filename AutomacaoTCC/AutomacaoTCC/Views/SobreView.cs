using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AutomacaoTCC.Views
{
	public class SobreView : ContentPage
	{
		public SobreView ()
		{
            BindingContext = new ViewModels.SobreViewModel();
			Content = new StackLayout {
				Children = {
					new Label { Text = "Welcome to Xamarin.Forms!" }
				}
			};
		}
	}
}