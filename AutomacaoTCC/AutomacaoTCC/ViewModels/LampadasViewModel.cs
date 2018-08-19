using AutomacaoTCC.Models;

using Xamarin.Forms;


namespace AutomacaoTCC.ViewModels
{
    public class LampadasViewModel //: ViewModelBase
    {
        Lampadas objLampadas = new Lampadas();

        bool quartoSw;
        public bool QuartoSw {
            get { return quartoSw; }
            set {
                quartoSw = value;
                
                //objLampadas.UsarLampadas(quartoSw,"QuartoSw");
                LampadaQuarto(quartoSw);
            }
        }

        bool salaDeEstarSw;
        public bool SalaDeEstarSw {
            get { return salaDeEstarSw; }
            set{
                salaDeEstarSw = value;
                
                LampadaSala(salaDeEstarSw);
                //Debug.WriteLine("bool = "+salaDeEstarSw);
            }
        }

        bool cozinhaSw;
        public bool CozinhaSw {
            get { return cozinhaSw; }
            set {
                cozinhaSw = value;
                
                //Debug.WriteLine("bool = "+cozinhaSw);
                LampadaCozinha(cozinhaSw);
            }
        }

        bool garagemSw;
        public bool GaragemSw {
            get { return garagemSw; }
            set {
                garagemSw = value;
                
                //Debug.WriteLine("bool = "+garagemSw);
                LampadaGaragem(garagemSw);
            }
        }

        bool quartoSuiteSw;
        public bool QuartoSuiteSw {
            get { return quartoSuiteSw; }
            set {
                quartoSuiteSw = value;
                
                //Debug.WriteLine("bool = "+quartoSuiteSw);
                //VerBoolean();
                LampadaQuartoSuite(quartoSuiteSw);
            }
        }

        bool corredorSw;
        public bool CorredorSw {
            get { return corredorSw; }
            set {
                corredorSw = value;
                
                //Debug.WriteLine("bool = "+corredorSw);
                LampadaCorredor(corredorSw);
            }
        }


        private readonly Services.IMensagemServico mensagemServico;

        public LampadasViewModel() {

            

            this.mensagemServico = DependencyService.Get<Services.IMensagemServico>();
        }

        private async void VerBoolean() {
            await this.mensagemServico.ShowAsync("Valor: " + CorredorSw.ToString());
        }

        private void LampadaQuarto(bool status) {
            if (status == true) {
                Conexao.Publicar("/home/QUARTO/01", "ON");
            }else {
                Conexao.Publicar("/home/QUARTO/01", "OFF");
            }
        }

        public void LampadaSala(bool status) {
            //192.168.0.9 - t / home / SALA / 01 - m "OFF"
            if (status == true){
                Conexao.Publicar("/home/SALA/01", "ON");
            }else{
                Conexao.Publicar("/home/SALA/01", "OFF");
            }
        }

        public void LampadaCozinha(bool status) {
            //192.168.0.9 - t / home / SALA / 01 - m "OFF"
            if (status == true){
                Conexao.Publicar("/home/COZINHA/01", "ON");
            }else{
                Conexao.Publicar("/home/COZINHA/01", "OFF");
            }
        }
        
        public void LampadaGaragem(bool status) {
            //192.168.0.9 - t / home / SALA / 01 - m "OFF"
            if (status == true){
                Conexao.Publicar("/home/GARAGEM/01", "ON");
            }else{
                Conexao.Publicar("/home/GARAGEM/01", "OFF");
            }
        }

        public void LampadaQuartoSuite(bool status) {
            //192.168.0.9 - t / home / SALA / 01 - m "OFF"
            if (status == true){
                Conexao.Publicar("/home/QUARTO/02", "ON");
            }else{
                Conexao.Publicar("/home/QUARTO/02", "OFF");
            }
        }

        public void LampadaCorredor(bool status) {
            //192.168.0.9 - t / home / SALA / 01 - m "OFF"
            if (status == true){
                Conexao.Publicar("/home/CORREDOR/01", "ON");
            }else{
                Conexao.Publicar("/home/CORREDOR/01", "OFF");
            }
        }



    }
}
