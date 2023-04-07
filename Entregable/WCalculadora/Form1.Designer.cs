namespace WCalculadora
{
    partial class FrmCalculadora
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
            this.GrbNumeros = new System.Windows.Forms.GroupBox();
            this.TxtNumero4 = new System.Windows.Forms.TextBox();
            this.TxtNumero3 = new System.Windows.Forms.TextBox();
            this.TxtNumero2 = new System.Windows.Forms.TextBox();
            this.TxtNumero1 = new System.Windows.Forms.TextBox();
            this.LbNumero4 = new System.Windows.Forms.Label();
            this.LbNumero3 = new System.Windows.Forms.Label();
            this.LbNumero2 = new System.Windows.Forms.Label();
            this.LbNumero1 = new System.Windows.Forms.Label();
            this.LbTitulo = new System.Windows.Forms.Label();
            this.GrbTipoDeOperaciones = new System.Windows.Forms.GroupBox();
            this.CtxTipoDeOperacionesBasicas = new System.Windows.Forms.ComboBox();
            this.CtxTipoDeOperacionesAvanzadas = new System.Windows.Forms.ComboBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.TxtRespuesta = new System.Windows.Forms.TextBox();
            this.GrbOperaciones = new System.Windows.Forms.GroupBox();
            this.RadAvanzadas = new System.Windows.Forms.RadioButton();
            this.RadBasicas = new System.Windows.Forms.RadioButton();
            this.GrbNumeros.SuspendLayout();
            this.GrbTipoDeOperaciones.SuspendLayout();
            this.GrbOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbNumeros
            // 
            this.GrbNumeros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GrbNumeros.Controls.Add(this.TxtNumero4);
            this.GrbNumeros.Controls.Add(this.TxtNumero3);
            this.GrbNumeros.Controls.Add(this.TxtNumero2);
            this.GrbNumeros.Controls.Add(this.TxtNumero1);
            this.GrbNumeros.Controls.Add(this.LbNumero4);
            this.GrbNumeros.Controls.Add(this.LbNumero3);
            this.GrbNumeros.Controls.Add(this.LbNumero2);
            this.GrbNumeros.Controls.Add(this.LbNumero1);
            this.GrbNumeros.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbNumeros.Location = new System.Drawing.Point(121, 463);
            this.GrbNumeros.Margin = new System.Windows.Forms.Padding(4);
            this.GrbNumeros.Name = "GrbNumeros";
            this.GrbNumeros.Padding = new System.Windows.Forms.Padding(4);
            this.GrbNumeros.Size = new System.Drawing.Size(352, 278);
            this.GrbNumeros.TabIndex = 0;
            this.GrbNumeros.TabStop = false;
            this.GrbNumeros.Text = "NÚMEROS";
            // 
            // TxtNumero4
            // 
            this.TxtNumero4.Location = new System.Drawing.Point(153, 207);
            this.TxtNumero4.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNumero4.Name = "TxtNumero4";
            this.TxtNumero4.Size = new System.Drawing.Size(172, 31);
            this.TxtNumero4.TabIndex = 8;
            // 
            // TxtNumero3
            // 
            this.TxtNumero3.Location = new System.Drawing.Point(153, 160);
            this.TxtNumero3.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNumero3.Name = "TxtNumero3";
            this.TxtNumero3.Size = new System.Drawing.Size(172, 31);
            this.TxtNumero3.TabIndex = 7;
            // 
            // TxtNumero2
            // 
            this.TxtNumero2.Location = new System.Drawing.Point(153, 106);
            this.TxtNumero2.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNumero2.Name = "TxtNumero2";
            this.TxtNumero2.Size = new System.Drawing.Size(172, 31);
            this.TxtNumero2.TabIndex = 6;
            // 
            // TxtNumero1
            // 
            this.TxtNumero1.Location = new System.Drawing.Point(153, 47);
            this.TxtNumero1.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNumero1.Name = "TxtNumero1";
            this.TxtNumero1.Size = new System.Drawing.Size(172, 31);
            this.TxtNumero1.TabIndex = 2;
            // 
            // LbNumero4
            // 
            this.LbNumero4.AutoSize = true;
            this.LbNumero4.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.LbNumero4.Location = new System.Drawing.Point(32, 207);
            this.LbNumero4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbNumero4.Name = "LbNumero4";
            this.LbNumero4.Size = new System.Drawing.Size(94, 20);
            this.LbNumero4.TabIndex = 5;
            this.LbNumero4.Text = "Numero 4";
            this.LbNumero4.Visible = false;
            // 
            // LbNumero3
            // 
            this.LbNumero3.AutoSize = true;
            this.LbNumero3.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.LbNumero3.Location = new System.Drawing.Point(32, 156);
            this.LbNumero3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbNumero3.Name = "LbNumero3";
            this.LbNumero3.Size = new System.Drawing.Size(94, 20);
            this.LbNumero3.TabIndex = 4;
            this.LbNumero3.Text = "Numero 3";
            this.LbNumero3.Visible = false;
            // 
            // LbNumero2
            // 
            this.LbNumero2.AutoSize = true;
            this.LbNumero2.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.LbNumero2.Location = new System.Drawing.Point(32, 106);
            this.LbNumero2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbNumero2.Name = "LbNumero2";
            this.LbNumero2.Size = new System.Drawing.Size(94, 20);
            this.LbNumero2.TabIndex = 3;
            this.LbNumero2.Text = "Numero 2";
            this.LbNumero2.Visible = false;
            // 
            // LbNumero1
            // 
            this.LbNumero1.AutoSize = true;
            this.LbNumero1.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.LbNumero1.Location = new System.Drawing.Point(32, 50);
            this.LbNumero1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbNumero1.Name = "LbNumero1";
            this.LbNumero1.Size = new System.Drawing.Size(94, 20);
            this.LbNumero1.TabIndex = 2;
            this.LbNumero1.Text = "Numero 1";
            this.LbNumero1.Visible = false;
            // 
            // LbTitulo
            // 
            this.LbTitulo.AutoSize = true;
            this.LbTitulo.Font = new System.Drawing.Font("Stencil", 30.25F);
            this.LbTitulo.Location = new System.Drawing.Point(96, 37);
            this.LbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbTitulo.Name = "LbTitulo";
            this.LbTitulo.Size = new System.Drawing.Size(371, 60);
            this.LbTitulo.TabIndex = 1;
            this.LbTitulo.Text = "CALCULADORA";
            // 
            // GrbTipoDeOperaciones
            // 
            this.GrbTipoDeOperaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GrbTipoDeOperaciones.Controls.Add(this.CtxTipoDeOperacionesBasicas);
            this.GrbTipoDeOperaciones.Controls.Add(this.CtxTipoDeOperacionesAvanzadas);
            this.GrbTipoDeOperaciones.Font = new System.Drawing.Font("Stencil", 12.75F);
            this.GrbTipoDeOperaciones.Location = new System.Drawing.Point(121, 347);
            this.GrbTipoDeOperaciones.Margin = new System.Windows.Forms.Padding(4);
            this.GrbTipoDeOperaciones.Name = "GrbTipoDeOperaciones";
            this.GrbTipoDeOperaciones.Padding = new System.Windows.Forms.Padding(4);
            this.GrbTipoDeOperaciones.Size = new System.Drawing.Size(352, 82);
            this.GrbTipoDeOperaciones.TabIndex = 2;
            this.GrbTipoDeOperaciones.TabStop = false;
            this.GrbTipoDeOperaciones.Text = "TIPO DE OPERACIONES";
            // 
            // CtxTipoDeOperacionesBasicas
            // 
            this.CtxTipoDeOperacionesBasicas.Font = new System.Drawing.Font("Stencil", 10F);
            this.CtxTipoDeOperacionesBasicas.FormattingEnabled = true;
            this.CtxTipoDeOperacionesBasicas.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicacion",
            "Division"});
            this.CtxTipoDeOperacionesBasicas.Location = new System.Drawing.Point(10, 32);
            this.CtxTipoDeOperacionesBasicas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CtxTipoDeOperacionesBasicas.Name = "CtxTipoDeOperacionesBasicas";
            this.CtxTipoDeOperacionesBasicas.Size = new System.Drawing.Size(167, 28);
            this.CtxTipoDeOperacionesBasicas.TabIndex = 53;
            this.CtxTipoDeOperacionesBasicas.SelectedIndexChanged += new System.EventHandler(this.CtxTipoDeOperacionesBasicas_SelectedIndexChanged);
            // 
            // CtxTipoDeOperacionesAvanzadas
            // 
            this.CtxTipoDeOperacionesAvanzadas.Font = new System.Drawing.Font("Stencil", 10F);
            this.CtxTipoDeOperacionesAvanzadas.FormattingEnabled = true;
            this.CtxTipoDeOperacionesAvanzadas.Items.AddRange(new object[] {
            "Exponencial",
            "Radicacion",
            "Hipotenusa",
            "Seno",
            "Coseno",
            "Logaritmo",
            "Moda",
            "Tangente"});
            this.CtxTipoDeOperacionesAvanzadas.Location = new System.Drawing.Point(183, 32);
            this.CtxTipoDeOperacionesAvanzadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CtxTipoDeOperacionesAvanzadas.Name = "CtxTipoDeOperacionesAvanzadas";
            this.CtxTipoDeOperacionesAvanzadas.Size = new System.Drawing.Size(163, 28);
            this.CtxTipoDeOperacionesAvanzadas.TabIndex = 52;
            this.CtxTipoDeOperacionesAvanzadas.SelectedIndexChanged += new System.EventHandler(this.CtxTipoDeOperacionesAvanzadas_SelectedIndexChanged);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCalcular.Font = new System.Drawing.Font("Stencil", 15F);
            this.BtnCalcular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCalcular.Location = new System.Drawing.Point(121, 778);
            this.BtnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(163, 59);
            this.BtnCalcular.TabIndex = 3;
            this.BtnCalcular.Text = "CALCULAR";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnLimpiar.Font = new System.Drawing.Font("Stencil", 15F);
            this.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnLimpiar.Location = new System.Drawing.Point(304, 778);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(169, 59);
            this.BtnLimpiar.TabIndex = 4;
            this.BtnLimpiar.Text = "LIMPIAR";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // TxtRespuesta
            // 
            this.TxtRespuesta.Location = new System.Drawing.Point(121, 134);
            this.TxtRespuesta.Margin = new System.Windows.Forms.Padding(4);
            this.TxtRespuesta.Multiline = true;
            this.TxtRespuesta.Name = "TxtRespuesta";
            this.TxtRespuesta.ReadOnly = true;
            this.TxtRespuesta.Size = new System.Drawing.Size(351, 46);
            this.TxtRespuesta.TabIndex = 9;
            // 
            // GrbOperaciones
            // 
            this.GrbOperaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GrbOperaciones.Controls.Add(this.RadAvanzadas);
            this.GrbOperaciones.Controls.Add(this.RadBasicas);
            this.GrbOperaciones.Font = new System.Drawing.Font("Stencil", 12.75F);
            this.GrbOperaciones.Location = new System.Drawing.Point(121, 235);
            this.GrbOperaciones.Margin = new System.Windows.Forms.Padding(4);
            this.GrbOperaciones.Name = "GrbOperaciones";
            this.GrbOperaciones.Padding = new System.Windows.Forms.Padding(4);
            this.GrbOperaciones.Size = new System.Drawing.Size(352, 82);
            this.GrbOperaciones.TabIndex = 54;
            this.GrbOperaciones.TabStop = false;
            this.GrbOperaciones.Text = "OPERACIONES";
            // 
            // RadAvanzadas
            // 
            this.RadAvanzadas.AutoSize = true;
            this.RadAvanzadas.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.RadAvanzadas.Location = new System.Drawing.Point(183, 33);
            this.RadAvanzadas.Name = "RadAvanzadas";
            this.RadAvanzadas.Size = new System.Drawing.Size(120, 24);
            this.RadAvanzadas.TabIndex = 14;
            this.RadAvanzadas.TabStop = true;
            this.RadAvanzadas.Text = "Avanzadas";
            this.RadAvanzadas.UseVisualStyleBackColor = true;
            this.RadAvanzadas.CheckedChanged += new System.EventHandler(this.RadAvanzadas_CheckedChanged);
            // 
            // RadBasicas
            // 
            this.RadBasicas.AutoSize = true;
            this.RadBasicas.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.RadBasicas.Location = new System.Drawing.Point(7, 33);
            this.RadBasicas.Name = "RadBasicas";
            this.RadBasicas.Size = new System.Drawing.Size(91, 24);
            this.RadBasicas.TabIndex = 13;
            this.RadBasicas.TabStop = true;
            this.RadBasicas.Text = "Básicas";
            this.RadBasicas.UseVisualStyleBackColor = true;
            this.RadBasicas.CheckedChanged += new System.EventHandler(this.RadBasicas_CheckedChanged);
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(573, 911);
            this.Controls.Add(this.GrbOperaciones);
            this.Controls.Add(this.TxtRespuesta);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.GrbTipoDeOperaciones);
            this.Controls.Add(this.LbTitulo);
            this.Controls.Add(this.GrbNumeros);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCalculadora";
            this.Text = "WCalculadora";
            this.GrbNumeros.ResumeLayout(false);
            this.GrbNumeros.PerformLayout();
            this.GrbTipoDeOperaciones.ResumeLayout(false);
            this.GrbOperaciones.ResumeLayout(false);
            this.GrbOperaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbNumeros;
        private System.Windows.Forms.Label LbTitulo;
        private System.Windows.Forms.Label LbNumero2;
        private System.Windows.Forms.Label LbNumero1;
        private System.Windows.Forms.TextBox TxtNumero4;
        private System.Windows.Forms.TextBox TxtNumero3;
        private System.Windows.Forms.TextBox TxtNumero2;
        private System.Windows.Forms.TextBox TxtNumero1;
        private System.Windows.Forms.Label LbNumero4;
        private System.Windows.Forms.Label LbNumero3;
        private System.Windows.Forms.GroupBox GrbTipoDeOperaciones;
        private System.Windows.Forms.ComboBox CtxTipoDeOperacionesAvanzadas;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.ComboBox CtxTipoDeOperacionesBasicas;
        private System.Windows.Forms.TextBox TxtRespuesta;
        private System.Windows.Forms.GroupBox GrbOperaciones;
        private System.Windows.Forms.RadioButton RadBasicas;
        private System.Windows.Forms.RadioButton RadAvanzadas;
    }
}

