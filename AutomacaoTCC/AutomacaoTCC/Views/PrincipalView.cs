using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AutomacaoTCC.Views
{
	public class PrincipalView : TabbedPage
	{
		public PrincipalView ()
		{

            //VerticalOptions = LayoutOptions.FillAndExpand;
            //Title = "AUTOMAÇÃO";
            this.Padding = 0;

            //InitializeComponent();
            //var lampaga = new NavigationPage(new LampadasView());
            var lampada = new NavigationPage(new LampadasView());
            lampada.Icon = "lamp.png";
            //lampada.Title = "Lâmpadas";

            var config = new NavigationPage(new ConfiguracoesView());
            config.Icon = "configuracoes.png";
            //config.Title = "Configurações";

            var eletronicos = new NavigationPage(new EletronicosView());
            eletronicos.Icon = "eletronicos.png";
            //eletronicos.Title = "Eletrônicos";

            //Children.Add(new TodayPageCS());
            Children.Add(lampada);
            Children.Add(eletronicos);
            Children.Add(config);
            //BindingContext = new ViewModels.ConfiguracoesViewModel();

            
        }
	}
}