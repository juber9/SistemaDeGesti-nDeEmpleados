namespace SistemaDeGestiónDeEmpleados
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpFechaDeRegistro = new DateTimePicker();
            txtIngresarDepartamento = new TextBox();
            txtIngresarRol = new TextBox();
            btnMostrarEmpleados = new Button();
            btnAgregarEmpleados = new Button();
            label5 = new Label();
            txtIngresarNombre = new TextBox();
            lstMostrarDescripcion = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(378, 22);
            label1.Name = "label1";
            label1.Size = new Size(400, 27);
            label1.TabIndex = 0;
            label1.Text = "Sistema de gestión de empleados";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtIngresarNombre);
            groupBox1.Controls.Add(txtIngresarRol);
            groupBox1.Controls.Add(txtIngresarDepartamento);
            groupBox1.Controls.Add(dtpFechaDeRegistro);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(77, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1022, 225);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 40);
            label2.Name = "label2";
            label2.Size = new Size(171, 28);
            label2.TabIndex = 0;
            label2.Text = "Fecha de registro: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 123);
            label3.Name = "label3";
            label3.Size = new Size(160, 28);
            label3.TabIndex = 0;
            label3.Text = "Ingresar nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(148, 78);
            label4.Name = "label4";
            label4.Size = new Size(216, 28);
            label4.TabIndex = 0;
            label4.Text = "Ingresar departamento:";
            // 
            // dtpFechaDeRegistro
            // 
            dtpFechaDeRegistro.Location = new Point(481, 35);
            dtpFechaDeRegistro.Name = "dtpFechaDeRegistro";
            dtpFechaDeRegistro.Size = new Size(371, 34);
            dtpFechaDeRegistro.TabIndex = 1;
            // 
            // txtIngresarDepartamento
            // 
            txtIngresarDepartamento.Location = new Point(481, 78);
            txtIngresarDepartamento.Name = "txtIngresarDepartamento";
            txtIngresarDepartamento.Size = new Size(371, 34);
            txtIngresarDepartamento.TabIndex = 2;
            // 
            // txtIngresarRol
            // 
            txtIngresarRol.Location = new Point(481, 167);
            txtIngresarRol.Name = "txtIngresarRol";
            txtIngresarRol.Size = new Size(371, 34);
            txtIngresarRol.TabIndex = 2;
            // 
            // btnMostrarEmpleados
            // 
            btnMostrarEmpleados.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMostrarEmpleados.Location = new Point(218, 323);
            btnMostrarEmpleados.Name = "btnMostrarEmpleados";
            btnMostrarEmpleados.Size = new Size(223, 41);
            btnMostrarEmpleados.TabIndex = 2;
            btnMostrarEmpleados.Text = "Mostrar empleados";
            btnMostrarEmpleados.UseVisualStyleBackColor = true;
            // 
            // btnAgregarEmpleados
            // 
            btnAgregarEmpleados.Location = new Point(619, 324);
            btnAgregarEmpleados.Name = "btnAgregarEmpleados";
            btnAgregarEmpleados.Size = new Size(211, 41);
            btnAgregarEmpleados.TabIndex = 2;
            btnAgregarEmpleados.Text = "Agregar empleados";
            btnAgregarEmpleados.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(148, 170);
            label5.Name = "label5";
            label5.Size = new Size(115, 28);
            label5.TabIndex = 0;
            label5.Text = "Ingresar rol:";
            // 
            // txtIngresarNombre
            // 
            txtIngresarNombre.Location = new Point(481, 120);
            txtIngresarNombre.Name = "txtIngresarNombre";
            txtIngresarNombre.Size = new Size(371, 34);
            txtIngresarNombre.TabIndex = 2;
            // 
            // lstMostrarDescripcion
            // 
            lstMostrarDescripcion.FormattingEnabled = true;
            lstMostrarDescripcion.Location = new Point(77, 399);
            lstMostrarDescripcion.Name = "lstMostrarDescripcion";
            lstMostrarDescripcion.Size = new Size(1022, 144);
            lstMostrarDescripcion.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 555);
            Controls.Add(lstMostrarDescripcion);
            Controls.Add(btnAgregarEmpleados);
            Controls.Add(btnMostrarEmpleados);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtIngresarRol;
        private TextBox txtIngresarDepartamento;
        private DateTimePicker dtpFechaDeRegistro;
        private Button btnMostrarEmpleados;
        private Button btnAgregarEmpleados;
        private TextBox txtIngresarNombre;
        private Label label5;
        private ListBox lstMostrarDescripcion;
    }
}
