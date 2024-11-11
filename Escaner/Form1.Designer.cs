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
            this.identidicador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorIdentificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineaIdentificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaConstantes = new System.Windows.Forms.DataGridView();
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
            this.cajaDeTexto.Location = new System.Drawing.Point(12, 12);
            this.cajaDeTexto.Name = "cajaDeTexto";
            this.cajaDeTexto.Size = new System.Drawing.Size(894, 201);
            this.cajaDeTexto.TabIndex = 0;
            this.cajaDeTexto.Text = "";
            this.cajaDeTexto.WordWrap = false;
            // 
            // barraError
            // 
            this.barraError.Controls.Add(this.lblError);
            this.barraError.Controls.Add(this.lblMensaje);
            this.barraError.Location = new System.Drawing.Point(12, 219);
            this.barraError.Name = "barraError";
            this.barraError.Size = new System.Drawing.Size(894, 34);
            this.barraError.TabIndex = 1;
            this.barraError.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(90, 7);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(109, 20);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "100 - Sin error";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(6, 7);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(78, 20);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "Mensaje |";
            // 
            // btnValidar
            // 
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Location = new System.Drawing.Point(153, 259);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 30);
            this.btnValidar.TabIndex = 2;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(661, 259);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 30);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
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
            this.tablaLexica.Location = new System.Drawing.Point(12, 312);
            this.tablaLexica.Name = "tablaLexica";
            this.tablaLexica.ReadOnly = true;
            this.tablaLexica.RowHeadersVisible = false;
            this.tablaLexica.Size = new System.Drawing.Size(894, 150);
            this.tablaLexica.TabIndex = 5;
            // 
            // num
            // 
            this.num.HeaderText = "No.";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            this.num.Width = 150;
            // 
            // linea
            // 
            this.linea.HeaderText = "Linea";
            this.linea.Name = "linea";
            this.linea.ReadOnly = true;
            this.linea.Width = 180;
            // 
            // token
            // 
            this.token.HeaderText = "Token";
            this.token.Name = "token";
            this.token.ReadOnly = true;
            this.token.Width = 200;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 180;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 180;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tabla Identificadores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(657, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Constantes";
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
            this.tablaIdentificadores.Location = new System.Drawing.Point(12, 488);
            this.tablaIdentificadores.Name = "tablaIdentificadores";
            this.tablaIdentificadores.ReadOnly = true;
            this.tablaIdentificadores.RowHeadersVisible = false;
            this.tablaIdentificadores.Size = new System.Drawing.Size(411, 150);
            this.tablaIdentificadores.TabIndex = 8;
            // 
            // identidicador
            // 
            this.identidicador.HeaderText = "Identificador";
            this.identidicador.Name = "identidicador";
            this.identidicador.ReadOnly = true;
            this.identidicador.Width = 180;
            // 
            // valorIdentificador
            // 
            this.valorIdentificador.HeaderText = "Valor";
            this.valorIdentificador.Name = "valorIdentificador";
            this.valorIdentificador.ReadOnly = true;
            // 
            // lineaIdentificador
            // 
            this.lineaIdentificador.HeaderText = "Linea";
            this.lineaIdentificador.Name = "lineaIdentificador";
            this.lineaIdentificador.ReadOnly = true;
            this.lineaIdentificador.Width = 128;
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
            this.tablaConstantes.Location = new System.Drawing.Point(494, 488);
            this.tablaConstantes.Name = "tablaConstantes";
            this.tablaConstantes.ReadOnly = true;
            this.tablaConstantes.RowHeadersVisible = false;
            this.tablaConstantes.Size = new System.Drawing.Size(412, 150);
            this.tablaConstantes.TabIndex = 9;
            // 
            // constante
            // 
            this.constante.HeaderText = "Constante";
            this.constante.Name = "constante";
            this.constante.ReadOnly = true;
            this.constante.Width = 180;
            // 
            // valorConstante
            // 
            this.valorConstante.HeaderText = "Valor";
            this.valorConstante.Name = "valorConstante";
            this.valorConstante.ReadOnly = true;
            // 
            // lineaConstante
            // 
            this.lineaConstante.HeaderText = "Linea";
            this.lineaConstante.Name = "lineaConstante";
            this.lineaConstante.ReadOnly = true;
            this.lineaConstante.Width = 128;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 650);
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

