namespace Tema7FP
{
    partial class frmGestionEstudiante
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
            this.dgvListaCarreras = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCarreras)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaCarreras
            // 
            this.dgvListaCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCarreras.Location = new System.Drawing.Point(24, 201);
            this.dgvListaCarreras.Name = "dgvListaCarreras";
            this.dgvListaCarreras.RowHeadersWidth = 51;
            this.dgvListaCarreras.RowTemplate.Height = 24;
            this.dgvListaCarreras.Size = new System.Drawing.Size(876, 230);
            this.dgvListaCarreras.TabIndex = 0;
            // 
            // frmGestionEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 455);
            this.Controls.Add(this.dgvListaCarreras);
            this.Name = "frmGestionEstudiante";
            this.Text = "Sistema Educativo - Gestionando Estudiantes";
            this.Load += new System.EventHandler(this.frmGestionEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCarreras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaCarreras;
    }
}

