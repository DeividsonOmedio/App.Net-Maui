namespace OficinaApp.Pages;

public partial class HomePrincipalPage : TabbedPage
{
	public HomePrincipalPage()
	{
		InitializeComponent();

		var pagina1 = new ListaFeedPage()
		{
			Title = "Feed",
			IconImageSource = ""
		};

        var pagina2 = new ExibirUsuarioPage()
        {
            Title = "Exibir Usuário",
            IconImageSource = ""
        };
        var pagina3 = new BuscaUsuarioPage()
        {
            Title = "Buscar Usuário",
            IconImageSource = ""
        };

        this.Children.Add(pagina1);
        this.Children.Add(pagina2);
        this.Children.Add(pagina3);
    }
}