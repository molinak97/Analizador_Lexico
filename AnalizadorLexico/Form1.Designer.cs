﻿namespace AnalizadorLexico
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
            this.DetalladoGrid = new System.Windows.Forms.DataGridView();
            this.Detallado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonSeparar = new System.Windows.Forms.Button();
            this.TextoCopia = new System.Windows.Forms.TextBox();
            this.TextoOrigen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DetalladoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DetalladoGrid
            // 
            this.DetalladoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalladoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detallado});
            this.DetalladoGrid.Location = new System.Drawing.Point(46, 249);
            this.DetalladoGrid.Name = "DetalladoGrid";
            this.DetalladoGrid.Size = new System.Drawing.Size(708, 167);
            this.DetalladoGrid.TabIndex = 7;
            // 
            // Detallado
            // 
            this.Detallado.HeaderText = "Detallado";
            this.Detallado.Name = "Detallado";
            // 
            // ButtonSeparar
            // 
            this.ButtonSeparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSeparar.Location = new System.Drawing.Point(349, 126);
            this.ButtonSeparar.Name = "ButtonSeparar";
            this.ButtonSeparar.Size = new System.Drawing.Size(109, 50);
            this.ButtonSeparar.TabIndex = 6;
            this.ButtonSeparar.Text = "Fragmentar";
            this.ButtonSeparar.UseVisualStyleBackColor = true;
            this.ButtonSeparar.Click += new System.EventHandler(this.ButtonSeparar_Click);
            // 
            // TextoCopia
            // 
            this.TextoCopia.Location = new System.Drawing.Point(496, 35);
            this.TextoCopia.Multiline = true;
            this.TextoCopia.Name = "TextoCopia";
            this.TextoCopia.Size = new System.Drawing.Size(258, 141);
            this.TextoCopia.TabIndex = 5;
            // 
            // TextoOrigen
            // 
            this.TextoOrigen.Location = new System.Drawing.Point(46, 35);
            this.TextoOrigen.Multiline = true;
            this.TextoOrigen.Name = "TextoOrigen";
            this.TextoOrigen.Size = new System.Drawing.Size(258, 141);
            this.TextoOrigen.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DetalladoGrid);
            this.Controls.Add(this.ButtonSeparar);
            this.Controls.Add(this.TextoCopia);
            this.Controls.Add(this.TextoOrigen);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DetalladoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DetalladoGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detallado;
        private System.Windows.Forms.Button ButtonSeparar;
        private System.Windows.Forms.TextBox TextoCopia;
        private System.Windows.Forms.TextBox TextoOrigen;
    }
}

