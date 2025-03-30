namespace Ejercicio01
{
    partial class frmEmpleado
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
            this.lbl_Legajo = new System.Windows.Forms.Label();
            this.txt_Legajo = new System.Windows.Forms.TextBox();
            this.dtp_FechaNac = new System.Windows.Forms.DateTimePicker();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_FechNac = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.dtp_FechDeIng = new System.Windows.Forms.DateTimePicker();
            this.lblFechadeIn = new System.Windows.Forms.Label();
            this.ListarEmpleados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_Legajo
            // 
            this.lbl_Legajo.AutoSize = true;
            this.lbl_Legajo.Location = new System.Drawing.Point(271, 193);
            this.lbl_Legajo.Name = "lbl_Legajo";
            this.lbl_Legajo.Size = new System.Drawing.Size(39, 13);
            this.lbl_Legajo.TabIndex = 17;
            this.lbl_Legajo.Text = "Legajo";
            // 
            // txt_Legajo
            // 
            this.txt_Legajo.Location = new System.Drawing.Point(320, 190);
            this.txt_Legajo.Name = "txt_Legajo";
            this.txt_Legajo.Size = new System.Drawing.Size(100, 20);
            this.txt_Legajo.TabIndex = 16;
            // 
            // dtp_FechaNac
            // 
            this.dtp_FechaNac.Location = new System.Drawing.Point(320, 138);
            this.dtp_FechaNac.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_FechaNac.Name = "dtp_FechaNac";
            this.dtp_FechaNac.Size = new System.Drawing.Size(135, 20);
            this.dtp_FechaNac.TabIndex = 15;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(320, 109);
            this.txt_Apellido.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(68, 20);
            this.txt_Apellido.TabIndex = 14;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(320, 83);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(68, 20);
            this.txt_Nombre.TabIndex = 13;
            // 
            // lbl_FechNac
            // 
            this.lbl_FechNac.AutoSize = true;
            this.lbl_FechNac.Location = new System.Drawing.Point(205, 142);
            this.lbl_FechNac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_FechNac.Name = "lbl_FechNac";
            this.lbl_FechNac.Size = new System.Drawing.Size(108, 13);
            this.lbl_FechNac.TabIndex = 12;
            this.lbl_FechNac.Text = "Fecha de Nacimiento";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(267, 115);
            this.lbl_Apellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_Apellido.TabIndex = 11;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(267, 87);
            this.lbl_Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 10;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(338, 252);
            this.btn1.Margin = new System.Windows.Forms.Padding(2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(82, 20);
            this.btn1.TabIndex = 9;
            this.btn1.Text = "Ejecutar";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // dtp_FechDeIng
            // 
            this.dtp_FechDeIng.Location = new System.Drawing.Point(320, 162);
            this.dtp_FechDeIng.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_FechDeIng.Name = "dtp_FechDeIng";
            this.dtp_FechDeIng.Size = new System.Drawing.Size(135, 20);
            this.dtp_FechDeIng.TabIndex = 19;
            // 
            // lblFechadeIn
            // 
            this.lblFechadeIn.AutoSize = true;
            this.lblFechadeIn.Location = new System.Drawing.Point(223, 166);
            this.lblFechadeIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechadeIn.Name = "lblFechadeIn";
            this.lblFechadeIn.Size = new System.Drawing.Size(90, 13);
            this.lblFechadeIn.TabIndex = 18;
            this.lblFechadeIn.Text = "Fecha de Ingreso";
            // 
            // ListarEmpleados
            // 
            this.ListarEmpleados.FormattingEnabled = true;
            this.ListarEmpleados.Location = new System.Drawing.Point(578, 299);
            this.ListarEmpleados.Name = "ListarEmpleados";
            this.ListarEmpleados.Size = new System.Drawing.Size(120, 95);
            this.ListarEmpleados.TabIndex = 20;
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListarEmpleados);
            this.Controls.Add(this.dtp_FechDeIng);
            this.Controls.Add(this.lblFechadeIn);
            this.Controls.Add(this.lbl_Legajo);
            this.Controls.Add(this.txt_Legajo);
            this.Controls.Add(this.dtp_FechaNac);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_FechNac);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.btn1);
            this.Name = "frmEmpleado";
            this.Text = "Empleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Legajo;
        private System.Windows.Forms.TextBox txt_Legajo;
        private System.Windows.Forms.DateTimePicker dtp_FechaNac;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_FechNac;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.DateTimePicker dtp_FechDeIng;
        private System.Windows.Forms.Label lblFechadeIn;
        private System.Windows.Forms.ListBox ListarEmpleados;
    }
}