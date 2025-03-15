namespace ExamenUnidad2
{
    partial class frmInsertarUsuario
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
            btnInsertar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 41);
            label1.Name = "label1";
            label1.Size = new Size(198, 45);
            label1.TabIndex = 0;
            label1.Text = "Ap. Paterno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(287, 41);
            label2.Name = "label2";
            label2.Size = new Size(210, 45);
            label2.TabIndex = 1;
            label2.Text = "Ap. Materno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(568, 41);
            label3.Name = "label3";
            label3.Size = new Size(144, 45);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label4.Location = new Point(178, 233);
            label4.Name = "label4";
            label4.Size = new Size(150, 45);
            label4.TabIndex = 3;
            label4.Text = "Teléfono";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label5.Location = new Point(446, 233);
            label5.Name = "label5";
            label5.Size = new Size(123, 45);
            label5.TabIndex = 4;
            label5.Text = "Correo";
            // 
            // txtAPaterno
            // 
            txtAPaterno.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAPaterno.Location = new Point(54, 95);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.Size = new Size(150, 45);
            txtAPaterno.TabIndex = 5;
            // 
            // txtAMaterno
            // 
            txtAMaterno.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAMaterno.Location = new Point(309, 95);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.Size = new Size(150, 45);
            txtAMaterno.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(562, 95);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 45);
            txtNombre.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 14F);
            txtTelefono.Location = new Point(178, 286);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 45);
            txtTelefono.TabIndex = 8;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 14F);
            txtCorreo.Location = new Point(446, 286);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(266, 45);
            txtCorreo.TabIndex = 9;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.Lime;
            btnInsertar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertar.ForeColor = SystemColors.Control;
            btnInsertar.Location = new Point(446, 367);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(148, 56);
            btnInsertar.TabIndex = 10;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.Control;
            btnCancelar.Location = new Point(631, 367);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(146, 56);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmInsertarUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnInsertar);
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
            Name = "frmInsertarUsuario";
            Text = "Insertar usuario";
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
        private Button btnInsertar;
        private Button btnCancelar;
    }
}