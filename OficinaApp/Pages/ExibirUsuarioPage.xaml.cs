 namespace OficinaApp.Pages;

public partial class ExibirUsuarioPage : ContentPage
{
	public ExibirUsuarioPage()
	{
		InitializeComponent();
		AtualizaPage();
	}

	private async void AtualizaPage()
	{
		lsvUsuarios.ItemsSource = await App.BancoDados.UsuarioDataTable.ListaUsuarios();
		lsvUsuari.ItemsSource = await App.BancoDados.UsuarioDataTable.ListaUsuarios();
		lsvUsus.ItemsSource = await App.BancoDados.UsuarioDataTable.ListaUsuarios();
		lsvUs.ItemsSource = await App.BancoDados.UsuarioDataTable.ListaUsuarios();
    }


    private void CollectionView_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
    {

    }
}