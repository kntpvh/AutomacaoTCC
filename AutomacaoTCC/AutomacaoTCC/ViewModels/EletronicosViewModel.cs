using Xamarin.Forms;
using System.Windows.Input;
using AutomacaoTCC.Models;

namespace AutomacaoTCC.ViewModels
{
    class EletronicosViewModel //: ViewModelBase
    {
        

        public ICommand PortaoGaragemAbrirCommand { get; set; }
        public ICommand PortaoGaragemFecharCommand { get; set; }
        public ICommand PortaoGrandeAbrirCommand { get; set; }
        public ICommand PortaoGrandePararCommand { get; set; }
        public ICommand PortaoGrandeFecharCommand { get; set; }

        private bool ventiladorSw;
        public bool VentiladorSw {
            get { return ventiladorSw; }
            set {
                ventiladorSw = value;
                //Notify("VentiladorSw");
                //Debug.WriteLine("ei");
                AcionarVentilador(ventiladorSw);
            }
        }

        public EletronicosViewModel() {
            this.PortaoGaragemAbrirCommand = new Command(this.PortaoGaragemAbrir);
            this.PortaoGaragemFecharCommand = new Command(this.PortaoGaragemFechar);
            this.PortaoGrandeAbrirCommand = new Command(this.PortaoGrandeAbrir);
            this.PortaoGrandePararCommand = new Command(this.PortaoGrandeParar);
            this.PortaoGrandeFecharCommand = new Command(this.PortaoGrandeFechar);
        }

        private void PortaoGaragemAbrir() {
            Conexao.Publicar("/home/PORTA/01","ON");
        }

        private void PortaoGaragemFechar() {
            //Debug.WriteLine("Fechou o Portao");
            Conexao.Publicar("/home/PORTA/01", "OFF");
        }

        private void PortaoGrandeAbrir() {
            // Debug.WriteLine("Abriu o portao grande");
            Conexao.Publicar("/home/PORTAO/01", "ON");
        }

        private void PortaoGrandeParar() {
            //Debug.WriteLine("Parou o portao grande");
            Conexao.Publicar("/home/PORTAO/01", "PARAR");
        }

        private void PortaoGrandeFechar() {
            // Debug.WriteLine("Fechou o portao grande");
            Conexao.Publicar("/home/PORTAO/01", "OFF");
        }

        private void AcionarVentilador(bool status) {
            if (status == true) {
                Conexao.Publicar("/home/VENTILADOR/01", "ON");
            }else {
                Conexao.Publicar("/home/VENTILADOR/01", "OFF");
            }
        }
    }
}
