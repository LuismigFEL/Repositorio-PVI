namespace EjerciciosSemana1
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
            this.PestaniaEjercicios = new System.Windows.Forms.TabControl();
            this.LoginPage = new System.Windows.Forms.TabPage();
            this.IMCpage = new System.Windows.Forms.TabPage();
            this.ConversorTempPage = new System.Windows.Forms.TabPage();
            this.CuentaClicsPage = new System.Windows.Forms.TabPage();
            this.btIniciar = new System.Windows.Forms.Button();
            this.ctContrasenia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctPeso = new System.Windows.Forms.TextBox();
            this.ctAltura = new System.Windows.Forms.TextBox();
            this.BtnConversion = new System.Windows.Forms.Button();
            this.labelPeso = new System.Windows.Forms.Label();
            this.labelAltura = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TempFinal = new System.Windows.Forms.ComboBox();
            this.ctTempInicial = new System.Windows.Forms.TextBox();
            this.TempInicial = new System.Windows.Forms.ComboBox();
            this.labelTempFinal = new System.Windows.Forms.Label();
            this.Reinicio = new System.Windows.Forms.Button();
            this.MuestraClics = new System.Windows.Forms.Label();
            this.labelLetrero = new System.Windows.Forms.Label();
            this.Click = new System.Windows.Forms.Button();
            this.PestaniaEjercicios.SuspendLayout();
            this.LoginPage.SuspendLayout();
            this.IMCpage.SuspendLayout();
            this.ConversorTempPage.SuspendLayout();
            this.CuentaClicsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // PestaniaEjercicios
            // 
            this.PestaniaEjercicios.Controls.Add(this.LoginPage);
            this.PestaniaEjercicios.Controls.Add(this.IMCpage);
            this.PestaniaEjercicios.Controls.Add(this.ConversorTempPage);
            this.PestaniaEjercicios.Controls.Add(this.CuentaClicsPage);
            this.PestaniaEjercicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PestaniaEjercicios.Location = new System.Drawing.Point(0, 0);
            this.PestaniaEjercicios.Name = "PestaniaEjercicios";
            this.PestaniaEjercicios.SelectedIndex = 0;
            this.PestaniaEjercicios.Size = new System.Drawing.Size(579, 359);
            this.PestaniaEjercicios.TabIndex = 0;
            // 
            // LoginPage
            // 
            this.LoginPage.Controls.Add(this.btIniciar);
            this.LoginPage.Controls.Add(this.ctContrasenia);
            this.LoginPage.Controls.Add(this.label2);
            this.LoginPage.Controls.Add(this.ctUsuario);
            this.LoginPage.Controls.Add(this.label1);
            this.LoginPage.Location = new System.Drawing.Point(4, 25);
            this.LoginPage.Name = "LoginPage";
            this.LoginPage.Padding = new System.Windows.Forms.Padding(3);
            this.LoginPage.Size = new System.Drawing.Size(571, 330);
            this.LoginPage.TabIndex = 0;
            this.LoginPage.Text = "Log in";
            this.LoginPage.UseVisualStyleBackColor = true;
            // 
            // IMCpage
            // 
            this.IMCpage.Controls.Add(this.ctPeso);
            this.IMCpage.Controls.Add(this.ctAltura);
            this.IMCpage.Controls.Add(this.BtnConversion);
            this.IMCpage.Controls.Add(this.labelPeso);
            this.IMCpage.Controls.Add(this.labelAltura);
            this.IMCpage.Location = new System.Drawing.Point(4, 25);
            this.IMCpage.Name = "IMCpage";
            this.IMCpage.Padding = new System.Windows.Forms.Padding(3);
            this.IMCpage.Size = new System.Drawing.Size(571, 330);
            this.IMCpage.TabIndex = 1;
            this.IMCpage.Text = "IMC";
            this.IMCpage.UseVisualStyleBackColor = true;
            // 
            // ConversorTempPage
            // 
            this.ConversorTempPage.Controls.Add(this.label3);
            this.ConversorTempPage.Controls.Add(this.label4);
            this.ConversorTempPage.Controls.Add(this.TempFinal);
            this.ConversorTempPage.Controls.Add(this.ctTempInicial);
            this.ConversorTempPage.Controls.Add(this.TempInicial);
            this.ConversorTempPage.Controls.Add(this.labelTempFinal);
            this.ConversorTempPage.Location = new System.Drawing.Point(4, 25);
            this.ConversorTempPage.Name = "ConversorTempPage";
            this.ConversorTempPage.Size = new System.Drawing.Size(571, 330);
            this.ConversorTempPage.TabIndex = 2;
            this.ConversorTempPage.Text = "Conversor de Temperatura";
            this.ConversorTempPage.UseVisualStyleBackColor = true;
            // 
            // CuentaClicsPage
            // 
            this.CuentaClicsPage.Controls.Add(this.Reinicio);
            this.CuentaClicsPage.Controls.Add(this.MuestraClics);
            this.CuentaClicsPage.Controls.Add(this.labelLetrero);
            this.CuentaClicsPage.Controls.Add(this.Click);
            this.CuentaClicsPage.Location = new System.Drawing.Point(4, 25);
            this.CuentaClicsPage.Name = "CuentaClicsPage";
            this.CuentaClicsPage.Size = new System.Drawing.Size(571, 330);
            this.CuentaClicsPage.TabIndex = 3;
            this.CuentaClicsPage.Text = "Contador de Clics";
            this.CuentaClicsPage.UseVisualStyleBackColor = true;
            // 
            // btIniciar
            // 
            this.btIniciar.Location = new System.Drawing.Point(214, 225);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(106, 33);
            this.btIniciar.TabIndex = 9;
            this.btIniciar.Text = "Iniciar Sesion";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // ctContrasenia
            // 
            this.ctContrasenia.Location = new System.Drawing.Point(296, 154);
            this.ctContrasenia.Name = "ctContrasenia";
            this.ctContrasenia.PasswordChar = '*';
            this.ctContrasenia.Size = new System.Drawing.Size(100, 22);
            this.ctContrasenia.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contrasenia:";
            // 
            // ctUsuario
            // 
            this.ctUsuario.Location = new System.Drawing.Point(298, 90);
            this.ctUsuario.Name = "ctUsuario";
            this.ctUsuario.Size = new System.Drawing.Size(100, 22);
            this.ctUsuario.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario: ";
            // 
            // ctPeso
            // 
            this.ctPeso.Location = new System.Drawing.Point(315, 184);
            this.ctPeso.Name = "ctPeso";
            this.ctPeso.Size = new System.Drawing.Size(100, 22);
            this.ctPeso.TabIndex = 9;
            // 
            // ctAltura
            // 
            this.ctAltura.Location = new System.Drawing.Point(315, 75);
            this.ctAltura.Name = "ctAltura";
            this.ctAltura.Size = new System.Drawing.Size(100, 22);
            this.ctAltura.TabIndex = 8;
            // 
            // BtnConversion
            // 
            this.BtnConversion.Location = new System.Drawing.Point(238, 256);
            this.BtnConversion.Name = "BtnConversion";
            this.BtnConversion.Size = new System.Drawing.Size(75, 23);
            this.BtnConversion.TabIndex = 7;
            this.BtnConversion.Text = "Calcular";
            this.BtnConversion.UseVisualStyleBackColor = true;
            this.BtnConversion.Click += new System.EventHandler(this.BtnConversion_Click);
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Location = new System.Drawing.Point(162, 184);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(66, 16);
            this.labelPeso.TabIndex = 6;
            this.labelPeso.Text = "Peso (Kg)";
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Location = new System.Drawing.Point(159, 75);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(63, 16);
            this.labelAltura.TabIndex = 5;
            this.labelAltura.Text = "Altura (m)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Escoja uno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Escoja uno";
            // 
            // TempFinal
            // 
            this.TempFinal.AutoCompleteCustomSource.AddRange(new string[] {
            "Celsius",
            "Fahrenheit"});
            this.TempFinal.FormattingEnabled = true;
            this.TempFinal.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit"});
            this.TempFinal.Location = new System.Drawing.Point(92, 192);
            this.TempFinal.Name = "TempFinal";
            this.TempFinal.Size = new System.Drawing.Size(121, 24);
            this.TempFinal.TabIndex = 9;
            // 
            // ctTempInicial
            // 
            this.ctTempInicial.Location = new System.Drawing.Point(354, 97);
            this.ctTempInicial.Name = "ctTempInicial";
            this.ctTempInicial.Size = new System.Drawing.Size(100, 22);
            this.ctTempInicial.TabIndex = 8;
            // 
            // TempInicial
            // 
            this.TempInicial.AutoCompleteCustomSource.AddRange(new string[] {
            "Celsius",
            "Fahrenheit"});
            this.TempInicial.FormattingEnabled = true;
            this.TempInicial.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit"});
            this.TempInicial.Location = new System.Drawing.Point(92, 97);
            this.TempInicial.Name = "TempInicial";
            this.TempInicial.Size = new System.Drawing.Size(121, 24);
            this.TempInicial.TabIndex = 7;
            // 
            // labelTempFinal
            // 
            this.labelTempFinal.AutoSize = true;
            this.labelTempFinal.Location = new System.Drawing.Point(351, 195);
            this.labelTempFinal.Name = "labelTempFinal";
            this.labelTempFinal.Size = new System.Drawing.Size(88, 32);
            this.labelTempFinal.TabIndex = 6;
            this.labelTempFinal.Text = "Temperatura \r\nConvertida";
            // 
            // Reinicio
            // 
            this.Reinicio.Location = new System.Drawing.Point(240, 195);
            this.Reinicio.Name = "Reinicio";
            this.Reinicio.Size = new System.Drawing.Size(75, 23);
            this.Reinicio.TabIndex = 7;
            this.Reinicio.Text = "Reiniciar";
            this.Reinicio.UseVisualStyleBackColor = true;
            this.Reinicio.Click += new System.EventHandler(this.Reinicio_Click);
            // 
            // MuestraClics
            // 
            this.MuestraClics.AutoSize = true;
            this.MuestraClics.Location = new System.Drawing.Point(271, 123);
            this.MuestraClics.Name = "MuestraClics";
            this.MuestraClics.Size = new System.Drawing.Size(14, 16);
            this.MuestraClics.TabIndex = 6;
            this.MuestraClics.Text = "0";
            // 
            // labelLetrero
            // 
            this.labelLetrero.AutoSize = true;
            this.labelLetrero.Location = new System.Drawing.Point(221, 84);
            this.labelLetrero.Name = "labelLetrero";
            this.labelLetrero.Size = new System.Drawing.Size(113, 16);
            this.labelLetrero.TabIndex = 5;
            this.labelLetrero.Text = "Contador de Clics";
            // 
            // Click
            // 
            this.Click.Location = new System.Drawing.Point(240, 166);
            this.Click.Name = "Click";
            this.Click.Size = new System.Drawing.Size(75, 23);
            this.Click.TabIndex = 4;
            this.Click.Text = "Clic Aqui";
            this.Click.UseVisualStyleBackColor = true;
            this.Click.Click += new System.EventHandler(this.Click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 359);
            this.Controls.Add(this.PestaniaEjercicios);
            this.Name = "Ejercicio Semana 1";
            this.Text = "Ejercicio Semana 1";
            this.PestaniaEjercicios.ResumeLayout(false);
            this.LoginPage.ResumeLayout(false);
            this.LoginPage.PerformLayout();
            this.IMCpage.ResumeLayout(false);
            this.IMCpage.PerformLayout();
            this.ConversorTempPage.ResumeLayout(false);
            this.ConversorTempPage.PerformLayout();
            this.CuentaClicsPage.ResumeLayout(false);
            this.CuentaClicsPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl PestaniaEjercicios;
        private System.Windows.Forms.TabPage LoginPage;
        private System.Windows.Forms.TabPage IMCpage;
        private System.Windows.Forms.TabPage ConversorTempPage;
        private System.Windows.Forms.TabPage CuentaClicsPage;
        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.TextBox ctContrasenia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ctPeso;
        private System.Windows.Forms.TextBox ctAltura;
        private System.Windows.Forms.Button BtnConversion;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.Label labelAltura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TempFinal;
        private System.Windows.Forms.TextBox ctTempInicial;
        private System.Windows.Forms.ComboBox TempInicial;
        private System.Windows.Forms.Label labelTempFinal;
        private System.Windows.Forms.Button Reinicio;
        private System.Windows.Forms.Label MuestraClics;
        private System.Windows.Forms.Label labelLetrero;
        private System.Windows.Forms.Button Click;
    }
}

