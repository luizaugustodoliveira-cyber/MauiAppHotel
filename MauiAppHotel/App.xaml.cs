using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {

        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suíte Presidencial",
                ValorDiaAdulto = 1200.0,
                ValorDiaCrianca = 840.0
            },
            new Quarto()
            {
                Descricao = "Suíte Master",
                ValorDiaAdulto = 1000.0,
                ValorDiaCrianca = 700.0
            },

            new Quarto()
            {
                Descricao = "Suíte Standard",
                ValorDiaAdulto = 800.0,
                ValorDiaCrianca = 560.0
            },

            new Quarto()
            {
                Descricao = "Suíte Economic",
                ValorDiaAdulto = 600.0,
                ValorDiaCrianca = 420.0
            },



        };
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window(
                new NavigationPage(
                    new Views.ContratacaoHospedagem()
                )
            );

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}