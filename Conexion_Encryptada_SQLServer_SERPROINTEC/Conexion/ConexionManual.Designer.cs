﻿namespace Conexion_Encryptada_SQLServer_SERPROINTEC.Conexion
{
    partial class ConexionManual
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
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Conexion = new System.Windows.Forms.Button();
            this.txtCnString = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(476, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Una vez que estes listo dale a \"Generar cadena de conexion\", se creara un Archivo" +
    " que contendra\r\ntu conexion Encryptada. Ahora tu conexion es mas Segura ante Pos" +
    "ibles hackers\r\n";
            // 
            // Btn_Conexion
            // 
            this.Btn_Conexion.BackColor = System.Drawing.Color.Black;
            this.Btn_Conexion.FlatAppearance.BorderSize = 0;
            this.Btn_Conexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Conexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Conexion.ForeColor = System.Drawing.Color.White;
            this.Btn_Conexion.Location = new System.Drawing.Point(12, 173);
            this.Btn_Conexion.Name = "Btn_Conexion";
            this.Btn_Conexion.Size = new System.Drawing.Size(315, 34);
            this.Btn_Conexion.TabIndex = 4;
            this.Btn_Conexion.Text = "Generar cadena de conexion";
            this.Btn_Conexion.UseVisualStyleBackColor = false;
            this.Btn_Conexion.Click += new System.EventHandler(this.Btn_Conexion_Click);
            // 
            // txtCnString
            // 
            this.txtCnString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCnString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnString.Location = new System.Drawing.Point(12, 96);
            this.txtCnString.Multiline = true;
            this.txtCnString.Name = "txtCnString";
            this.txtCnString.Size = new System.Drawing.Size(624, 71);
            this.txtCnString.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingrese la cadena de conexion LOCAL";
            // 
            // ConexionManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 216);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCnString);
            this.Controls.Add(this.Btn_Conexion);
            this.Controls.Add(this.label2);
            this.Name = "ConexionManual";
            this.Text = "ConexionManual";
            this.Load += new System.EventHandler(this.ConexionManual_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Conexion;
        private System.Windows.Forms.TextBox txtCnString;
        private System.Windows.Forms.Label label3;
    }
}