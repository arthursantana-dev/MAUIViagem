using MAUIViagem.Models;

namespace MAUIViagem.Views;

public partial class ConfirmarViagem : ContentPage
{
	Viagem viagem = MainPage.viagem;
    double somaPedagios = 0;
	public ConfirmarViagem()
	{
		InitializeComponent();
        textOrigem.Text = viagem.Origem;
        textDestino.Text = viagem.Destino;
        textDistancia.Text = viagem.Distancia.ToString();
        textRendimento.Text = viagem.Rendimento.ToString();
        textPreco.Text = viagem.Preco.ToString();
    }

    private async void buttonConfirmarViagem_Clicked(object sender, EventArgs e)
    {
        somaPedagios = 0;
        List<Pedagio> listaPedagios = await App.Db.GetAll();

        foreach (Pedagio pedagio in  listaPedagios)
        {
            somaPedagios += pedagio.Valor;
        }

        textSomaPedagio.Text = somaPedagios.ToString("C");
    }
    private async void buttonNovaViagem_Clicked(object sender, EventArgs e)
    {
        MainPage.viagem.Destino = "";
        MainPage.viagem.Origem = "";
        MainPage.viagem.Distancia = 0;
        MainPage.viagem.Rendimento = 0;
        MainPage.viagem.Preco = 0;

        await Navigation.PopAsync();
    }
}