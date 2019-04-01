using SQLiteXF.ViewModels;
using Xamarin.Forms;

namespace SQLiteXF.Pages.Financeiro
{
    public class DespesaPage : ContentPage
    {
        public Entry TituloField { get; set; }
        public Entry ValorField { get; set; }
        public Button AdicionarButton { get; set; }
        public Button AtualizarButton { get; set; }
        public ListView DespesasList { get; set; }

        public DespesaPage()
        {
            BindingContext = new DespesaViewModel();

            TituloField = new Entry();
            TituloField.SetBinding(Entry.TextProperty, "Descricao");

            ValorField = new Entry();
            ValorField.SetBinding(Entry.TextProperty, "Valor");

            AdicionarButton = new Button
            {
                Text = "Adicionar",
                TextColor = Color.White,
                BackgroundColor = Color.DodgerBlue,
                FontSize = 22
            };
            AdicionarButton.SetBinding(Button.CommandProperty, "AddCommand");

            AtualizarButton = new Button
            {
                Text = "Atualizar",
                TextColor = Color.White,
                BackgroundColor = Color.Fuchsia,
                FontSize = 22
            };
            AtualizarButton.SetBinding(Button.CommandProperty, "RefreshCommand");

            var labelGrid = new Label();
            labelGrid.SetBinding(Label.TextProperty, "Descricao");

            //https://docs.microsoft.com/pt-br/xamarin/xamarin-forms/app-fundamentals/templates/data-templates/creating
            var despesasDataTemplate = new DataTemplate(() =>
            {
                var grid = new Grid();

                var descricaoLabel = new Label { FontAttributes = FontAttributes.Bold };
                var valorLabel = new Label();

                descricaoLabel.SetBinding(Label.TextProperty, "Descricao");
                valorLabel.SetBinding(Label.TextProperty, "Valor");
                
                grid.Children.Add(descricaoLabel);
                grid.Children.Add(valorLabel, 1, 0);
                
                return new ViewCell { View = grid };
            });



            DespesasList = new ListView();
            DespesasList.ItemTemplate = despesasDataTemplate;
            DespesasList.SetBinding(ListView.ItemsSourceProperty, "Despesas");

            Title = "Despesas";
            Content = new StackLayout
            {
                Spacing = 10,
                Padding = 20,
                Children =
                {
                    {
                        TituloField
                    },
                    {
                        ValorField
                    },
                    {
                        AdicionarButton
                    },
                    {
                        AtualizarButton
                    },
                    {
                        DespesasList
                    }
                }
            };
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ((DespesaViewModel)BindingContext).Refresh();
        }
    }
}
