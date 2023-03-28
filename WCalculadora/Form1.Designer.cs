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
            this.LbTitulo = new System.Windows.Forms.Label();
            this.LbNumero1 = new System.Windows.Forms.Label();
            this.LbNumero2 = new System.Windows.Forms.Label();
            this.LbNumero3 = new System.Windows.Forms.Label();
            this.LbNumero4 = new System.Windows.Forms.Label();
            this.TxtNumero1 = new System.Windows.Forms.TextBox();
            this.TxtNumero2 = new System.Windows.Forms.TextBox();
            this.TxtNumero3 = new System.Windows.Forms.TextBox();
            this.TxtNumero4 = new System.Windows.Forms.TextBox();
            this.GrbTipoDeOperaciones = new System.Windows.Forms.GroupBox();
            this.CtxTipoDeOperacionesAvanzadas = new System.Windows.Forms.ComboBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.TxtRespuesta = new System.Windows.Forms.TextBox();
            this.CtxTipoDeOperacionesBasicas = new System.Windows.Forms.ComboBox();
            this.GrbOperaciones = new System.Windows.Forms.GroupBox();
            this.ChbBasicas = new System.Windows.Forms.CheckBox();
            this.ChbAvanzadas = new System.Windows.Forms.CheckBox();
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
            this.GrbNumeros.Location = new System.Drawing.Point(91, 376);
            this.GrbNumeros.Name = "GrbNumeros";
            this.GrbNumeros.Size = new System.Drawing.Size(264, 226);
            this.GrbNumeros.TabIndex = 0;
            this.GrbNumeros.TabStop = false;
            this.GrbNumeros.Text = "NÚMEROS";
            // 
            // LbTitulo
            // 
            this.LbTitulo.AutoSize = true;
            this.LbTitulo.Font = new System.Drawing.Font("Stencil", 30.25F);
            this.LbTitulo.Location = new System.Drawing.Point(72, 30);
            this.LbTitulo.Name = "LbTitulo";
            this.LbTitulo.Size = new System.Drawing.Size(297, 48);
            this.LbTitulo.TabIndex = 1;
            this.LbTitulo.Text = "CALCULADORA";
            // 
            // LbNumero1
            // 
            this.LbNumero1.AutoSize = true;
            this.LbNumero1.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.LbNumero1.Location = new System.Drawing.Point(24, 41);
            this.LbNumero1.Name = "LbNumero1";
            this.LbNumero1.Size = new System.Drawing.Size(75, 16);
            this.LbNumero1.TabIndex = 2;
            this.LbNumero1.Text = "Numero 1";
            this.LbNumero1.Visible = false;
            // 
            // LbNumero2
            // 
            this.LbNumero2.AutoSize = true;
            this.LbNumero2.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.LbNumero2.Location = new System.Drawing.Point(24, 86);
            this.LbNumero2.Name = "LbNumero2";
            this.LbNumero2.Size = new System.Drawing.Size(75, 16);
            this.LbNumero2.TabIndex = 3;
            this.LbNumero2.Text = "Numero 2";
            this.LbNumero2.Visible = false;
            this.LbNumero2.Click += new System.EventHandler(this.label1_Click);
            // 
            // LbNumero3
            // 
            this.LbNumero3.AutoSize = true;
            this.LbNumero3.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.LbNumero3.Location = new System.Drawing.Point(24, 127);
            this.LbNumero3.Name = "LbNumero3";
            this.LbNumero3.Size = new System.Drawing.Size(75, 16);
            this.LbNumero3.TabIndex = 4;
            this.LbNumero3.Text = "Numero 3";
            this.LbNumero3.Visible = false;
            // 
            // LbNumero4
            // 
            this.LbNumero4.AutoSize = true;
            this.LbNumero4.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.LbNumero4.Location = new System.Drawing.Point(24, 168);
            this.LbNumero4.Name = "LbNumero4";
            this.LbNumero4.Size = new System.Drawing.Size(75, 16);
            this.LbNumero4.TabIndex = 5;
            this.LbNumero4.Text = "Numero 4";
            this.LbNumero4.Visible = false;
            // 
            // TxtNumero1
            // 
            this.TxtNumero1.Location = new System.Drawing.Point(115, 38);
            this.TxtNumero1.Name = "TxtNumero1";
            this.TxtNumero1.Size = new System.Drawing.Size(130, 26);
            this.TxtNumero1.TabIndex = 2;
            // 
            // TxtNumero2
            // 
            this.TxtNumero2.Location = new System.Drawing.Point(115, 86);
            this.TxtNumero2.Name = "TxtNumero2";
            this.TxtNumero2.Size = new System.Drawing.Size(130, 26);
            this.TxtNumero2.TabIndex = 6;
            // 
            // TxtNumero3
            // 
            this.TxtNumero3.Location = new System.Drawing.Point(115, 130);
            this.TxtNumero3.Name = "TxtNumero3";
            this.TxtNumero3.Size = new System.Drawing.Size(130, 26);
            this.TxtNumero3.TabIndex = 7;
            this.TxtNumero3.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TxtNumero4
            // 
            this.TxtNumero4.Location = new System.Drawing.Point(115, 168);
            this.TxtNumero4.Name = "TxtNumero4";
            this.TxtNumero4.Size = new System.Drawing.Size(130, 26);
            this.TxtNumero4.TabIndex = 8;
            // 
            // GrbTipoDeOperaciones
            // 
            this.GrbTipoDeOperaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GrbTipoDeOperaciones.Controls.Add(this.CtxTipoDeOperacionesBasicas);
            this.GrbTipoDeOperaciones.Controls.Add(this.CtxTipoDeOperacionesAvanzadas);
            this.GrbTipoDeOperaciones.Font = new System.Drawing.Font("Stencil", 12.75F);
            this.GrbTipoDeOperaciones.Location = new System.Drawing.Point(91, 282);
            this.GrbTipoDeOperaciones.Name = "GrbTipoDeOperaciones";
            this.GrbTipoDeOperaciones.Size = new System.Drawing.Size(264, 67);
            this.GrbTipoDeOperaciones.TabIndex = 2;
            this.GrbTipoDeOperaciones.TabStop = false;
            this.GrbTipoDeOperaciones.Text = "TIPO DE OPERACIONES";
            // 
            // CtxTipoDeOperacionesAvanzadas
            // 
            this.CtxTipoDeOperacionesAvanzadas.FormattingEnabled = true;
            this.CtxTipoDeOperacionesAvanzadas.Items.AddRange(new object[] {
            "Exponencial",
            "Radicación",
            "Hipotenusa",
            "Seno",
            "Coseno",
            "Logaritmo",
            "Moda",
            "Tangente "});
            this.CtxTipoDeOperacionesAvanzadas.Location = new System.Drawing.Point(142, 26);
            this.CtxTipoDeOperacionesAvanzadas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CtxTipoDeOperacionesAvanzadas.Name = "CtxTipoDeOperacionesAvanzadas";
            this.CtxTipoDeOperacionesAvanzadas.Size = new System.Drawing.Size(103, 28);
            this.CtxTipoDeOperacionesAvanzadas.TabIndex = 52;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCalcular.Font = new System.Drawing.Font("Stencil", 15F);
            this.BtnCalcular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCalcular.Location = new System.Drawing.Point(91, 632);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(122, 48);
            this.BtnCalcular.TabIndex = 3;
            this.BtnCalcular.Text = "CALCULAR";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnLimpiar.Font = new System.Drawing.Font("Stencil", 15F);
            this.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnLimpiar.Location = new System.Drawing.Point(228, 632);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(127, 48);
            this.BtnLimpiar.TabIndex = 4;
            this.BtnLimpiar.Text = "LIMPIAR";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // TxtRespuesta
            // 
            this.TxtRespuesta.Location = new System.Drawing.Point(91, 109);
            this.TxtRespuesta.Multiline = true;
            this.TxtRespuesta.Name = "TxtRespuesta";
            this.TxtRespuesta.Size = new System.Drawing.Size(264, 38);
            this.TxtRespuesta.TabIndex = 9;
            // 
            // CtxTipoDeOperacionesBasicas
            // 
            this.CtxTipoDeOperacionesBasicas.FormattingEnabled = true;
            this.CtxTipoDeOperacionesBasicas.Items.AddRange(new object[] {
            "Suma",
            "Resta ",
            "Multiplicación",
            "División"});
            this.CtxTipoDeOperacionesBasicas.Location = new System.Drawing.Point(17, 26);
            this.CtxTipoDeOperacionesBasicas.Margin = new System.Windows.Forms.Padding(2);
            this.CtxTipoDeOperacionesBasicas.Name = "CtxTipoDeOperacionesBasicas";
            this.CtxTipoDeOperacionesBasicas.Size = new System.Drawing.Size(102, 28);
            this.CtxTipoDeOperacionesBasicas.TabIndex = 53;
            // 
            // GrbOperaciones
            // 
            this.GrbOperaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GrbOperaciones.Controls.Add(this.ChbAvanzadas);
            this.GrbOperaciones.Controls.Add(this.ChbBasicas);
            this.GrbOperaciones.Font = new System.Drawing.Font("Stencil", 12.75F);
            this.GrbOperaciones.Location = new System.Drawing.Point(91, 191);
            this.GrbOperaciones.Name = "GrbOperaciones";
            this.GrbOperaciones.Size = new System.Drawing.Size(264, 67);
            this.GrbOperaciones.TabIndex = 54;
            this.GrbOperaciones.TabStop = false;
            this.GrbOperaciones.Text = "OPERACIONES";
            // 
            // ChbBasicas
            // 
            this.ChbBasicas.AutoSize = true;
            this.ChbBasicas.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.ChbBasicas.Location = new System.Drawing.Point(17, 27);
            this.ChbBasicas.Name = "ChbBasicas";
            this.ChbBasicas.Size = new System.Drawing.Size(78, 20);
            this.ChbBasicas.TabIndex = 11;
            this.ChbBasicas.Text = "Básicas";
            this.ChbBasicas.UseVisualStyleBackColor = true;
            // 
            // ChbAvanzadas
            // 
            this.ChbAvanzadas.AutoSize = true;
            this.ChbAvanzadas.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.ChbAvanzadas.Location = new System.Drawing.Point(133, 27);
            this.ChbAvanzadas.Name = "ChbAvanzadas";
            this.ChbAvanzadas.Size = new System.Drawing.Size(102, 20);
            this.ChbAvanzadas.TabIndex = 12;
            this.ChbAvanzadas.Text = "Avanzadas";
            this.ChbAvanzadas.UseVisualStyleBackColor = true;
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(430, 740);
            this.Controls.Add(this.GrbOperaciones);
            this.Controls.Add(this.TxtRespuesta);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.GrbTipoDeOperaciones);
            this.Controls.Add(this.LbTitulo);
            this.Controls.Add(this.GrbNumeros);
            this.Name = "FrmCalculadora";
            this.Text = "WCalculadora";
            this.Load += new System.EventHandler(this.FrmCalculadora_Load);
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
        private System.Windows.Forms.CheckBox ChbAvanzadas;
        private System.Windows.Forms.CheckBox ChbBasicas;
    }
}

