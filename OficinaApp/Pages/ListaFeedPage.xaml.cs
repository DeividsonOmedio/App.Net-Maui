using OficinaApp.Dominio.Interface.ISistemaFinanceiro;
using OficinaApp.Model;
using SQLite;

namespace OficinaApp.Pages;

public partial class ListaFeedPage : ContentPage
{
    SQLiteAsyncConnection _conexaoBD;
    public ListaFeedPage()
	{
		InitializeComponent();
        CollectionView collectionView = new CollectionView
        {
            SelectionMode = SelectionMode.Single
        };
        //TODO
        collectionView.SetBinding(ItemsView.ItemsSourceProperty, "Sistemas");
        collectionView.SelectionChanged += CollectionView_SelectionChanged;

        AtualizaPage();
    }

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var previous = e.PreviousSelection;
        var current = e.CurrentSelection;
    }

    private async void AtualizaPage()
    {
        lvsSistemas.ItemsSource = await App.BancoDados.UsuarioDataTable.ListaUsuarios();
    }

  

    private async void btnAddSistema_Clicked(object sender, EventArgs e)
    {
        try
        {
            SistemaFinanceiro novoSistema = new SistemaFinanceiro();
            string sistema = txtSistema.Text;
            novoSistema.Nome = sistema;
            novoSistema.Ano = DateTime.Now.Year;
            novoSistema.Mes = DateTime.Now.Month;
            novoSistema.GerarCopiaDespesa = false;
            novoSistema.AnoCopia = DateTime.Now.Year;

            _conexaoBD.InsertAsync(novoSistema);
        }
        catch
        {
            await DisplayAlert("Atenção", "Erro ao adicionar", "Fechar");
        }
    }

    private async void btnListarSistema_Clicked(object sender, EventArgs e)
    {
        try
        {
            
            var sistema = _conexaoBD.Table<SistemaFinanceiro>().ToListAsync();


            lsvSistemas.ItemsSource = await sistema;
        }
        catch
        {
            await DisplayAlert("Atenção", "Erro ao buscar", "Fechar");
        }
    }
}