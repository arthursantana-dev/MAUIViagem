using MAUIViagem.Models;

namespace MAUIViagem.Views;

public partial class AddPedagio : ContentPage
{
	public AddPedagio()
	{
		InitializeComponent();
	}

    private async void buttonAddPedagio_Clicked(object sender, EventArgs e)
    {
		try
		{
			Pedagio p = new Pedagio
			{
				Local = textLocal.Text,
				Valor = Convert.ToDouble(textValor.Text),
			};


            await DisplayAlert("Deu bom", "Deu bom", "OK");
			await App.Db.Insert(p);
			

        } catch (Exception ex)
		{
			await DisplayAlert("a", ex.Message, "OK");
		}
		{

		}
    }

	private async void Button_Clicked(object sender, EventArgs e)
	{
		List<Pedagio> pedagios = await App.Db.GetAll();

		string a = "";

		foreach (Pedagio p  in pedagios)
		{
			a += p.Local;
		}

		await DisplayAlert("a", a, "ok");

    }
}