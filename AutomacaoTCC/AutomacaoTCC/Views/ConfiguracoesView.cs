using Xamarin.Forms;

namespace AutomacaoTCC.Views
{
    public class ConfiguracoesView : ContentPage
    {
        public ConfiguracoesView()
        {
            BindingContext = new ViewModels.ConfiguracoesViewModel();
            Title = "Configurações";
            //InitializeComponent ();
            

            var status = new StackLayout() { Orientation = StackOrientation.Horizontal, Padding = 8 };
            var tapStatus = new TapGestureRecognizer();
            tapStatus.SetBinding(TapGestureRecognizer.CommandProperty, new Binding("StatusCommand"));     
            status.GestureRecognizers.Add(tapStatus);
            status.Children.Add(new Label(){              
                Text = "STATUS",
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            });

            var conta = new StackLayout() { Orientation = StackOrientation.Horizontal, Padding = 8 };
            var tapConta = new TapGestureRecognizer();
            tapConta.SetBinding(TapGestureRecognizer.CommandProperty, new Binding("ContaCommand"));
            conta.GestureRecognizers.Add(tapConta);
            conta.Children.Add(new Label()
            {
                Text = "CONTA",
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
            });

            var sobre = new StackLayout(){ Orientation = StackOrientation.Horizontal, Padding = 8 };
            var tapSobre = new TapGestureRecognizer();
            tapSobre.SetBinding(TapGestureRecognizer.CommandProperty, new Binding("SobreCommand"));
            sobre.GestureRecognizers.Add(tapSobre);
            sobre.Children.Add(new Label(){
                Text = "SOBRE",
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,

            });


            var contato = new StackLayout() { Orientation = StackOrientation.Horizontal, Padding = 8 };
            var tapContato = new TapGestureRecognizer();
            tapContato.SetBinding(TapGestureRecognizer.CommandProperty, new Binding("ContatoCommand"));
            contato.GestureRecognizers.Add(tapContato);
            contato.Children.Add(new Label() {
                Text = "CONTATO",
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            });

            var tabela = new TableView();
            tabela.Root = new TableRoot() {
                new TableSection(){
                    new ViewCell(){ View = status },
                    new ViewCell(){ View = conta },
                    new ViewCell(){ View = sobre },
                    new ViewCell(){ View = contato }
                }
            };


            //BindingContext = new ViewModels.ConfiguracoesViewModel();
            Content = tabela;
        }
    }
};