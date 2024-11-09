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
            this.cajaDeTexto = new System.Windows.Forms.RichTextBox();
            this.barraError = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaLexica = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tablaIdentificadores = new System.Windows.Forms.DataGridView();
            this.tablaConstantes = new System.Windows.Forms.DataGridView();
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
            this.cajaDeTexto.Size = new System.Drawing.Size(933, 201);
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
            this.barraError.Size = new System.Drawing.Size(933, 34);
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
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(706, 259);
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
            this.tablaLexica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaLexica.Location = new System.Drawing.Point(12, 312);
            this.tablaLexica.Name = "tablaLexica";
            this.tablaLexica.ReadOnly = true;
            this.tablaLexica.Size = new System.Drawing.Size(933, 150);
            this.tablaLexica.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tabla Identificadores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(676, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Constantes";
            // 
            // tablaIdentificadores
            // 
            this.tablaIdentificadores.AllowUserToAddRows = false;
            this.tablaIdentificadores.AllowUserToDeleteRows = false;
            this.tablaIdentificadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaIdentificadores.Location = new System.Drawing.Point(12, 488);
            this.tablaIdentificadores.Name = "tablaIdentificadores";
            this.tablaIdentificadores.ReadOnly = true;
            this.tablaIdentificadores.Size = new System.Drawing.Size(452, 150);
            this.tablaIdentificadores.TabIndex = 8;
            // 
            // tablaConstantes
            // 
            this.tablaConstantes.AllowUserToAddRows = false;
            this.tablaConstantes.AllowUserToDeleteRows = false;
            this.tablaConstantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaConstantes.Location = new System.Drawing.Point(493, 488);
            this.tablaConstantes.Name = "tablaConstantes";
            this.tablaConstantes.ReadOnly = true;
            this.tablaConstantes.Size = new System.Drawing.Size(452, 150);
            this.tablaConstantes.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 650);
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
    }
}

