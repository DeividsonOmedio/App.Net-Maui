using OficinaApp.Data;
using OficinaApp.Model;
using OficinaApp.Pages;

namespace OficinaApp;

public partial class App : Application
{

	static SQLiteData _bancoDados;

	public static SQLiteData BancoDados
	{
		get
		{
			if(BancoDados == null)
			{
				_bancoDados =
					new SQLiteData(Path.Combine(Environment.GetFolderPath( Environment.SpecialFolder.LocalApplicationData), "Dados.db"));
			}
			return _bancoDados;
		}
			
	}

	public static Usuario usuario { get; set; }

	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new LoginUsuarioPage());
	}
}
