namespace OficinaApp.Pages;

public partial class LoginUsuarioPage : ContentPage
{
	public LoginUsuarioPage()
	{
		InitializeComponent();
	}

    private async void btnEntrar_Clicked(object sender, EventArgs e)
    {
        string email = txtEmail.Text;
        string senha = txtSenha.Text;

        if(!string.IsNullOrWhiteSpace(email)  && !string.IsNullOrWhiteSpace(senha))
        {
            var usuario = await App.BancoDados.UsuarioDataTable.ObtemUsuario(email, senha);
        
            if(usuario == null)
            {
                await DisplayAlert("Aten��o", "Email ou Senha i nv�lidos", "Fechar");
                return;
            }

            App.usuario = usuario;

            Navigation.PushAsync(new HomePrincipalPage());
        }

    }

    private void btnRegistrar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new EditaUsuarioPage());
    }
}