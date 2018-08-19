using System.Collections.Generic;
using Xamarin.Forms;

namespace AutomacaoTCC.Views
{
    public class LoginView : ContentPage
    {
        public LoginView() {
            BindingContext = new ViewModels.LoginViewModel();

            Entry email = new Entry();
            email.Placeholder = "email@email.com";

            Entry senha = new Entry();
            senha.Placeholder = "senha";
            senha.IsPassword = true;

            Button btnLogar = new Button();
            btnLogar.Text = "Logar";

            //myButton.SetBinding(Button.CommandProperty, new Binding("ContatoCommand", 0));
            btnLogar.SetBinding(Button.CommandProperty, new Binding("PrincipalCommand"));
            Content = new StackLayout {
                Children = {
                    new StackLayout(){
                         Children = {
                            email,
                            senha,
                            btnLogar
                         }
                    }
                }
            };
        }
    }
}
