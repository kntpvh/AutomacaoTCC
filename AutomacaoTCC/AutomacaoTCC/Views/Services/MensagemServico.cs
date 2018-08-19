using System;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace AutomacaoTCC.Views.Services
{
    class MensagemServico : ViewModels.Services.IMensagemServico
    {
        public async Task ShowAsync(string message)
        {
            await App.Current.MainPage.DisplayAlert("Automção", message, "OK");
        }

        public Task ShowError()
        {
            throw new NotImplementedException();
        }
    }
}
