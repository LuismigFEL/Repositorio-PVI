namespace VisorDeImagenes
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escalaDeGrisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tamanioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnTSMVisionNormal = new System.Windows.Forms.ToolStripButton();
            this.btnTSMVisionEscalaGrises = new System.Windows.Forms.ToolStripButton();
            this.btnTSMCentrar = new System.Windows.Forms.ToolStripButton();
            this.btnTSMAjustar = new System.Windows.Forms.ToolStripButton();
            this.btnTSMZoom = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSSlabelDireccion = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEscaladeGrises = new System.Windows.Forms.CheckBox();
            this.rbNormal = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbZoom = new System.Windows.Forms.RadioButton();
            this.rbAjustar = new System.Windows.Forms.RadioButton();
            this.rbCentrada = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.girarALaIzquierda90GradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girar90ALaDerechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbImagenes = new System.Windows.Forms.ComboBox();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.visionToolStripMenuItem,
            this.tamanioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // visionToolStripMenuItem
            // 
            this.visionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.escalaDeGrisesToolStripMenuItem});
            this.visionToolStripMenuItem.Name = "visionToolStripMenuItem";
            this.visionToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.visionToolStripMenuItem.Text = "Vision";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click_1);
            // 
            // escalaDeGrisesToolStripMenuItem
            // 
            this.escalaDeGrisesToolStripMenuItem.Name = "escalaDeGrisesToolStripMenuItem";
            this.escalaDeGrisesToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.escalaDeGrisesToolStripMenuItem.Text = "Escala de Grises";
            this.escalaDeGrisesToolStripMenuItem.Click += new System.EventHandler(this.escalaDeGrisesToolStripMenuItem_Click_1);
            // 
            // tamanioToolStripMenuItem
            // 
            this.tamanioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cenToolStripMenuItem,
            this.ajustarToolStripMenuItem,
            this.zoomToolStripMenuItem});
            this.tamanioToolStripMenuItem.Name = "tamanioToolStripMenuItem";
            this.tamanioToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.tamanioToolStripMenuItem.Text = "Tamaño";
            // 
            // cenToolStripMenuItem
            // 
            this.cenToolStripMenuItem.Name = "cenToolStripMenuItem";
            this.cenToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.cenToolStripMenuItem.Text = "Centrada";
            this.cenToolStripMenuItem.Click += new System.EventHandler(this.cenToolStripMenuItem_Click);
            // 
            // ajustarToolStripMenuItem
            // 
            this.ajustarToolStripMenuItem.Name = "ajustarToolStripMenuItem";
            this.ajustarToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.ajustarToolStripMenuItem.Text = "Ajustar";
            this.ajustarToolStripMenuItem.Click += new System.EventHandler(this.ajustarToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.zoomToolStripMenuItem.Text = "Zoom";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTSMVisionNormal,
            this.btnTSMVisionEscalaGrises,
            this.btnTSMCentrar,
            this.btnTSMAjustar,
            this.btnTSMZoom});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnTSMVisionNormal
            // 
            this.btnTSMVisionNormal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTSMVisionNormal.Image = ((System.Drawing.Image)(resources.GetObject("btnTSMVisionNormal.Image")));
            this.btnTSMVisionNormal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTSMVisionNormal.Name = "btnTSMVisionNormal";
            this.btnTSMVisionNormal.Size = new System.Drawing.Size(29, 24);
            this.btnTSMVisionNormal.Text = "Normal";
            this.btnTSMVisionNormal.Click += new System.EventHandler(this.btnTSMNormal_Click);
            // 
            // btnTSMVisionEscalaGrises
            // 
            this.btnTSMVisionEscalaGrises.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTSMVisionEscalaGrises.Image = ((System.Drawing.Image)(resources.GetObject("btnTSMVisionEscalaGrises.Image")));
            this.btnTSMVisionEscalaGrises.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTSMVisionEscalaGrises.Name = "btnTSMVisionEscalaGrises";
            this.btnTSMVisionEscalaGrises.Size = new System.Drawing.Size(29, 24);
            this.btnTSMVisionEscalaGrises.Text = "Escala de Grises";
            this.btnTSMVisionEscalaGrises.Click += new System.EventHandler(this.btnTSMVisionEscalaGrises_Click);
            // 
            // btnTSMCentrar
            // 
            this.btnTSMCentrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTSMCentrar.Image = ((System.Drawing.Image)(resources.GetObject("btnTSMCentrar.Image")));
            this.btnTSMCentrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTSMCentrar.Name = "btnTSMCentrar";
            this.btnTSMCentrar.Size = new System.Drawing.Size(29, 24);
            this.btnTSMCentrar.Text = "Centrar";
            this.btnTSMCentrar.Click += new System.EventHandler(this.btnTSMCentrar_Click);
            // 
            // btnTSMAjustar
            // 
            this.btnTSMAjustar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTSMAjustar.Image = ((System.Drawing.Image)(resources.GetObject("btnTSMAjustar.Image")));
            this.btnTSMAjustar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTSMAjustar.Name = "btnTSMAjustar";
            this.btnTSMAjustar.Size = new System.Drawing.Size(29, 24);
            this.btnTSMAjustar.Text = "Ajustar";
            this.btnTSMAjustar.Click += new System.EventHandler(this.btnTSMAjustar_Click);
            // 
            // btnTSMZoom
            // 
            this.btnTSMZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTSMZoom.Image = ((System.Drawing.Image)(resources.GetObject("btnTSMZoom.Image")));
            this.btnTSMZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTSMZoom.Name = "btnTSMZoom";
            this.btnTSMZoom.Size = new System.Drawing.Size(29, 24);
            this.btnTSMZoom.Text = "toolStripButton5";
            this.btnTSMZoom.Click += new System.EventHandler(this.btnTSMZoom_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSlabelDireccion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSSlabelDireccion
            // 
            this.TSSlabelDireccion.Name = "TSSlabelDireccion";
            this.TSSlabelDireccion.Size = new System.Drawing.Size(0, 16);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEscaladeGrises);
            this.groupBox1.Controls.Add(this.rbNormal);
            this.groupBox1.Location = new System.Drawing.Point(21, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 86);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vision";
            // 
            // rbEscaladeGrises
            // 
            this.rbEscaladeGrises.AutoSize = true;
            this.rbEscaladeGrises.Location = new System.Drawing.Point(330, 35);
            this.rbEscaladeGrises.Name = "rbEscaladeGrises";
            this.rbEscaladeGrises.Size = new System.Drawing.Size(132, 20);
            this.rbEscaladeGrises.TabIndex = 1;
            this.rbEscaladeGrises.Text = "Escala de Grises";
            this.rbEscaladeGrises.UseVisualStyleBackColor = true;
            this.rbEscaladeGrises.CheckedChanged += new System.EventHandler(this.rbEscaladeGrises_checkedChanged);
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(59, 35);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(73, 20);
            this.rbNormal.TabIndex = 0;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            this.rbNormal.CheckedChanged += new System.EventHandler(this.rbNormal_checkedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbZoom);
            this.groupBox2.Controls.Add(this.rbAjustar);
            this.groupBox2.Controls.Add(this.rbCentrada);
            this.groupBox2.Location = new System.Drawing.Point(581, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 191);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tamaño";
            // 
            // rbZoom
            // 
            this.rbZoom.AutoSize = true;
            this.rbZoom.Location = new System.Drawing.Point(18, 137);
            this.rbZoom.Name = "rbZoom";
            this.rbZoom.Size = new System.Drawing.Size(63, 20);
            this.rbZoom.TabIndex = 2;
            this.rbZoom.TabStop = true;
            this.rbZoom.Text = "Zoom";
            this.rbZoom.UseVisualStyleBackColor = true;
            this.rbZoom.CheckedChanged += new System.EventHandler(this.rbZoom_checkedChanged);
            // 
            // rbAjustar
            // 
            this.rbAjustar.AutoSize = true;
            this.rbAjustar.Location = new System.Drawing.Point(18, 87);
            this.rbAjustar.Name = "rbAjustar";
            this.rbAjustar.Size = new System.Drawing.Size(69, 20);
            this.rbAjustar.TabIndex = 1;
            this.rbAjustar.TabStop = true;
            this.rbAjustar.Text = "Ajustar";
            this.rbAjustar.UseVisualStyleBackColor = true;
            this.rbAjustar.CheckedChanged += new System.EventHandler(this.rbAjustar_checkedChanged);
            // 
            // rbCentrada
            // 
            this.rbCentrada.AutoSize = true;
            this.rbCentrada.Location = new System.Drawing.Point(18, 35);
            this.rbCentrada.Name = "rbCentrada";
            this.rbCentrada.Size = new System.Drawing.Size(83, 20);
            this.rbCentrada.TabIndex = 0;
            this.rbCentrada.TabStop = true;
            this.rbCentrada.Text = "Centrada";
            this.rbCentrada.UseVisualStyleBackColor = true;
            this.rbCentrada.CheckedChanged += new System.EventHandler(this.rbCentrada_checkedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(80, 267);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 216);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girarALaIzquierda90GradosToolStripMenuItem,
            this.girar90ALaDerechaToolStripMenuItem,
            this.copiarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(225, 76);
            // 
            // girarALaIzquierda90GradosToolStripMenuItem
            // 
            this.girarALaIzquierda90GradosToolStripMenuItem.Name = "girarALaIzquierda90GradosToolStripMenuItem";
            this.girarALaIzquierda90GradosToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.girarALaIzquierda90GradosToolStripMenuItem.Text = "Girar 90 a la Izquierda";
            this.girarALaIzquierda90GradosToolStripMenuItem.Click += new System.EventHandler(this.girarALaIzquierda90GradosToolStripMenuItem_Click);
            // 
            // girar90ALaDerechaToolStripMenuItem
            // 
            this.girar90ALaDerechaToolStripMenuItem.Name = "girar90ALaDerechaToolStripMenuItem";
            this.girar90ALaDerechaToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.girar90ALaDerechaToolStripMenuItem.Text = "Girar 90 a la Derecha";
            this.girar90ALaDerechaToolStripMenuItem.Click += new System.EventHandler(this.girar90ALaDerechaToolStripMenuItem_Click);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Imagen Actual:";
            // 
            // cmbImagenes
            // 
            this.cmbImagenes.FormattingEnabled = true;
            this.cmbImagenes.Location = new System.Drawing.Point(276, 220);
            this.cmbImagenes.Name = "cmbImagenes";
            this.cmbImagenes.Size = new System.Drawing.Size(121, 24);
            this.cmbImagenes.TabIndex = 7;
            this.cmbImagenes.SelectionChangeCommitted += new System.EventHandler(this.cmbImagenes_SelectionChangeCommitted);
            // 
            // btnPrimero
            // 
            this.btnPrimero.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimero.Location = new System.Drawing.Point(95, 527);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(60, 33);
            this.btnPrimero.TabIndex = 8;
            this.btnPrimero.Text = "<<";
            this.btnPrimero.UseVisualStyleBackColor = false;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Location = new System.Drawing.Point(202, 527);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(60, 33);
            this.btnAnterior.TabIndex = 9;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Location = new System.Drawing.Point(319, 527);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(60, 33);
            this.btnSiguiente.TabIndex = 10;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimo.Location = new System.Drawing.Point(423, 527);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(60, 33);
            this.btnUltimo.TabIndex = 11;
            this.btnUltimo.Text = ">>";
            this.btnUltimo.UseVisualStyleBackColor = false;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 661);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.cmbImagenes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Visor de Imagenes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escalaDeGrisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tamanioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnTSMVisionNormal;
        private System.Windows.Forms.ToolStripButton btnTSMVisionEscalaGrises;
        private System.Windows.Forms.ToolStripButton btnTSMCentrar;
        private System.Windows.Forms.ToolStripButton btnTSMAjustar;
        private System.Windows.Forms.ToolStripButton btnTSMZoom;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TSSlabelDireccion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox rbEscaladeGrises;
        private System.Windows.Forms.CheckBox rbNormal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbCentrada;
        private System.Windows.Forms.RadioButton rbZoom;
        private System.Windows.Forms.RadioButton rbAjustar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbImagenes;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem girarALaIzquierda90GradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girar90ALaDerechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
    }
}

