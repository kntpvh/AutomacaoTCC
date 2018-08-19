using Xamarin.Forms;
namespace AutomacaoTCC.Views
{
    public class LampadasView : ContentPage
    {
        public LampadasView()
        {
            BindingContext = new ViewModels.LampadasViewModel();
            Title = "Lampadas";
            
            var table = new TableView();
            
            
            var quarto = new StackLayout() { Orientation = StackOrientation.Horizontal };
            quarto.Children.Add(new Image()
            {
                //Source = "icon.png"
                //Aspect = Aspect.AspectFit,
                Source = "lamp.png"
            });

            Switch quartoSw = new Switch();
            //quartoSw.Toggled += QuartoToggled;
            
            quartoSw.SetBinding(Switch.IsToggledProperty, new Binding("QuartoSw"));
            //a.SetBinding(Switch.IsToggledProperty , new Binding("swcommand"));
            quarto.Children.Add(quartoSw);
            
            quarto.Children.Add(new Label()
            {
                Text = "Quarto",
                TextColor = Color.Gray,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            });


            var sala = new StackLayout() { Orientation = StackOrientation.Horizontal };
            sala.Children.Add(new Image()
            {
                Source = "lamp.png"
            });
            Switch salaSw = new Switch();
            //salaSw.Toggled += SalaToggled;

            salaSw.SetBinding(Switch.IsToggledProperty, new Binding("SalaDeEstarSw"));
            sala.Children.Add(salaSw);
            sala.Children.Add(new Label()
            {
                Text = "Sala de Estar",
                TextColor = Color.Gray,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            });

            var cozinha = new StackLayout() { Orientation = StackOrientation.Horizontal };
            cozinha.Children.Add(new Image()
            {
                Source = "lamp.png"
            });
            Switch cozinhaSw = new Switch();
            //cozinhaSw.Toggled += CozinhaToggled;
            cozinhaSw.SetBinding(Switch.IsToggledProperty, new Binding("CozinhaSw"));
            cozinha.Children.Add(cozinhaSw);
            cozinha.Children.Add(new Label()
            {
                Text = "Cozinha",
                TextColor = Color.Gray,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            });

            var garagem = new StackLayout() { Orientation = StackOrientation.Horizontal };
            garagem.Children.Add(new Image()
            {
                Source = "lamp.png"
            });
            Switch garagemSw = new Switch();
            //garagemSw.Toggled += GaragemToggled;

            garagemSw.SetBinding(Switch.IsToggledProperty, new Binding("GaragemSw"));
            garagem.Children.Add(garagemSw);
            garagem.Children.Add(new Label()
            {
                Text = "Garagem",
                TextColor = Color.Gray,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            });

            var quartoSuite = new StackLayout() { Orientation = StackOrientation.Horizontal };
            quartoSuite.Children.Add(new Image()
            {
                Source = "lamp.png"
            });
            Switch quartoSuiteSw = new Switch();
            //quartoSuiteSw.Toggled += QuartoSuiteToggled;
            quartoSuiteSw.SetBinding(Switch.IsToggledProperty, new Binding("QuartoSuiteSw"));
            quartoSuite.Children.Add(quartoSuiteSw);
            quartoSuite.Children.Add(new Label()
            {
                Text = "Quarto Suite",
                TextColor = Color.Gray,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            });

            var corredor = new StackLayout() { Orientation = StackOrientation.Horizontal };
            corredor.Children.Add(new Image()
            {
                Source = "lamp.png"
            });
            Switch corredorSw = new Switch();
            corredorSw.SetBinding(Switch.IsToggledProperty, new Binding("CorredorSw"));
            corredor.Children.Add(corredorSw);

            corredor.Children.Add(new Label()
            {
                Text = "Corredor",
                TextColor = Color.Gray,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            });


            table.Root = new TableRoot() {
                //titulo da view
                //new TableSection("Automação Residencial") {
                new TableSection() {
                    new ViewCell() { View = quarto },
                    new ViewCell() { View = sala },
                    new ViewCell() { View = cozinha },
                    new ViewCell() { View = garagem },
                    new ViewCell() { View = quartoSuite },
                    new ViewCell() { View = corredor }
                }
            };

            Content = table;
        }



        

        //private async void CozinhaToggled(object sender, ToggledEventArgs e) {
          //  await DisplayAlert("Ola", "oi cozinha " + e.Value, "Fechar");
        //}
        
    }
}