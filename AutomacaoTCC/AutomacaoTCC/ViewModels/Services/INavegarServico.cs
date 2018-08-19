using System.Threading.Tasks;

namespace AutomacaoTCC.ViewModels.Services
{
    internal interface INavegarServico
    {
        Task NavegarParaContato();

        Task NavegarParaPrincipal();

        Task NavegarParaStatus();

        Task NavegarParaConta();

        Task NavegarParaSobre();
    }
}
