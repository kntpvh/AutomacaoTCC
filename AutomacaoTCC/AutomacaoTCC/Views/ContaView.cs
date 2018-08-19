using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AutomacaoTCC.Views
{
	public class ContaView : ContentPage { 
		public ContaView ()
		{
            BindingContext = new ViewModels.ContaViewModel();
			Content = new StackLayout {
				Children = {
					new Label { Text = "Welcome to Xamarin.Forms!" }
				}
			};
		}
	}
}