using System.Threading.Tasks;

namespace AutomacaoTCC.ViewModels.Services
{
    public interface IMensagemServico
    {
        Task ShowAsync(string message);
        Task ShowError();
    }
}
