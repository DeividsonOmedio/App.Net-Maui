namespace OficinaApp.Pages;

public partial class NovaDespesa : TabbedPage
{
	public NovaDespesa()
	{
		InitializeComponent();

        var pagina1 = new ListaFeedPage()
        {
            Title = "Despesa",
            IconImageSource = ""
        };

        var pagina2 = new ExibirUsuarioPage()
        {
            Title = "Categoria",
            IconImageSource = ""
        };
        var pagina3 = new BuscaUsuarioPage()
        {
            Title = "Sistema",
            IconImageSource = ""
        };

        this.Children.Add(pagina1);
        this.Children.Add(pagina2);
        this.Children.Add(pagina3);
    }
}
	