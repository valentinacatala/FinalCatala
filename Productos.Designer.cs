namespace FinalCatala
{
    partial class Productos
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
            this.tbProductos = new System.Windows.Forms.TabControl();
            this.tbCarga = new System.Windows.Forms.TabPage();
            this.btnCargar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.tbConsultar = new System.Windows.Forms.TabPage();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProductos.SuspendLayout();
            this.tbCarga.SuspendLayout();
            this.tbConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // tbProductos
            // 
            this.tbProductos.Controls.Add(this.tbCarga);
            this.tbProductos.Controls.Add(this.tbConsultar);
            this.tbProductos.Location = new System.Drawing.Point(12, 12);
            this.tbProductos.Name = "tbProductos";
            this.tbProductos.SelectedIndex = 0;
            this.tbProductos.Size = new System.Drawing.Size(427, 316);
            this.tbProductos.TabIndex = 0;
            // 
            // tbCarga
            // 
            this.tbCarga.Controls.Add(this.btnCargar);
            this.tbCarga.Controls.Add(this.dtpFecha);
            this.tbCarga.Controls.Add(this.txtNombre);
            this.tbCarga.Controls.Add(this.txtId);
            this.tbCarga.Controls.Add(this.lblFecha);
            this.tbCarga.Controls.Add(this.lblNombre);
            this.tbCarga.Controls.Add(this.lblId);
            this.tbCarga.Location = new System.Drawing.Point(4, 22);
            this.tbCarga.Name = "tbCarga";
            this.tbCarga.Padding = new System.Windows.Forms.Padding(3);
            this.tbCarga.Size = new System.Drawing.Size(419, 290);
            this.tbCarga.TabIndex = 0;
            this.tbCarga.Text = "Cargar";
            this.tbCarga.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(221, 209);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(136, 134);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(101, 20);
            this.dtpFecha.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(74, 91);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(139, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(65, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(23, 141);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(94, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha de Registro";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 91);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(23, 38);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // tbConsultar
            // 
            this.tbConsultar.Controls.Add(this.btnConsultar);
            this.tbConsultar.Controls.Add(this.dgvProducto);
            this.tbConsultar.Controls.Add(this.txtConsulta);
            this.tbConsultar.Controls.Add(this.label1);
            this.tbConsultar.Location = new System.Drawing.Point(4, 22);
            this.tbConsultar.Name = "tbConsultar";
            this.tbConsultar.Padding = new System.Windows.Forms.Padding(3);
            this.tbConsultar.Size = new System.Drawing.Size(419, 290);
            this.tbConsultar.TabIndex = 1;
            this.tbConsultar.Text = "Consultar";
            this.tbConsultar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(304, 23);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvProducto
            // 
            this.dgvProducto.AllowUserToAddRows = false;
            this.dgvProducto.AllowUserToDeleteRows = false;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Fecha});
            this.dgvProducto.Location = new System.Drawing.Point(14, 68);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            this.dgvProducto.Size = new System.Drawing.Size(394, 213);
            this.dgvProducto.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha de Registro";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(102, 25);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(147, 20);
            this.txtConsulta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar Nombre";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 339);
            this.Controls.Add(this.tbProductos);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.tbProductos.ResumeLayout(false);
            this.tbCarga.ResumeLayout(false);
            this.tbCarga.PerformLayout();
            this.tbConsultar.ResumeLayout(false);
            this.tbConsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbProductos;
        private System.Windows.Forms.TabPage tbCarga;
        private System.Windows.Forms.TabPage tbConsultar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnConsultar;
    }
}