namespace Gestor_de_Tareas
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
            this.tpParte2 = new System.Windows.Forms.TabPage();
            this.btnBuscarRangoFecha = new System.Windows.Forms.Button();
            this.btnBuscarEstado = new System.Windows.Forms.Button();
            this.btnBuscarCod = new System.Windows.Forms.Button();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.cmbEstado2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLetrero = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.txtCodigo2 = new System.Windows.Forms.TextBox();
            this.lbl2Codigo = new System.Windows.Forms.Label();
            this.dgvTareas2 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpParte1 = new System.Windows.Forms.TabPage();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.lblLugar = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tpParte2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpParte1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // tpParte2
            // 
            this.tpParte2.Controls.Add(this.btnBuscarRangoFecha);
            this.tpParte2.Controls.Add(this.btnBuscarEstado);
            this.tpParte2.Controls.Add(this.btnBuscarCod);
            this.tpParte2.Controls.Add(this.dtpFechaFin);
            this.tpParte2.Controls.Add(this.lblFechaFin);
            this.tpParte2.Controls.Add(this.cmbEstado2);
            this.tpParte2.Controls.Add(this.label1);
            this.tpParte2.Controls.Add(this.lblLetrero);
            this.tpParte2.Controls.Add(this.dtpFechaInicio);
            this.tpParte2.Controls.Add(this.lblFechaInicio);
            this.tpParte2.Controls.Add(this.txtCodigo2);
            this.tpParte2.Controls.Add(this.lbl2Codigo);
            this.tpParte2.Controls.Add(this.dgvTareas2);
            this.tpParte2.Location = new System.Drawing.Point(4, 25);
            this.tpParte2.Name = "tpParte2";
            this.tpParte2.Padding = new System.Windows.Forms.Padding(3);
            this.tpParte2.Size = new System.Drawing.Size(1030, 610);
            this.tpParte2.TabIndex = 1;
            this.tpParte2.Text = "Parte 2";
            this.tpParte2.UseVisualStyleBackColor = true;
            // 
            // btnBuscarRangoFecha
            // 
            this.btnBuscarRangoFecha.Location = new System.Drawing.Point(47, 361);
            this.btnBuscarRangoFecha.Name = "btnBuscarRangoFecha";
            this.btnBuscarRangoFecha.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarRangoFecha.TabIndex = 48;
            this.btnBuscarRangoFecha.Text = "Buscar";
            this.btnBuscarRangoFecha.UseVisualStyleBackColor = true;
            this.btnBuscarRangoFecha.Click += new System.EventHandler(this.btnBuscarRangoFecha_Click);
            // 
            // btnBuscarEstado
            // 
            this.btnBuscarEstado.Location = new System.Drawing.Point(47, 198);
            this.btnBuscarEstado.Name = "btnBuscarEstado";
            this.btnBuscarEstado.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarEstado.TabIndex = 47;
            this.btnBuscarEstado.Text = "Buscar";
            this.btnBuscarEstado.UseVisualStyleBackColor = true;
            this.btnBuscarEstado.Click += new System.EventHandler(this.btnBuscarEstado_Click);
            // 
            // btnBuscarCod
            // 
            this.btnBuscarCod.Location = new System.Drawing.Point(47, 93);
            this.btnBuscarCod.Name = "btnBuscarCod";
            this.btnBuscarCod.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCod.TabIndex = 46;
            this.btnBuscarCod.Text = "Buscar";
            this.btnBuscarCod.UseVisualStyleBackColor = true;
            this.btnBuscarCod.Click += new System.EventHandler(this.btnBuscarCod_Click);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(47, 333);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaFin.TabIndex = 45;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(44, 304);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(77, 16);
            this.lblFechaFin.TabIndex = 44;
            this.lblFechaFin.Text = "Fecha Final";
            // 
            // cmbEstado2
            // 
            this.cmbEstado2.FormattingEnabled = true;
            this.cmbEstado2.Items.AddRange(new object[] {
            "No Realizada",
            "En Proceso",
            "Terminada"});
            this.cmbEstado2.Location = new System.Drawing.Point(47, 168);
            this.cmbEstado2.Name = "cmbEstado2";
            this.cmbEstado2.Size = new System.Drawing.Size(121, 24);
            this.cmbEstado2.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Estado:";
            // 
            // lblLetrero
            // 
            this.lblLetrero.AutoSize = true;
            this.lblLetrero.Location = new System.Drawing.Point(44, 19);
            this.lblLetrero.Name = "lblLetrero";
            this.lblLetrero.Size = new System.Drawing.Size(131, 16);
            this.lblLetrero.TabIndex = 41;
            this.lblLetrero.Text = "Busqueda por Filtros";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(47, 269);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaInicio.TabIndex = 40;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(44, 240);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(98, 16);
            this.lblFechaInicio.TabIndex = 39;
            this.lblFechaInicio.Text = "Fecha de Inicio";
            // 
            // txtCodigo2
            // 
            this.txtCodigo2.Location = new System.Drawing.Point(47, 65);
            this.txtCodigo2.Name = "txtCodigo2";
            this.txtCodigo2.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo2.TabIndex = 34;
            this.txtCodigo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt2Codigo_KeyPress);
            this.txtCodigo2.Leave += new System.EventHandler(this.txt2Codigo_Leave);
            // 
            // lbl2Codigo
            // 
            this.lbl2Codigo.AutoSize = true;
            this.lbl2Codigo.Location = new System.Drawing.Point(44, 46);
            this.lbl2Codigo.Name = "lbl2Codigo";
            this.lbl2Codigo.Size = new System.Drawing.Size(54, 16);
            this.lbl2Codigo.TabIndex = 33;
            this.lbl2Codigo.Text = "Codigo:";
            // 
            // dgvTareas2
            // 
            this.dgvTareas2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas2.Location = new System.Drawing.Point(371, 0);
            this.dgvTareas2.Name = "dgvTareas2";
            this.dgvTareas2.RowHeadersWidth = 51;
            this.dgvTareas2.RowTemplate.Height = 24;
            this.dgvTareas2.Size = new System.Drawing.Size(656, 610);
            this.dgvTareas2.TabIndex = 32;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpParte1);
            this.tabControl1.Controls.Add(this.tpParte2);
            this.tabControl1.Location = new System.Drawing.Point(1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1038, 639);
            this.tabControl1.TabIndex = 0;
            // 
            // tpParte1
            // 
            this.tpParte1.Controls.Add(this.dgvTareas);
            this.tpParte1.Controls.Add(this.btnEliminar);
            this.tpParte1.Controls.Add(this.btnEditar);
            this.tpParte1.Controls.Add(this.btnAgregar);
            this.tpParte1.Controls.Add(this.cmbEstado);
            this.tpParte1.Controls.Add(this.lblEstado);
            this.tpParte1.Controls.Add(this.txtLugar);
            this.tpParte1.Controls.Add(this.lblLugar);
            this.tpParte1.Controls.Add(this.dtpFecha);
            this.tpParte1.Controls.Add(this.lblFecha);
            this.tpParte1.Controls.Add(this.txtDescripcion);
            this.tpParte1.Controls.Add(this.lblDescripcion);
            this.tpParte1.Controls.Add(this.txtNombre);
            this.tpParte1.Controls.Add(this.lblNombre);
            this.tpParte1.Controls.Add(this.txtCodigo);
            this.tpParte1.Controls.Add(this.lblCodigo);
            this.tpParte1.Location = new System.Drawing.Point(4, 25);
            this.tpParte1.Name = "tpParte1";
            this.tpParte1.Padding = new System.Windows.Forms.Padding(3);
            this.tpParte1.Size = new System.Drawing.Size(1030, 610);
            this.tpParte1.TabIndex = 0;
            this.tpParte1.Text = "Parte 1";
            this.tpParte1.UseVisualStyleBackColor = true;
            // 
            // dgvTareas
            // 
            this.dgvTareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Location = new System.Drawing.Point(375, 3);
            this.dgvTareas.MultiSelect = false;
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.RowHeadersWidth = 51;
            this.dgvTareas.RowTemplate.Height = 24;
            this.dgvTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTareas.Size = new System.Drawing.Size(652, 604);
            this.dgvTareas.TabIndex = 31;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(214, 517);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 44);
            this.btnEliminar.TabIndex = 30;
            this.btnEliminar.Text = "Borrar Tarea";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(116, 517);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 44);
            this.btnEditar.TabIndex = 29;
            this.btnEditar.Text = "Editar Tarea";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(19, 517);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 44);
            this.btnAgregar.TabIndex = 28;
            this.btnAgregar.Text = "Agregar Tarea";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "No Realizada",
            "En Proceso",
            "Terminada"});
            this.cmbEstado.Location = new System.Drawing.Point(53, 452);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 24);
            this.cmbEstado.TabIndex = 27;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(50, 424);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(53, 16);
            this.lblEstado.TabIndex = 26;
            this.lblEstado.Text = "Estado:";
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(53, 383);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(100, 22);
            this.txtLugar.TabIndex = 25;
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(50, 352);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(44, 16);
            this.lblLugar.TabIndex = 24;
            this.lblLugar.Text = "Lugar:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(53, 309);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 22);
            this.dtpFecha.TabIndex = 23;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(50, 280);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(141, 16);
            this.lblFecha.TabIndex = 22;
            this.lblFecha.Text = "Fecha de Realizacion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(53, 200);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(150, 60);
            this.txtDescripcion.TabIndex = 21;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(50, 167);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcion.TabIndex = 20;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(53, 124);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 19;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(50, 105);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(53, 60);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 17;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(50, 41);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 16;
            this.lblCodigo.Text = "Codigo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 636);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Gestor de Tareas";
            this.tpParte2.ResumeLayout(false);
            this.tpParte2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpParte1.ResumeLayout(false);
            this.tpParte1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpParte2;
        private System.Windows.Forms.DataGridView dgvTareas2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpParte1;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.TextBox txtCodigo2;
        private System.Windows.Forms.Label lbl2Codigo;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.ComboBox cmbEstado2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLetrero;
        private System.Windows.Forms.Button btnBuscarCod;
        private System.Windows.Forms.Button btnBuscarRangoFecha;
        private System.Windows.Forms.Button btnBuscarEstado;
    }
}

