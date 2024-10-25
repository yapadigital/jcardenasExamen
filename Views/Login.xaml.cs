namespace jcardenasExamen.Views;

public partial class Login : ContentPage
{

    private readonly string[,] usuarios = {
        { "estudiante", "moviles" },
        { "uisrael", "2024" },

};

    private bool ValidarUsuario(string usuario, string contrase�a)
    {
        for (int i = 0; i < usuarios.GetLength(0); i++)
        {
            if (usuarios[i, 0] == usuario && usuarios[i, 1] == contrase�a)
            {
                return true;
            }
        }
        return false;
    }


    public Login()
	{
		InitializeComponent();
	}

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {

        string usuario = txtUsuario.Text;
        string contrase�a = txtContrasena.Text;


        if (ValidarUsuario(usuario, contrase�a))
        {
            string usuario_pasado = usuario;
            
            //Navigation.PushAsync(new Views.Calculo());
            Navigation.PushAsync(new Views.Registro(usuario_pasado));

        }
        else
        {
            DisplayAlert("Error", "Usuario o contrase�a incorrectos.", "Cerrar");
        }


    }
}