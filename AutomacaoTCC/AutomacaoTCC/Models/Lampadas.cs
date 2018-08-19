
namespace AutomacaoTCC.Models
{
    public class Lampadas
    {
        public void UsarLampadas (bool status, string nomeDaLampada){
            Servicos.Lampadas(status, nomeDaLampada);
            //Debug.WriteLine("Lampada em uso !");
        }
    }
}
