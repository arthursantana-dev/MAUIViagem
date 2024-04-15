using MAUIViagem.Models;

namespace MAUIViagem
{
    public partial class MainPage : ContentPage
    {

        public static Viagem viagem;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
        }

        private async void buttonCalcular_Clicked(object sender, EventArgs e)
        {
            double distancia = Convert.ToDouble(textDistancia.Text);
            double rendimento = Convert.ToDouble(textRendimento.Text);
            double valorGasolina = Convert.ToDouble(textPreco.Text);

            double custo = distancia * valorGasolina / rendimento;

            List<Pedagio> pedagios = await App.Db.GetAll();

            foreach (Pedagio pedagio in pedagios)
            {
                custo += pedagio.Valor;
            }

            viagem = new Viagem
            {
                Origem = textOrigem.Text,
                Destino = textDestino.Text,
                Distancia = Convert.ToDouble(textDistancia.Text),
                Rendimento = Convert.ToDouble(textRendimento.Text),
                Preco = Convert.ToDouble(textPreco.Text),

            }
            ;

            await Navigation.PushAsync(new Views.ConfirmarViagem());

        }

        private async void buttonAddPedagio_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.AddPedagio());

        }

        private async void buttonListPedagios_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Views.ListPedagios());

        }
    }

}
