using System.Collections.ObjectModel;
using MAUIViagem.Models;

namespace MAUIViagem.Views;

public partial class ListPedagios : ContentPage
{
	ObservableCollection<Pedagio> OclistPedagios = new ObservableCollection<Pedagio>(); 
	public ListPedagios()
	{
		InitializeComponent();
		listPedagios.ItemsSource = OclistPedagios;
	}

	protected async override void OnAppearing()
	{
		if(OclistPedagios.Count == 0)
		{
			List<Pedagio> getAllResult = await App.Db.GetAll();

			foreach(Pedagio p in getAllResult)
			{
				OclistPedagios.Add(p);
			}
		}
	}
}