namespace DoStatement
{
    partial class Principal
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnMostrarPasos = new System.Windows.Forms.Button();
            this.txtPasos = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar un Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(29, 180);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(134, 29);
            this.txtNumero.TabIndex = 1;
            // 
            // btnMostrarPasos
            // 
            this.btnMostrarPasos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarPasos.Location = new System.Drawing.Point(29, 250);
            this.btnMostrarPasos.Name = "btnMostrarPasos";
            this.btnMostrarPasos.Size = new System.Drawing.Size(134, 42);
            this.btnMostrarPasos.TabIndex = 2;
            this.btnMostrarPasos.Text = "Mostrar Pasos";
            this.btnMostrarPasos.UseVisualStyleBackColor = true;
            this.btnMostrarPasos.Click += new System.EventHandler(this.ShowStepsClick);
            // 
            // txtPasos
            // 
            this.txtPasos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasos.Location = new System.Drawing.Point(302, 31);
            this.txtPasos.Name = "txtPasos";
            this.txtPasos.Size = new System.Drawing.Size(151, 353);
            this.txtPasos.TabIndex = 4;
            this.txtPasos.Text = "";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 412);
            this.Controls.Add(this.txtPasos);
            this.Controls.Add(this.btnMostrarPasos);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Name = "Principal";
            this.Text = "Do Statement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnMostrarPasos;
        private System.Windows.Forms.RichTextBox txtPasos;
    }
}

