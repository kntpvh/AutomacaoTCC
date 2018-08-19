
namespace AutomacaoTCC.Models
{
    public class Servicos
    {
        public bool Lampada { get; set; }
        public bool Portao { get; set; }


        //Verifica se a lampada esta ligada ou desligada
        public static void Lampadas(bool status, string nome) {
            if (status) {
              //  Debug.WriteLine(nome+" ligada");
            } else {
             //Debug.WriteLine(nome + " Desligada");
            }
        }

        public void UsarPortao() {

        }

        public void Tv() {

        }
    }
}
