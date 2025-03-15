using System.Data;

namespace ExamenUnidad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmInsertarUsuario frmInsertarUsuario = new frmInsertarUsuario();
            frmInsertarUsuario.Show();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmActualizarUsuario actualizarUsuario = new frmActualizarUsuario(
                dgvUsuarios[0, e.RowIndex].Value.ToString(),
                dgvUsuarios[1, e.RowIndex].Value.ToString(),
                dgvUsuarios[2, e.RowIndex].Value.ToString(),
                dgvUsuarios[3, e.RowIndex].Value.ToString(),
                dgvUsuarios[4, e.RowIndex].Value.ToString(),
                dgvUsuarios[5, e.RowIndex].Value.ToString());
            actualizarUsuario.Show();
        }
        private void ActualizaGrid()
        {
            Datos obj = new Datos();
            DataSet ds = obj.consulta("SELECT ID AS ID, APATERNO AS [Ap. paterno], AMATERNO AS [Ap. materno], NOMBRE AS Nombre, TELEFONO AS Teléfono, CORREO AS Correo FROM Usuarios");
            if (ds != null)
            {
                dgvUsuarios.DataSource = ds.Tables[0];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizaGrid();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            ActualizaGrid();
        }
    }
}
