using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace jcardenasExamen.Views;

public partial class Registro : ContentPage
{
    public Registro(string usuario_pasado)
    {
        InitializeComponent();
        lblUsuario.Text = "Usuario Conectado: " + usuario_pasado;   // asignas variable de paso
    }

    private void pkPais_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void pkCiudad_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        string edad = txtEdad.Text;
        // string fecha = dpFecha.DateSelected();
        // string ciudad = pkCiudad.SelectedItem;
        // string pais = pkCiudad.SelectedItem;
        string montoinicial = txtMontoI.Text;
        string cuotamensual=txtPagoMensual.Text;
        //string pagototal=

        Navigation.PushAsync(new Views.Resumen(nombre,apellido, edad,montoinicial, cuotamensual));

    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        var monto_inicial = Int32.Parse(txtMontoI.Text);
        var calculo_pago = 1500 - monto_inicial;
        var cuota = (calculo_pago / 4) + 60;
        var pago_total = (cuota * 4) + monto_inicial;

        txtPagoMensual.Text = cuota.ToString();



    }

    private void txtMontoI_Unfocused(object sender, FocusEventArgs e)
    {
        var monto_inicial = Int32.Parse(txtMontoI.Text);

        if (monto_inicial > 1500)
        {
            DisplayAlert("ERROR", "El monto inicial no puede ser mayor a 1500", "CERRAR");
            return;
        }

    }
}