using System.Threading.Tasks;
using Xamarin.Forms;

namespace AutomacaoTCC.Views.Services
{
    public class NavegarServico : ViewModels.Services.INavegarServico
    {
        public async Task NavegarParaConta(){
            await Application.Current.MainPage.Navigation.PushAsync(new ContaView());
        }

        public async Task NavegarParaContato(){
            await Application.Current.MainPage.Navigation.PushAsync(new ContatoView());
        }

        public async Task NavegarParaPrincipal(){
            await Application.Current.MainPage.Navigation.PushAsync(new PrincipalView());
        }

        public async Task NavegarParaSobre(){
            await Application.Current.MainPage.Navigation.PushAsync(new SobreView());
        }

        public async Task NavegarParaStatus()
{
            await Application.Current.MainPage.Navigation.PushAsync(new StatusView());
        }
    }
}
