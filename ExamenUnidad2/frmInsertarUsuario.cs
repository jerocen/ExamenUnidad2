using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenUnidad2
{
    public partial class frmInsertarUsuario : Form
    {
        public frmInsertarUsuario()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (!ValidarTelefono(txtTelefono.Text))
            {
                MessageBox.Show("El teléfono debe tener 10 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidarCorreo(txtCorreo.Text))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Datos datos = new Datos();
            bool f = datos.comando("INSERT INTO Usuarios VALUES('" +
                txtAPaterno.Text + "','" + txtAMaterno.Text + "','" + txtNombre.Text + "','" +
                txtTelefono.Text + "','" + txtCorreo.Text + "')");
            if (f == true)
            {
                MessageBox.Show("Datos insertados", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al insertar", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarTelefono(string telefono)
        {
            if (telefono.Length != 10)
            {
                return false;
            }

            foreach (char c in telefono)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private bool ValidarCorreo(string correo)
        {
            if (string.IsNullOrWhiteSpace(correo))
            {
                return false;
            }

            int arrobaIndex = correo.IndexOf('@');
            if (arrobaIndex <= 0 || arrobaIndex == correo.Length - 1)
            {
                return false;
            }

            int puntoIndex = correo.LastIndexOf('.');
            if (puntoIndex <= arrobaIndex + 1 || puntoIndex == correo.Length - 1)
            {
                return false;
            }
            return true;
        }
    }
}
