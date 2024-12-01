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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.tablaExpresiones = new System.Windows.Forms.DataGridView();
            this.numInvalido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expression = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barraError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaLexica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaIdentificadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaConstantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaExpresiones)).BeginInit();
            this.SuspendLayout();
            // 
            // cajaDeTexto
            // 
            this.cajaDeTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaDeTexto.Location = new System.Drawing.Point(18, 18);
            this.cajaDeTexto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cajaDeTexto.Name = "cajaDeTexto";
            this.cajaDeTexto.Size = new System.Drawing.Size(1541, 307);
            this.cajaDeTexto.TabIndex = 0;
            this.cajaDeTexto.Text = "";
            this.cajaDeTexto.WordWrap = false;
            // 
            // barraError
            // 
            this.barraError.Controls.Add(this.lblError);
            this.barraError.Controls.Add(this.lblMensaje);
            this.barraError.Location = new System.Drawing.Point(18, 337);
            this.barraError.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barraError.Name = "barraError";
            this.barraError.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barraError.Size = new System.Drawing.Size(1541, 52);
            this.barraError.TabIndex = 1;
            this.barraError.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(135, 11);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(165, 29);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "100 - Sin error";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(9, 11);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(117, 29);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "Mensaje |";
            // 
            // btnValidar
            // 
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Location = new System.Drawing.Point(230, 398);
            this.btnValidar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(112, 46);
            this.btnValidar.TabIndex = 2;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(1243, 399);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(112, 46);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(626, 445);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tabla Léxica";
            // 
            // tablaLexica
            // 
            this.tablaLexica.AllowUserToAddRows = false;
            this.tablaLexica.AllowUserToDeleteRows = false;
            this.tablaLexica.AllowUserToResizeColumns = false;
            this.tablaLexica.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaLexica.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.tablaLexica.ColumnHeadersHeight = 30;
            this.tablaLexica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.linea,
            this.token,
            this.tipo,
            this.codigo});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaLexica.DefaultCellStyle = dataGridViewCellStyle14;
            this.tablaLexica.Location = new System.Drawing.Point(18, 480);
            this.tablaLexica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablaLexica.Name = "tablaLexica";
            this.tablaLexica.ReadOnly = true;
            this.tablaLexica.RowHeadersVisible = false;
            this.tablaLexica.RowHeadersWidth = 62;
            this.tablaLexica.Size = new System.Drawing.Size(1041, 231);
            this.tablaLexica.TabIndex = 5;
            // 
            // num
            // 
            this.num.HeaderText = "No.";
            this.num.MinimumWidth = 8;
            this.num.Name = "num";
            this.num.ReadOnly = true;
            this.num.Width = 150;
            // 
            // linea
            // 
            this.linea.HeaderText = "Linea";
            this.linea.MinimumWidth = 8;
            this.linea.Name = "linea";
            this.linea.ReadOnly = true;
            this.linea.Width = 180;
            // 
            // token
            // 
            this.token.HeaderText = "Token";
            this.token.MinimumWidth = 8;
            this.token.Name = "token";
            this.token.ReadOnly = true;
            this.token.Width = 200;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.MinimumWidth = 8;
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 180;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.MinimumWidth = 8;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 180;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 716);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tabla Identificadores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(762, 716);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Constantes";
            // 
            // tablaIdentificadores
            // 
            this.tablaIdentificadores.AllowUserToAddRows = false;
            this.tablaIdentificadores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaIdentificadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.tablaIdentificadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaIdentificadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identidicador,
            this.valorIdentificador,
            this.lineaIdentificador});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaIdentificadores.DefaultCellStyle = dataGridViewCellStyle16;
            this.tablaIdentificadores.Location = new System.Drawing.Point(18, 751);
            this.tablaIdentificadores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablaIdentificadores.Name = "tablaIdentificadores";
            this.tablaIdentificadores.ReadOnly = true;
            this.tablaIdentificadores.RowHeadersVisible = false;
            this.tablaIdentificadores.RowHeadersWidth = 62;
            this.tablaIdentificadores.Size = new System.Drawing.Size(510, 231);
            this.tablaIdentificadores.TabIndex = 8;
            // 
            // identidicador
            // 
            this.identidicador.HeaderText = "Identificador";
            this.identidicador.MinimumWidth = 8;
            this.identidicador.Name = "identidicador";
            this.identidicador.ReadOnly = true;
            this.identidicador.Width = 180;
            // 
            // valorIdentificador
            // 
            this.valorIdentificador.HeaderText = "Valor";
            this.valorIdentificador.MinimumWidth = 8;
            this.valorIdentificador.Name = "valorIdentificador";
            this.valorIdentificador.ReadOnly = true;
            this.valorIdentificador.Width = 150;
            // 
            // lineaIdentificador
            // 
            this.lineaIdentificador.HeaderText = "Linea";
            this.lineaIdentificador.MinimumWidth = 8;
            this.lineaIdentificador.Name = "lineaIdentificador";
            this.lineaIdentificador.ReadOnly = true;
            this.lineaIdentificador.Width = 128;
            // 
            // tablaConstantes
            // 
            this.tablaConstantes.AllowUserToAddRows = false;
            this.tablaConstantes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaConstantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.tablaConstantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaConstantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.constante,
            this.valorConstante,
            this.lineaConstante});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaConstantes.DefaultCellStyle = dataGridViewCellStyle18;
            this.tablaConstantes.Location = new System.Drawing.Point(561, 749);
            this.tablaConstantes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablaConstantes.Name = "tablaConstantes";
            this.tablaConstantes.ReadOnly = true;
            this.tablaConstantes.RowHeadersVisible = false;
            this.tablaConstantes.RowHeadersWidth = 62;
            this.tablaConstantes.Size = new System.Drawing.Size(498, 231);
            this.tablaConstantes.TabIndex = 9;
            // 
            // constante
            // 
            this.constante.HeaderText = "Constante";
            this.constante.MinimumWidth = 8;
            this.constante.Name = "constante";
            this.constante.ReadOnly = true;
            this.constante.Width = 180;
            // 
            // valorConstante
            // 
            this.valorConstante.HeaderText = "Valor";
            this.valorConstante.MinimumWidth = 8;
            this.valorConstante.Name = "valorConstante";
            this.valorConstante.ReadOnly = true;
            this.valorConstante.Width = 150;
            // 
            // lineaConstante
            // 
            this.lineaConstante.HeaderText = "Linea";
            this.lineaConstante.MinimumWidth = 8;
            this.lineaConstante.Name = "lineaConstante";
            this.lineaConstante.ReadOnly = true;
            this.lineaConstante.Width = 128;
            // 
            // tablaExpresiones
            // 
            this.tablaExpresiones.AllowUserToAddRows = false;
            this.tablaExpresiones.AllowUserToDeleteRows = false;
            this.tablaExpresiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaExpresiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numInvalido,
            this.expression,
            this.type});
            this.tablaExpresiones.Location = new System.Drawing.Point(1086, 480);
            this.tablaExpresiones.Name = "tablaExpresiones";
            this.tablaExpresiones.ReadOnly = true;
            this.tablaExpresiones.RowHeadersVisible = false;
            this.tablaExpresiones.RowHeadersWidth = 62;
            this.tablaExpresiones.RowTemplate.Height = 28;
            this.tablaExpresiones.Size = new System.Drawing.Size(474, 500);
            this.tablaExpresiones.TabIndex = 10;
            // 
            // numInvalido
            // 
            this.numInvalido.HeaderText = "No.";
            this.numInvalido.MinimumWidth = 8;
            this.numInvalido.Name = "numInvalido";
            this.numInvalido.ReadOnly = true;
            this.numInvalido.Width = 70;
            // 
            // expression
            // 
            this.expression.HeaderText = "Expresion";
            this.expression.MinimumWidth = 8;
            this.expression.Name = "expression";
            this.expression.ReadOnly = true;
            this.expression.Width = 180;
            // 
            // type
            // 
            this.type.HeaderText = "Tipo";
            this.type.MinimumWidth = 8;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1572, 1000);
            this.Controls.Add(this.tablaExpresiones);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            ((System.ComponentModel.ISupportInitialize)(this.tablaExpresiones)).EndInit();
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
        private System.Windows.Forms.DataGridView tablaExpresiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn numInvalido;
        private System.Windows.Forms.DataGridViewTextBoxColumn expression;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
    }
}

