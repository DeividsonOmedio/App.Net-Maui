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
                await DisplayAlert("Atenção", "Email ou Senha inválidos", "Fechar");
                return;
            }

            App.Usuario = usuario;

            await Navigation.PushAsync(new HomePrincipalPage());
        }

    }

    private void btnRegistrar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new EditaUsuarioPage());
    }
}