using static System.Runtime.InteropServices.JavaScript.JSType;

namespace jcardenasExamen.Views;
public partial class Resumen : ContentPage
{
	public Resumen(string usuariop,string nombre, string apellido, string edad, string fecha, string ciudad, string pais, string montoinicial, string cuotamensual, string pagototal)
	{
		InitializeComponent();
		lblUsuariop.Text = usuariop;
		lblNombre.Text = nombre;
		lblApellido.Text = apellido;
		lblEdad.Text = edad;
		LblFecha.Text = fecha;
		LblCiudad.Text = ciudad;
		LblPais.Text = pais;
		LblMontoInicial.Text = montoinicial;
		LblPagoMensual.Text = cuotamensual;
		LblPagoTotal.Text = pagototal;

	}




}
