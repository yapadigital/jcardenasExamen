using static System.Runtime.InteropServices.JavaScript.JSType;

namespace jcardenasExamen.Views;
public partial class Resumen : ContentPage
{
	public Resumen(string nombre, string apellido, string edad, string montoinicial, string cuotamensual)
	{
		InitializeComponent();
        lblNombre.Text = nombre;
		lblApellido.Text = apellido;
		lblEdad.Text = edad;	
		LblMontoInicial.Text = montoinicial;
		LblPagoMensual.Text = cuotamensual;


       
	}
}