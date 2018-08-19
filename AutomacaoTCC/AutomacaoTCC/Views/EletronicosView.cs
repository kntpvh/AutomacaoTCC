
using Xamarin.Forms;

namespace AutomacaoTCC.Views
{
    public class EletronicosView : ContentPage
    {
        public EletronicosView() {
            Title = "Eletrônicos";
            BindingContext = new ViewModels.EletronicosViewModel();

            Button btnPortaoGaragemAbrir = new Button();
            btnPortaoGaragemAbrir.HorizontalOptions = LayoutOptions.StartAndExpand;
            btnPortaoGaragemAbrir.Text = "ABRIR";
            btnPortaoGaragemAbrir.SetBinding(Button.CommandProperty, new Binding("PortaoGaragemAbrirCommand"));

            Button btnPortaoGaragemFechar = new Button();
            btnPortaoGaragemFechar.HorizontalOptions = LayoutOptions.EndAndExpand;
            btnPortaoGaragemFechar.Text = "FECHAR";
            btnPortaoGaragemFechar.SetBinding(Button.CommandProperty, new Binding("PortaoGaragemFecharCommand"));

            Button btnPortaoGrandeAbrir = new Button();
            btnPortaoGrandeAbrir.Text = "ABRIR";
            btnPortaoGrandeAbrir.WidthRequest = 80;
            btnPortaoGrandeAbrir.HorizontalOptions = LayoutOptions.Start;
            btnPortaoGrandeAbrir.SetBinding(Button.CommandProperty, new Binding("PortaoGrandeAbrirCommand"));

            Button btnPortaoGrandeParar = new Button();
            btnPortaoGrandeParar.Text = "PARAR";
            btnPortaoGrandeParar.WidthRequest = 80;
            btnPortaoGrandeParar.HorizontalOptions = LayoutOptions.Center;
            btnPortaoGrandeParar.SetBinding(Button.CommandProperty, new Binding("PortaoGrandePararCommand"));

            Button btnPortaoGrandeFechar = new Button();
            btnPortaoGrandeFechar.Text = "FECHAR";
            btnPortaoGrandeFechar.WidthRequest = 80;
            btnPortaoGrandeFechar.HorizontalOptions = LayoutOptions.End;
            btnPortaoGrandeFechar.SetBinding(Button.CommandProperty, new Binding("PortaoGrandeFecharCommand"));

            Switch ventiladorSw = new Switch();
            ventiladorSw.SetBinding(Switch.IsToggledProperty, new Binding("VentiladorSw"));
            ventiladorSw.HorizontalOptions = LayoutOptions.CenterAndExpand;
            
            
            
            Content = new StackLayout
            {

                Orientation = StackOrientation.Vertical,
                Children = {
                    //1 - PORTAO GARAGEM
					new StackLayout {
                        //BackgroundColor = Color.Gainsboro,
                        
                        Orientation = StackOrientation.Vertical,
                        Padding = 2,
                        Children = {
                            new Label {
                                Text = "Portão Garagem",
                                TextColor = Color.Gray,
                                VerticalOptions = LayoutOptions.Center,
                                HorizontalOptions = LayoutOptions.Center
                            },
                            new StackLayout {
                                Orientation = StackOrientation.Horizontal,
                                
                                Children = {
                                    btnPortaoGaragemAbrir,
                                    btnPortaoGaragemFechar
                                }
                            }
                        }
                    },
                    //2 - PORTAO GRANDE
                    new StackLayout{
                        BackgroundColor = Color.Gainsboro,
                        Orientation = StackOrientation.Vertical,
                        Padding = 2,
                        Children = {
                            new Label {
                                Text = "Portão Grande",
                                TextColor = Color.Gray,
                                VerticalOptions = LayoutOptions.Center,
                                HorizontalOptions = LayoutOptions.Center
                            },
                            new StackLayout {
                                Orientation = StackOrientation.Horizontal,
                                Children = {
                                    btnPortaoGrandeAbrir,
                                    btnPortaoGrandeParar,
                                    btnPortaoGrandeFechar
                                }
                            }
                        }
                    },
                    //3 - VENTILADOR
                    new StackLayout{
                        //BackgroundColor = Color.Gainsboro,
                        Orientation = StackOrientation.Vertical,
                        Children = {
                            new Label{ Text = "Ventilador", HorizontalOptions = LayoutOptions.Center},
                            ventiladorSw
                        }
                    }
                }

            };
        }

       
    }
}