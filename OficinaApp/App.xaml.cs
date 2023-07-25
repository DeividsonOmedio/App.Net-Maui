using OficinaApp.Data;
using OficinaApp.Model;
using OficinaApp.Pages;
using SQLite;

namespace OficinaApp;

public partial class App : Application
{

	static SQLiteData _bancoDados;

   /* private void Init()
	{
		  _conexaoBD = new SQLiteAsyncConnection(Constants.DataBasePath, Constants.Flags);
            var result = await _conexaoBD.CreateTableAsync<Usuario>();

            UsuarioDataTable = new UsuarioData(_conexaoBD);
	}*/
    public static SQLiteData BancoDados
	{
		get
		{
			if(_bancoDados == null)
			{
				try
				{
                    _bancoDados = new SQLiteData();
                    
                }
				catch
				{
                   
                }
				
			}
			return _bancoDados;
		}
			
	}

	public static Usuario Usuario { get; set; }

	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new LoginUsuarioPage());
	}
}
