using System;
using Xamarin.Forms;

namespace AutomacaoTCC
{
    public class App : Application
    {
        public App() {
            //Dependencia
            DependencyService.Register<ViewModels.Services.INavegarServico, Views.Services.NavegarServico>();
            DependencyService.Register<ViewModels.Services.IMensagemServico, Views.Services.MensagemServico>();

            MainPage = new NavigationPage(new Views.LoginView());
        }
    }
}
