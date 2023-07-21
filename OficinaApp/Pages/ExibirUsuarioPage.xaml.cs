 namespace OficinaApp.Pages;

public partial class ExibirUsuarioPage : ContentPage
{
	public ExibirUsuarioPage()
	{
		InitializeComponent();
	}

	private async void AtualizaPage()
	{
		lsvUsuarios.ItemsSource = await App.BancoDados.UsuarioDataTable.ListaUsuarios();
	}
}