using Xamarin.Forms;
using System.Windows.Input;


namespace AutomacaoTCC.ViewModels
{
    public class ConfiguracoesViewModel //: ViewModelBase
    {
        public ICommand StatusCommand { get; set; }
        public ICommand ContaCommand { get; set; }
        public ICommand SobreCommand { get; set; }
        public ICommand ContatoCommand { get; set; }
        
        private readonly Services.INavegarServico navegarContato;
        private readonly Services.INavegarServico navegarStatus;
        private readonly Services.INavegarServico navegarSobre;
        private readonly Services.INavegarServico navegarConta;

        public ConfiguracoesViewModel() {
            this.ContatoCommand = new Command(this.Contato);
            this.StatusCommand = new Command(this.Status);
            this.ContaCommand = new Command(this.Conta);
            this.SobreCommand = new Command(this.Sobre);

            this.navegarContato = DependencyService.Get<Services.INavegarServico>();
            this.navegarStatus = DependencyService.Get<Services.INavegarServico>();
            this.navegarSobre = DependencyService.Get<Services.INavegarServico>();
            this.navegarConta = DependencyService.Get<Services.INavegarServico>();
        }

        private async void Contato() {
            await this.navegarContato.NavegarParaContato();
        }

        private async void Conta() {
            await this.navegarConta.NavegarParaConta();
        }

        private async void Sobre() {
            await this.navegarSobre.NavegarParaSobre();
        }

        private async void Status() {
            await this.navegarStatus.NavegarParaStatus();
        }
    }
}
