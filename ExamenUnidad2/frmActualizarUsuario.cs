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
    public partial class frmActualizarUsuario : Form
    {
        public frmActualizarUsuario(string id, string apaterno, string amaterno, string nombre, string telefono, string correo)
        {
            InitializeComponent();
            txtAPaterno.Text = apaterno;
            txtAMaterno.Text = amaterno;
            txtNombre.Text = nombre;
            txtTelefono.Text = telefono;
            txtCorreo.Text = correo;
            txtId.Text = id;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
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
            bool f = datos.comando("UPDATE Usuarios SET " +
                "APATERNO='" + txtAPaterno.Text +
                "', AMATERNO='" + txtAMaterno.Text +
                "', NOMBRE='" + txtNombre.Text +
                "', TELEFONO='" + txtTelefono.Text +
                "', CORREO='" + txtCorreo.Text + "' WHERE ID = '" + txtId.Text + "'");

            if (f)
            {
                MessageBox.Show("Datos Actualizados", "Sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al actualizar", "Sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Estás seguro de eliminar el registro?",
                "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Datos datos = new Datos();
                bool f = datos.comando("delete from Usuarios where ID='" + txtId.Text + "'");
                if (f)
                {
                    MessageBox.Show("Datos Eliminados", "Sistema", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar", "Sistema");
                }
            }
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
