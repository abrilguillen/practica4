namespace _Formulario
{
    partial class frmInventario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscarXNombre = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtPosicion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdInsertar = new System.Windows.Forms.Button();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cmdReporte = new System.Windows.Forms.Button();
            this.txtReporte = new System.Windows.Forms.TextBox();
            this.cmdAgregarInicio = new System.Windows.Forms.Button();
            this.cmdEliminarInicio = new System.Windows.Forms.Button();
            this.cmdEliminarUltimo = new System.Windows.Forms.Button();
            this.cmdReporteInverso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Posicion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "$";
            // 
            // txtBuscarXNombre
            // 
            this.txtBuscarXNombre.Location = new System.Drawing.Point(111, 362);
            this.txtBuscarXNombre.Name = "txtBuscarXNombre";
            this.txtBuscarXNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarXNombre.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(133, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(133, 79);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 7;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(133, 105);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 8;
            // 
            // txtPosicion
            // 
            this.txtPosicion.Location = new System.Drawing.Point(217, 276);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(100, 20);
            this.txtPosicion.TabIndex = 9;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(133, 27);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 10;
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(12, 207);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(75, 23);
            this.cmdAgregar.TabIndex = 11;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(12, 236);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(75, 23);
            this.cmdEliminar.TabIndex = 12;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdInsertar
            // 
            this.cmdInsertar.Location = new System.Drawing.Point(12, 274);
            this.cmdInsertar.Name = "cmdInsertar";
            this.cmdInsertar.Size = new System.Drawing.Size(75, 23);
            this.cmdInsertar.TabIndex = 13;
            this.cmdInsertar.Text = "Insertar";
            this.cmdInsertar.UseVisualStyleBackColor = true;
            this.cmdInsertar.Click += new System.EventHandler(this.cmdInsertar_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(12, 362);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(75, 23);
            this.cmdBuscar.TabIndex = 14;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cmdReporte
            // 
            this.cmdReporte.Location = new System.Drawing.Point(353, 447);
            this.cmdReporte.Name = "cmdReporte";
            this.cmdReporte.Size = new System.Drawing.Size(75, 23);
            this.cmdReporte.TabIndex = 15;
            this.cmdReporte.Text = "Reporte";
            this.cmdReporte.UseVisualStyleBackColor = true;
            this.cmdReporte.Click += new System.EventHandler(this.cmdReporte_Click);
            // 
            // txtReporte
            // 
            this.txtReporte.Location = new System.Drawing.Point(353, 12);
            this.txtReporte.Multiline = true;
            this.txtReporte.Name = "txtReporte";
            this.txtReporte.Size = new System.Drawing.Size(356, 429);
            this.txtReporte.TabIndex = 16;
            // 
            // cmdAgregarInicio
            // 
            this.cmdAgregarInicio.Location = new System.Drawing.Point(111, 207);
            this.cmdAgregarInicio.Name = "cmdAgregarInicio";
            this.cmdAgregarInicio.Size = new System.Drawing.Size(100, 23);
            this.cmdAgregarInicio.TabIndex = 17;
            this.cmdAgregarInicio.Text = "Agregar al inicio";
            this.cmdAgregarInicio.UseVisualStyleBackColor = true;
            this.cmdAgregarInicio.Click += new System.EventHandler(this.cmdAgregarInicio_Click);
            // 
            // cmdEliminarInicio
            // 
            this.cmdEliminarInicio.Location = new System.Drawing.Point(111, 236);
            this.cmdEliminarInicio.Name = "cmdEliminarInicio";
            this.cmdEliminarInicio.Size = new System.Drawing.Size(100, 23);
            this.cmdEliminarInicio.TabIndex = 18;
            this.cmdEliminarInicio.Text = "Eliminar Inicio";
            this.cmdEliminarInicio.UseVisualStyleBackColor = true;
            this.cmdEliminarInicio.Click += new System.EventHandler(this.cmdEliminarInicio_Click);
            // 
            // cmdEliminarUltimo
            // 
            this.cmdEliminarUltimo.Location = new System.Drawing.Point(231, 236);
            this.cmdEliminarUltimo.Name = "cmdEliminarUltimo";
            this.cmdEliminarUltimo.Size = new System.Drawing.Size(86, 23);
            this.cmdEliminarUltimo.TabIndex = 19;
            this.cmdEliminarUltimo.Text = "Eliminar Ultimo";
            this.cmdEliminarUltimo.UseVisualStyleBackColor = true;
            this.cmdEliminarUltimo.Click += new System.EventHandler(this.cmdEliminarUltimo_Click);
            // 
            // cmdReporteInverso
            // 
            this.cmdReporteInverso.Location = new System.Drawing.Point(453, 447);
            this.cmdReporteInverso.Name = "cmdReporteInverso";
            this.cmdReporteInverso.Size = new System.Drawing.Size(98, 23);
            this.cmdReporteInverso.TabIndex = 20;
            this.cmdReporteInverso.Text = "Reporte Inverso";
            this.cmdReporteInverso.UseVisualStyleBackColor = true;
            this.cmdReporteInverso.Click += new System.EventHandler(this.cmdReporteInverso_Click);
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 493);
            this.Controls.Add(this.cmdReporteInverso);
            this.Controls.Add(this.cmdEliminarUltimo);
            this.Controls.Add(this.cmdEliminarInicio);
            this.Controls.Add(this.cmdAgregarInicio);
            this.Controls.Add(this.txtReporte);
            this.Controls.Add(this.cmdReporte);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.cmdInsertar);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtPosicion);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtBuscarXNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmInventario";
            this.Text = "Listas dobles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscarXNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtPosicion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdInsertar;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Button cmdReporte;
        private System.Windows.Forms.TextBox txtReporte;
        private System.Windows.Forms.Button cmdAgregarInicio;
        private System.Windows.Forms.Button cmdEliminarInicio;
        private System.Windows.Forms.Button cmdEliminarUltimo;
        private System.Windows.Forms.Button cmdReporteInverso;
    }
}

