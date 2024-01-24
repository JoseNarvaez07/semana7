namespace semana4.Vista;

public partial class Estudiante : ContentPage
{
	public Estudiante()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			WebClient cliente = new WebClient();
			var parametros = new System.Collections.Specialized.NameValueCollection();
			parametros.Add("nombre")
		}
    }
}