using Xamarin.Forms;
using System.Windows.Input;

namespace AutomacaoTCC.ViewModels
{
    public class LoginViewModel //: ViewModelBase
    {
        public ICommand PrincipalCommand { get; set; }

        private readonly Services.INavegarServico navegarPrincipal;

        public LoginViewModel() {
            this.PrincipalCommand = new Command(this.Principal);
            this.navegarPrincipal = DependencyService.Get<Services.INavegarServico>();
        }

        private async void Principal() {
            //await this.navegarPrincipal.NavegarParaPrincipal();
            await this.navegarPrincipal.NavegarParaPrincipal();
        }


    }
}
