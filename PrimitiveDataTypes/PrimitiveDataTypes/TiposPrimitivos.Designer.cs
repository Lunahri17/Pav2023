namespace PrimitiveDataTypes
{
    partial class TiposPrimitivos
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
            this.lbTipos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEjemplo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTipos
            // 
            this.lbTipos.FormattingEnabled = true;
            this.lbTipos.Items.AddRange(new object[] {
            "int",
            "long",
            "float",
            "double",
            "decimal",
            "string",
            "char",
            "bool"});
            this.lbTipos.Location = new System.Drawing.Point(26, 88);
            this.lbTipos.Name = "lbTipos";
            this.lbTipos.Size = new System.Drawing.Size(120, 121);
            this.lbTipos.TabIndex = 0;
            this.lbTipos.SelectedValueChanged += new System.EventHandler(this.TiposSelectedValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccionar el Tipo de Dato";
            // 
            // txtEjemplo
            // 
            this.txtEjemplo.Location = new System.Drawing.Point(191, 88);
            this.txtEjemplo.Name = "txtEjemplo";
            this.txtEjemplo.Size = new System.Drawing.Size(155, 20);
            this.txtEjemplo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor de Ejemplo";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(232, 186);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.SalirClick);
            // 
            // TiposPrimitivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 259);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEjemplo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTipos);
            this.Name = "TiposPrimitivos";
            this.Text = "PrimitiveDataTypes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTipos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEjemplo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
    }
}

