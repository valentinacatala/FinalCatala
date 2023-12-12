namespace FinalCatala
{
    partial class Consulta
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
            this.rbProductos = new System.Windows.Forms.RadioButton();
            this.rbVentas = new System.Windows.Forms.RadioButton();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.btnConsular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // rbProductos
            // 
            this.rbProductos.AutoSize = true;
            this.rbProductos.Location = new System.Drawing.Point(63, 29);
            this.rbProductos.Name = "rbProductos";
            this.rbProductos.Size = new System.Drawing.Size(73, 17);
            this.rbProductos.TabIndex = 0;
            this.rbProductos.TabStop = true;
            this.rbProductos.Text = "Productos";
            this.rbProductos.UseVisualStyleBackColor = true;
            // 
            // rbVentas
            // 
            this.rbVentas.AutoSize = true;
            this.rbVentas.Location = new System.Drawing.Point(182, 29);
            this.rbVentas.Name = "rbVentas";
            this.rbVentas.Size = new System.Drawing.Size(58, 17);
            this.rbVentas.TabIndex = 1;
            this.rbVentas.TabStop = true;
            this.rbVentas.Text = "Ventas";
            this.rbVentas.UseVisualStyleBackColor = true;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(21, 72);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.Size = new System.Drawing.Size(459, 232);
            this.dgvConsulta.TabIndex = 2;
            // 
            // btnConsular
            // 
            this.btnConsular.Location = new System.Drawing.Point(358, 26);
            this.btnConsular.Name = "btnConsular";
            this.btnConsular.Size = new System.Drawing.Size(75, 23);
            this.btnConsular.TabIndex = 3;
            this.btnConsular.Text = "Consultar";
            this.btnConsular.UseVisualStyleBackColor = true;
            this.btnConsular.Click += new System.EventHandler(this.btnConsular_Click);
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 316);
            this.Controls.Add(this.btnConsular);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.rbVentas);
            this.Controls.Add(this.rbProductos);
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbProductos;
        private System.Windows.Forms.RadioButton rbVentas;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button btnConsular;
    }
}