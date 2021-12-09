using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion
{
    public partial class Form1 : Form
    {
        private Clientes cliente ;
        public Form1()
        {
            InitializeComponent();

            var listTextBox = new List<TextBox>();
            listTextBox.Add(textBoxCi);
            listTextBox.Add(textBoxNombre);
            listTextBox.Add(textBoxApellido);
            listTextBox.Add(textBoxEmail);
            var listLabel = new List<Label>();
            listLabel.Add(labelCI);
            listLabel.Add(labelNombre);
            listLabel.Add(labelApellido);
            listLabel.Add(labelEmail);
            cliente = new Clientes(listTextBox, listLabel);
        } 

        private void pictureBoxImage_Click(object sender, EventArgs e)
        {
            cliente.uploadimage.CargarImage(pictureBoxImage);
        }

        private void textBoxCi_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCi.Text.Equals(""))
            {
                labelCI.ForeColor = Color.Red;
            }
            else
            {
                labelCI.ForeColor = Color.LimeGreen;
                labelCI.Text = "C.I";
            }
        }

        private void textBoxCi_KeyPress(object sender, KeyPressEventArgs e)
        {
            cliente.textBoxEvent.numberKeyPress(e);
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNombre.Text.Equals(""))
            {
                labelNombre.ForeColor = Color.Red;
            }
            else
            {
                labelNombre.ForeColor = Color.LimeGreen;
                labelNombre.Text = "Nombre";
            }
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            cliente.textBoxEvent.textKeyPress(e);
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            if (textBoxApellido.Text.Equals(""))
            {
                labelApellido.ForeColor = Color.Red;
            }
            else
            {
                labelApellido.ForeColor = Color.LimeGreen;
                labelApellido.Text = "Apellido";
            }
        }

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            cliente.textBoxEvent.textKeyPress(e);
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.Equals(""))
            {
                labelEmail.ForeColor = Color.Red;
            }
            else
            {
                labelEmail.ForeColor = Color.LimeGreen;
                labelEmail.Text = "Email";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cliente.Registrar(); 
        }
    }
}
