namespace Escaner
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cajaDeTexto = new System.Windows.Forms.RichTextBox();
            this.barraError = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaLexica = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tablaIdentificadores = new System.Windows.Forms.DataGridView();
            this.tablaConstantes = new System.Windows.Forms.DataGridView();
            this.identidicador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorIdentificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineaIdentificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorConstante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineaConstante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barraError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaLexica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaIdentificadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaConstantes)).BeginInit();
            this.SuspendLayout();
            // 
            // cajaDeTexto
            // 
            this.cajaDeTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaDeTexto.Location = new System.Drawing.Point(16, 15);
            this.cajaDeTexto.Margin = new System.Windows.Forms.Padding(4);
            this.cajaDeTexto.Name = "cajaDeTexto";
            this.cajaDeTexto.Size = new System.Drawing.Size(1191, 246);
            this.cajaDeTexto.TabIndex = 0;
            this.cajaDeTexto.Text = "";
            this.cajaDeTexto.WordWrap = false;
            // 
            // barraError
            // 
            this.barraError.Controls.Add(this.lblError);
            this.barraError.Controls.Add(this.lblMensaje);
            this.barraError.Location = new System.Drawing.Point(16, 270);
            this.barraError.Margin = new System.Windows.Forms.Padding(4);
            this.barraError.Name = "barraError";
            this.barraError.Padding = new System.Windows.Forms.Padding(4);
            this.barraError.Size = new System.Drawing.Size(1192, 42);
            this.barraError.TabIndex = 1;
            this.barraError.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(120, 9);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(136, 25);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "100 - Sin error";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(8, 9);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(97, 25);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "Mensaje |";
            // 
            // btnValidar
            // 
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Location = new System.Drawing.Point(204, 319);
            this.btnValidar.Margin = new System.Windows.Forms.Padding(4);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(100, 37);
            this.btnValidar.TabIndex = 2;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(881, 319);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 37);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(556, 356);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tabla Léxica";
            // 
            // tablaLexica
            // 
            this.tablaLexica.AllowUserToAddRows = false;
            this.tablaLexica.AllowUserToDeleteRows = false;
            this.tablaLexica.AllowUserToResizeColumns = false;
            this.tablaLexica.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaLexica.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaLexica.ColumnHeadersHeight = 30;
            this.tablaLexica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.linea,
            this.token,
            this.tipo,
            this.codigo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaLexica.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaLexica.Location = new System.Drawing.Point(179, 383);
            this.tablaLexica.Margin = new System.Windows.Forms.Padding(4);
            this.tablaLexica.Name = "tablaLexica";
            this.tablaLexica.ReadOnly = true;
            this.tablaLexica.RowHeadersVisible = false;
            this.tablaLexica.RowHeadersWidth = 51;
            this.tablaLexica.Size = new System.Drawing.Size(893, 185);
            this.tablaLexica.TabIndex = 5;
            // 
            // num
            // 
            this.num.HeaderText = "No.";
            this.num.MinimumWidth = 6;
            this.num.Name = "num";
            this.num.ReadOnly = true;
            this.num.Width = 150;
            // 
            // linea
            // 
            this.linea.HeaderText = "Linea";
            this.linea.MinimumWidth = 6;
            this.linea.Name = "linea";
            this.linea.ReadOnly = true;
            this.linea.Width = 180;
            // 
            // token
            // 
            this.token.HeaderText = "Token";
            this.token.MinimumWidth = 6;
            this.token.Name = "token";
            this.token.ReadOnly = true;
            this.token.Width = 200;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.MinimumWidth = 6;
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 180;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 180;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 572);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Expresiones validas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(847, 572);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Expresiones invalidas";
            // 
            // tablaIdentificadores
            // 
            this.tablaIdentificadores.AllowUserToAddRows = false;
            this.tablaIdentificadores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaIdentificadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaIdentificadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaIdentificadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identidicador,
            this.valorIdentificador,
            this.lineaIdentificador});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaIdentificadores.DefaultCellStyle = dataGridViewCellStyle4;
            this.tablaIdentificadores.Location = new System.Drawing.Point(69, 601);
            this.tablaIdentificadores.Margin = new System.Windows.Forms.Padding(4);
            this.tablaIdentificadores.Name = "tablaIdentificadores";
            this.tablaIdentificadores.ReadOnly = true;
            this.tablaIdentificadores.RowHeadersVisible = false;
            this.tablaIdentificadores.RowHeadersWidth = 51;
            this.tablaIdentificadores.Size = new System.Drawing.Size(437, 185);
            this.tablaIdentificadores.TabIndex = 8;
            this.tablaIdentificadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaIdentificadores_CellContentClick);
            // 
            // tablaConstantes
            // 
            this.tablaConstantes.AllowUserToAddRows = false;
            this.tablaConstantes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaConstantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tablaConstantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaConstantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.constante,
            this.valorConstante,
            this.lineaConstante});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaConstantes.DefaultCellStyle = dataGridViewCellStyle6;
            this.tablaConstantes.Location = new System.Drawing.Point(723, 601);
            this.tablaConstantes.Margin = new System.Windows.Forms.Padding(4);
            this.tablaConstantes.Name = "tablaConstantes";
            this.tablaConstantes.ReadOnly = true;
            this.tablaConstantes.RowHeadersVisible = false;
            this.tablaConstantes.RowHeadersWidth = 51;
            this.tablaConstantes.Size = new System.Drawing.Size(437, 185);
            this.tablaConstantes.TabIndex = 9;
            this.tablaConstantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaConstantes_CellContentClick);
            // 
            // identidicador
            // 
            this.identidicador.HeaderText = "Num. Linea";
            this.identidicador.MinimumWidth = 6;
            this.identidicador.Name = "identidicador";
            this.identidicador.ReadOnly = true;
            this.identidicador.Width = 110;
            // 
            // valorIdentificador
            // 
            this.valorIdentificador.HeaderText = "Expresión";
            this.valorIdentificador.MinimumWidth = 6;
            this.valorIdentificador.Name = "valorIdentificador";
            this.valorIdentificador.ReadOnly = true;
            this.valorIdentificador.Width = 180;
            // 
            // lineaIdentificador
            // 
            this.lineaIdentificador.HeaderText = "Valida";
            this.lineaIdentificador.MinimumWidth = 6;
            this.lineaIdentificador.Name = "lineaIdentificador";
            this.lineaIdentificador.ReadOnly = true;
            this.lineaIdentificador.Width = 144;
            // 
            // constante
            // 
            this.constante.HeaderText = "Num. Linea";
            this.constante.MinimumWidth = 6;
            this.constante.Name = "constante";
            this.constante.ReadOnly = true;
            this.constante.Width = 110;
            // 
            // valorConstante
            // 
            this.valorConstante.HeaderText = "Expresión";
            this.valorConstante.MinimumWidth = 6;
            this.valorConstante.Name = "valorConstante";
            this.valorConstante.ReadOnly = true;
            this.valorConstante.Width = 160;
            // 
            // lineaConstante
            // 
            this.lineaConstante.HeaderText = "Invalida";
            this.lineaConstante.MinimumWidth = 6;
            this.lineaConstante.Name = "lineaConstante";
            this.lineaConstante.ReadOnly = true;
            this.lineaConstante.Width = 164;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 800);
            this.Controls.Add(this.tablaConstantes);
            this.Controls.Add(this.tablaIdentificadores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tablaLexica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.barraError);
            this.Controls.Add(this.cajaDeTexto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escaner";
            this.barraError.ResumeLayout(false);
            this.barraError.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaLexica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaIdentificadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaConstantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox cajaDeTexto;
        private System.Windows.Forms.GroupBox barraError;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaLexica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tablaIdentificadores;
        private System.Windows.Forms.DataGridView tablaConstantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn linea;
        private System.Windows.Forms.DataGridViewTextBoxColumn token;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn identidicador;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorIdentificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineaIdentificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn constante;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorConstante;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineaConstante;
    }
}

