using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Pedro Andres Lara Campo, Kevin Kaled Rojas, Alexis Knight
/// 30 De Marzo de 2022
/// Registro multas Vehiculos Patio Medellin
/// </summary>
namespace WdVehicles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IniciarFormulario();
        }
        //se crea un metodo para iniciar el formulario de manera que el usuario pueda seleccionar la opcion que necesite
        private void IniciarFormulario()
        {
            #region [Limpiar el formulario]
            try
            {
                txtBrand.Text = " ";
                txtColour.Text = " ";
                txtModel.Text = " ";
                txtPlaque.Text = " ";
                txtPower.Text = " ";
                rdoCab.Checked = false;
                rdoBus.Checked = false;
                rdoParticular.Checked = false;
                txtBrand.Enabled = true;
                txtColour.Enabled = true;
                txtModel.Enabled = true;
                txtPlaque.Enabled = true;
                txtPower.Enabled = true;
                #endregion   
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message, "Error");
            }



        }
        //se configura el boton mostrar para seleccionar y que el usuario pueda visualizar los datos ingresados segun cada caso
        private void btnShow_Click(object sender, EventArgs e)
        {
            var taxi = new clsCab();
            var bus = new clsBus();
            var particular = new clsParticular();
            if (rdoCab.Checked)
            {
                taxi.Plaque = txtPlaque.Text;
                taxi.Model = Int32.Parse(txtModel.Text);
                taxi.Colour = txtColour.Text;
                taxi.Brand = txtBrand.Text;
                MessageBox.Show($"informacion del Taxi\r\n " + $"placa: {taxi.Plaque}\r\n" + $"modelo: {taxi.Model}\r\n" + $"color: {taxi.Colour}\r\n" + $"marca: {taxi.Brand}\r\n");
            }

            else if (rdoBus.Checked)
            {
                bus.Plaque = txtPlaque.Text;
                bus.Model = Int32.Parse(txtModel.Text);
                bus.Colour = txtColour.Text;
                bus.Brand = txtBrand.Text;
                bus.Power = Int32.Parse(txtPower.Text);
                MessageBox.Show($"informacion del Bus\r\n " + $"placa: {bus.Plaque}\r\n" + $"modelo: {bus.Model}\r\n" + $"color: {bus.Colour}\r\n" + $"marca: {bus.Brand}\r\n" + $"potencia: {bus.Power}\r\n");
            }

            else if (rdoParticular.Checked)
            {
                particular.Plaque = txtPlaque.Text;
                particular.Model = Int32.Parse(txtModel.Text);
                particular.Colour = txtColour.Text;
                particular.Power = Int32.Parse(txtPower.Text);
                MessageBox.Show($"informacion del Particular\r\n" + $"placa: {particular.Plaque}\r\n" + $"modelo: {particular.Model}\r\n" + $"Color: {particular.Colour}\r\n" + $"potencia: {particular.Power}\r\n");
            }
        }


        //se configuran los botones que se van a dejar disponibles para el ususario segun cada caso
        private void rdoCab_CheckedChanged(object sender, EventArgs e)
        {
            txtPlaque.Enabled = true;
            txtModel.Enabled = true;
            txtBrand.Enabled = true;
            txtColour.Enabled = true;
            txtPower.Enabled = false;
        }

        private void rdoParticular_CheckedChanged(object sender, EventArgs e)
        {
            txtPlaque.Enabled = true;
            txtModel.Enabled = true;
            txtBrand.Enabled = false;
            txtColour.Enabled = true;
            txtPower.Enabled = true;
        }

        private void rdoBus_CheckedChanged(object sender, EventArgs e)
        {
            txtPlaque.Enabled = true;
            txtModel.Enabled = true;
            txtBrand.Enabled = true;
            txtColour.Enabled = true;
            txtPower.Enabled = true;
        }
        //se usa para que el usuario reciba un mensaje que le indique si quiere proceder a abandonar el programa
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estas seguro mi estimado(a) amiguito(a) que deseas abandonar este maravilloso programa? .-.", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (resultado == DialogResult.No);
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            IniciarFormulario();
        }
    }
}
