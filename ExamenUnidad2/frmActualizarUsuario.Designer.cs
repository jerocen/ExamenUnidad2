namespace ExamenUnidad2
{
    partial class frmActualizarUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAPaterno = new TextBox();
            txtAMaterno = new TextBox();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            txtId = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(163, 18);
            label1.Name = "label1";
            label1.Size = new Size(172, 38);
            label1.TabIndex = 0;
            label1.Text = "Ap. Paterno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(370, 18);
            label2.Name = "label2";
            label2.Size = new Size(183, 38);
            label2.TabIndex = 1;
            label2.Text = "Ap. Materno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(603, 18);
            label3.Name = "label3";
            label3.Size = new Size(125, 38);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(186, 203);
            label4.Name = "label4";
            label4.Size = new Size(130, 38);
            label4.TabIndex = 3;
            label4.Text = "Teléfono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.Location = new Point(480, 203);
            label5.Name = "label5";
            label5.Size = new Size(105, 38);
            label5.TabIndex = 4;
            label5.Text = "Correo";
            // 
            // txtAPaterno
            // 
            txtAPaterno.Font = new Font("Segoe UI", 14F);
            txtAPaterno.Location = new Point(175, 70);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.Size = new Size(150, 45);
            txtAPaterno.TabIndex = 5;
            // 
            // txtAMaterno
            // 
            txtAMaterno.Font = new Font("Segoe UI", 14F);
            txtAMaterno.Location = new Point(386, 70);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.Size = new Size(150, 45);
            txtAMaterno.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 14F);
            txtNombre.Location = new Point(603, 70);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 45);
            txtNombre.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 14F);
            txtTelefono.Location = new Point(175, 255);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 45);
            txtTelefono.TabIndex = 8;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 14F);
            txtCorreo.Location = new Point(480, 255);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(248, 45);
            txtCorreo.TabIndex = 9;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.Control;
            btnCancelar.Location = new Point(629, 373);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(149, 55);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnEliminar.ForeColor = SystemColors.Control;
            btnEliminar.Location = new Point(456, 373);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(144, 55);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Lime;
            btnActualizar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = SystemColors.Control;
            btnActualizar.Location = new Point(258, 373);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(166, 55);
            btnActualizar.TabIndex = 12;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 14F);
            txtId.Location = new Point(41, 70);
            txtId.Name = "txtId";
            txtId.Size = new Size(76, 45);
            txtId.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.Location = new Point(41, 18);
            label6.Name = "label6";
            label6.Size = new Size(47, 38);
            label6.TabIndex = 14;
            label6.Text = "ID";
            // 
            // frmActualizarUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(txtId);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(txtAMaterno);
            Controls.Add(txtAPaterno);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmActualizarUsuario";
            Text = "Actualizar usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtAPaterno;
        private TextBox txtAMaterno;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnActualizar;
        private TextBox txtId;
        private Label label6;
    }
}