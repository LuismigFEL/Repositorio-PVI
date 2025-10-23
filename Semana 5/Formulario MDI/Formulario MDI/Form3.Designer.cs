namespace Formulario_MDI
{
    partial class Form3
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
            this.DGVDatos = new System.Windows.Forms.DataGridView();
            this.CarnetDTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsignaturaDTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotaDTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVDatos
            // 
            this.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarnetDTG,
            this.NombreDTG,
            this.AsignaturaDTG,
            this.NotaDTG});
            this.DGVDatos.Location = new System.Drawing.Point(99, 148);
            this.DGVDatos.Name = "DGVDatos";
            this.DGVDatos.RowHeadersWidth = 51;
            this.DGVDatos.RowTemplate.Height = 24;
            this.DGVDatos.Size = new System.Drawing.Size(552, 242);
            this.DGVDatos.TabIndex = 2;
            // 
            // CarnetDTG
            // 
            this.CarnetDTG.HeaderText = "Carnet";
            this.CarnetDTG.MinimumWidth = 6;
            this.CarnetDTG.Name = "CarnetDTG";
            this.CarnetDTG.Width = 125;
            // 
            // NombreDTG
            // 
            this.NombreDTG.HeaderText = "Nombre";
            this.NombreDTG.MinimumWidth = 6;
            this.NombreDTG.Name = "NombreDTG";
            this.NombreDTG.Width = 125;
            // 
            // AsignaturaDTG
            // 
            this.AsignaturaDTG.HeaderText = "Asignatura";
            this.AsignaturaDTG.MinimumWidth = 6;
            this.AsignaturaDTG.Name = "AsignaturaDTG";
            this.AsignaturaDTG.Width = 125;
            // 
            // NotaDTG
            // 
            this.NotaDTG.HeaderText = "Nota";
            this.NotaDTG.MinimumWidth = 6;
            this.NotaDTG.Name = "NotaDTG";
            this.NotaDTG.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(258, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista de Estudiantes";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVDatos);
            this.Name = "Form3";
            this.Text = "Ver Estudiante";
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn AsignaturaDTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotaDTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarnetDTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDTG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVDatos;
    }
}