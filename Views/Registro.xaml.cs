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
        var picker = (Picker)sender;
        var seleccion = picker.SelectedItem.ToString();
        tmpPais.Text = seleccion;


        }

    private void pkCiudad_SelectedIndexChanged(object sender, EventArgs e)
    {
        var pickerc = (Picker)sender;
        var seleccionc = pickerc.SelectedItem.ToString();
        tmpCiudad.Text = seleccionc;

    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        string usuariop=lblUsuario.Text;
                string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        string edad = txtEdad.Text;
        string fecha = tmpFecha.Text;
        string ciudad = tmpCiudad.Text;
        string pais = tmpPais.Text;
        string montoinicial = txtMontoI.Text;
        string cuotamensual=txtPagoMensual.Text;
        string pagototal= tmpPT.Text;


        Navigation.PushAsync(new Views.Resumen(usuariop,nombre, apellido, edad,fecha,ciudad,pais,montoinicial, cuotamensual,pagototal));

    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        var monto_inicial = Int32.Parse(txtMontoI.Text);
        var calculo_pago = 1500 - monto_inicial;
        var cuota = (calculo_pago / 4) + 60;
        var pago_total = (cuota * 4) + monto_inicial;

        txtPagoMensual.Text = cuota.ToString();
        tmpPT.Text=pago_total.ToString();



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

    private void dpFecha_DateSelected(object sender, DateChangedEventArgs e)
    {
        var FechaSel = e.NewDate;
        tmpFecha.Text = FechaSel.ToString();
        
    }
}