
namespace PepitoSchool
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
            this.txtNombres = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblCarnet = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblMatematica = new System.Windows.Forms.Label();
            this.lblEstadistica = new System.Windows.Forms.Label();
            this.lblProgramacion = new System.Windows.Forms.Label();
            this.lblContabilidad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.nudProgramacion = new System.Windows.Forms.NumericUpDown();
            this.nudContabilidad = new System.Windows.Forms.NumericUpDown();
            this.nudEstadistica = new System.Windows.Forms.NumericUpDown();
            this.nudMatematica = new System.Windows.Forms.NumericUpDown();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudProgramacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudContabilidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstadistica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatematica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombres
            // 
            this.txtNombres.AutoSize = true;
            this.txtNombres.Location = new System.Drawing.Point(8, 19);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(77, 20);
            this.txtNombres.TabIndex = 0;
            this.txtNombres.Text = "Nombres: ";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(241, 19);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(75, 20);
            this.lblApellidos.TabIndex = 1;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblCarnet
            // 
            this.lblCarnet.AutoSize = true;
            this.lblCarnet.Location = new System.Drawing.Point(472, 19);
            this.lblCarnet.Name = "lblCarnet";
            this.lblCarnet.Size = new System.Drawing.Size(55, 20);
            this.lblCarnet.TabIndex = 2;
            this.lblCarnet.Text = "Carnet:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(681, 19);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(70, 20);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Telefono:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(909, 19);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(57, 20);
            this.lblCorreo.TabIndex = 4;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(8, 87);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 20);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblMatematica
            // 
            this.lblMatematica.AutoSize = true;
            this.lblMatematica.Location = new System.Drawing.Point(356, 157);
            this.lblMatematica.Name = "lblMatematica";
            this.lblMatematica.Size = new System.Drawing.Size(149, 20);
            this.lblMatematica.TabIndex = 6;
            this.lblMatematica.Text = "Nota de matematica:";
            // 
            // lblEstadistica
            // 
            this.lblEstadistica.AutoSize = true;
            this.lblEstadistica.Location = new System.Drawing.Point(8, 157);
            this.lblEstadistica.Name = "lblEstadistica";
            this.lblEstadistica.Size = new System.Drawing.Size(140, 20);
            this.lblEstadistica.TabIndex = 7;
            this.lblEstadistica.Text = "Nota de estadistica:";
            // 
            // lblProgramacion
            // 
            this.lblProgramacion.AutoSize = true;
            this.lblProgramacion.Location = new System.Drawing.Point(241, 87);
            this.lblProgramacion.Name = "lblProgramacion";
            this.lblProgramacion.Size = new System.Drawing.Size(164, 20);
            this.lblProgramacion.TabIndex = 8;
            this.lblProgramacion.Text = "Nota de programacion:";
            // 
            // lblContabilidad
            // 
            this.lblContabilidad.AutoSize = true;
            this.lblContabilidad.Location = new System.Drawing.Point(581, 86);
            this.lblContabilidad.Name = "lblContabilidad";
            this.lblContabilidad.Size = new System.Drawing.Size(154, 20);
            this.lblContabilidad.TabIndex = 9;
            this.lblContabilidad.Text = "Nota de contabilidad:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(89, 16);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(125, 27);
            this.txtNombre.TabIndex = 10;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(322, 16);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(125, 27);
            this.txtApellidos.TabIndex = 11;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(757, 16);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(125, 27);
            this.txtTelefono.TabIndex = 12;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(89, 84);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(125, 34);
            this.txtDireccion.TabIndex = 13;
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(533, 16);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(125, 27);
            this.txtCarnet.TabIndex = 14;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(972, 16);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(125, 27);
            this.txtCorreo.TabIndex = 15;
            // 
            // nudProgramacion
            // 
            this.nudProgramacion.Location = new System.Drawing.Point(411, 84);
            this.nudProgramacion.Name = "nudProgramacion";
            this.nudProgramacion.Size = new System.Drawing.Size(150, 27);
            this.nudProgramacion.TabIndex = 16;
            // 
            // nudContabilidad
            // 
            this.nudContabilidad.Location = new System.Drawing.Point(741, 84);
            this.nudContabilidad.Name = "nudContabilidad";
            this.nudContabilidad.Size = new System.Drawing.Size(150, 27);
            this.nudContabilidad.TabIndex = 17;
            // 
            // nudEstadistica
            // 
            this.nudEstadistica.Location = new System.Drawing.Point(166, 155);
            this.nudEstadistica.Name = "nudEstadistica";
            this.nudEstadistica.Size = new System.Drawing.Size(150, 27);
            this.nudEstadistica.TabIndex = 18;
            // 
            // nudMatematica
            // 
            this.nudMatematica.Location = new System.Drawing.Point(511, 157);
            this.nudMatematica.Name = "nudMatematica";
            this.nudMatematica.Size = new System.Drawing.Size(150, 27);
            this.nudMatematica.TabIndex = 19;
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Location = new System.Drawing.Point(8, 287);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.RowHeadersWidth = 51;
            this.dgvEstudiantes.RowTemplate.Height = 29;
            this.dgvEstudiantes.Size = new System.Drawing.Size(1120, 222);
            this.dgvEstudiantes.TabIndex = 20;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(77, 230);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 29);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(177, 230);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 29);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(277, 230);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(94, 29);
            this.btnActualizar.TabIndex = 23;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 521);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvEstudiantes);
            this.Controls.Add(this.nudMatematica);
            this.Controls.Add(this.nudEstadistica);
            this.Controls.Add(this.nudContabilidad);
            this.Controls.Add(this.nudProgramacion);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtCarnet);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblContabilidad);
            this.Controls.Add(this.lblProgramacion);
            this.Controls.Add(this.lblEstadistica);
            this.Controls.Add(this.lblMatematica);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblCarnet);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.txtNombres);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudProgramacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudContabilidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstadistica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatematica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblCarnet;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblMatematica;
        private System.Windows.Forms.Label lblEstadistica;
        private System.Windows.Forms.Label lblProgramacion;
        private System.Windows.Forms.Label lblContabilidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.NumericUpDown nudProgramacion;
        private System.Windows.Forms.NumericUpDown nudContabilidad;
        private System.Windows.Forms.NumericUpDown nudEstadistica;
        private System.Windows.Forms.NumericUpDown nudMatematica;
        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
    }
}

