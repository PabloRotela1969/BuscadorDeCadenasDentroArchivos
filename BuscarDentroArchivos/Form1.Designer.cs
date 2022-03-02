namespace BuscarDentroArchivos
{
    partial class frmBusqueda
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTextoABuscar = new System.Windows.Forms.TextBox();
            this.lblTextoABuscar = new System.Windows.Forms.Label();
            this.btnSeleccioneCarpetaInicial = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblArchivos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTextoABuscar
            // 
            this.txtTextoABuscar.Location = new System.Drawing.Point(208, 29);
            this.txtTextoABuscar.Name = "txtTextoABuscar";
            this.txtTextoABuscar.Size = new System.Drawing.Size(598, 20);
            this.txtTextoABuscar.TabIndex = 0;
            this.txtTextoABuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTextoABuscar_KeyPress);
            // 
            // lblTextoABuscar
            // 
            this.lblTextoABuscar.AutoSize = true;
            this.lblTextoABuscar.Location = new System.Drawing.Point(210, 8);
            this.lblTextoABuscar.Name = "lblTextoABuscar";
            this.lblTextoABuscar.Size = new System.Drawing.Size(199, 13);
            this.lblTextoABuscar.TabIndex = 1;
            this.lblTextoABuscar.Text = "Ingrese el texto a buscar y pulse ENTER";
            // 
            // btnSeleccioneCarpetaInicial
            // 
            this.btnSeleccioneCarpetaInicial.Location = new System.Drawing.Point(17, 24);
            this.btnSeleccioneCarpetaInicial.Name = "btnSeleccioneCarpetaInicial";
            this.btnSeleccioneCarpetaInicial.Size = new System.Drawing.Size(175, 25);
            this.btnSeleccioneCarpetaInicial.TabIndex = 2;
            this.btnSeleccioneCarpetaInicial.Text = "Seleccione carpeta inicial";
            this.btnSeleccioneCarpetaInicial.UseVisualStyleBackColor = true;
            this.btnSeleccioneCarpetaInicial.Click += new System.EventHandler(this.btnSeleccioneCarpetaInicial_Click);
            // 
            // dgvResultados
            // 
            this.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(17, 78);
            this.dgvResultados.MultiSelect = false;
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(789, 406);
            this.dgvResultados.TabIndex = 3;
            this.dgvResultados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultados_CellClick);
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Location = new System.Drawing.Point(706, 8);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(0, 13);
            this.lblhora.TabIndex = 4;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(732, 495);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 5;
            // 
            // lblArchivos
            // 
            this.lblArchivos.AutoSize = true;
            this.lblArchivos.Location = new System.Drawing.Point(14, 52);
            this.lblArchivos.Name = "lblArchivos";
            this.lblArchivos.Size = new System.Drawing.Size(0, 13);
            this.lblArchivos.TabIndex = 6;
            this.lblArchivos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 507);
            this.Controls.Add(this.lblArchivos);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.btnSeleccioneCarpetaInicial);
            this.Controls.Add(this.lblTextoABuscar);
            this.Controls.Add(this.txtTextoABuscar);
            this.Name = "frmBusqueda";
            this.Text = "BUSQUEDA DE CONTENIDO EN ARCHIVOS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextoABuscar;
        private System.Windows.Forms.Label lblTextoABuscar;
        private System.Windows.Forms.Button btnSeleccioneCarpetaInicial;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblArchivos;
    }
}

