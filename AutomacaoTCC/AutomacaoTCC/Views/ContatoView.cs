
using Xamarin.Forms;

namespace AutomacaoTCC.Views
{
	public class ContatoView : ContentPage
	{
        public ContatoView()
        {
            BindingContext = new ViewModels.ContatoViewModel();

            var LayoutNome = new StackLayout { Orientation = StackOrientation.Horizontal };
            var LayoutEmail = new StackLayout { Orientation = StackOrientation.Horizontal };
            var LayoutMensagem = new StackLayout { Orientation = StackOrientation.Horizontal };
            var LayoutContato = new StackLayout { Orientation = StackOrientation.Vertical, Padding = 12 };

            Label lblNome = new Label { Text = "Nome" , VerticalOptions = LayoutOptions.Center };
            Label lblEmail = new Label { Text = "Email", VerticalOptions = LayoutOptions.Center };
            Label lblMensagem = new Label { Text = "Mensagem", VerticalOptions = LayoutOptions.Center };

            

            Entry entNome = new Entry { Placeholder = "Nome Completo" };
            Entry entEmail = new Entry { Placeholder = "Email" };
            Entry entMensagem = new Entry { Placeholder = "Mensagem" };

            Button btnEnviar = new Button { Text = "ENVIAR" };

            LayoutNome.Children.Add(lblNome);
            LayoutNome.Children.Add(entNome);
            LayoutEmail.Children.Add(lblEmail);
            LayoutEmail.Children.Add(entEmail);
            LayoutMensagem.Children.Add(lblMensagem);
            LayoutMensagem.Children.Add(entMensagem);
            LayoutContato.Children.Add(LayoutNome);
            LayoutContato.Children.Add(LayoutEmail);
            LayoutContato.Children.Add(LayoutMensagem);
            LayoutContato.Children.Add(btnEnviar);

            Content = LayoutContato;
        }
    }
}