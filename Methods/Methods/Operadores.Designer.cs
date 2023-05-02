namespace MathsOperators
{
    partial class Operadores
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
            this.txtOperIzq = new System.Windows.Forms.TextBox();
            this.txtOperDcha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbSuma = new System.Windows.Forms.RadioButton();
            this.rbResta = new System.Windows.Forms.RadioButton();
            this.rbMultiplicacion = new System.Windows.Forms.RadioButton();
            this.rbDivision = new System.Windows.Forms.RadioButton();
            this.rbResto = new System.Windows.Forms.RadioButton();
            this.lblExpresion = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOperIzq
            // 
            this.txtOperIzq.Location = new System.Drawing.Point(26, 83);
            this.txtOperIzq.Name = "txtOperIzq";
            this.txtOperIzq.Size = new System.Drawing.Size(100, 20);
            this.txtOperIzq.TabIndex = 0;
            // 
            // txtOperDcha
            // 
            this.txtOperDcha.Location = new System.Drawing.Point(303, 83);
            this.txtOperDcha.Name = "txtOperDcha";
            this.txtOperDcha.Size = new System.Drawing.Size(100, 20);
            this.txtOperDcha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Operando Izquierda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Operando Derecha";
            // 
            // rbSuma
            // 
            this.rbSuma.AutoSize = true;
            this.rbSuma.Location = new System.Drawing.Point(174, 110);
            this.rbSuma.Name = "rbSuma";
            this.rbSuma.Size = new System.Drawing.Size(67, 17);
            this.rbSuma.TabIndex = 4;
            this.rbSuma.TabStop = true;
            this.rbSuma.Text = "[+] Suma";
            this.rbSuma.UseVisualStyleBackColor = true;
            // 
            // rbResta
            // 
            this.rbResta.AutoSize = true;
            this.rbResta.Location = new System.Drawing.Point(174, 144);
            this.rbResta.Name = "rbResta";
            this.rbResta.Size = new System.Drawing.Size(65, 17);
            this.rbResta.TabIndex = 5;
            this.rbResta.TabStop = true;
            this.rbResta.Text = "[-] Resta";
            this.rbResta.UseVisualStyleBackColor = true;
            // 
            // rbMultiplicacion
            // 
            this.rbMultiplicacion.AutoSize = true;
            this.rbMultiplicacion.Location = new System.Drawing.Point(174, 179);
            this.rbMultiplicacion.Name = "rbMultiplicacion";
            this.rbMultiplicacion.Size = new System.Drawing.Size(102, 17);
            this.rbMultiplicacion.TabIndex = 6;
            this.rbMultiplicacion.TabStop = true;
            this.rbMultiplicacion.Text = "[*] Multiplicación";
            this.rbMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // rbDivision
            // 
            this.rbDivision.AutoSize = true;
            this.rbDivision.Location = new System.Drawing.Point(174, 216);
            this.rbDivision.Name = "rbDivision";
            this.rbDivision.Size = new System.Drawing.Size(76, 17);
            this.rbDivision.TabIndex = 7;
            this.rbDivision.TabStop = true;
            this.rbDivision.Text = "[/] División";
            this.rbDivision.UseVisualStyleBackColor = true;
            // 
            // rbResto
            // 
            this.rbResto.AutoSize = true;
            this.rbResto.Location = new System.Drawing.Point(174, 254);
            this.rbResto.Name = "rbResto";
            this.rbResto.Size = new System.Drawing.Size(70, 17);
            this.rbResto.TabIndex = 8;
            this.rbResto.TabStop = true;
            this.rbResto.Text = "[%] Resto";
            this.rbResto.UseVisualStyleBackColor = true;
            // 
            // lblExpresion
            // 
            this.lblExpresion.AutoSize = true;
            this.lblExpresion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpresion.Location = new System.Drawing.Point(23, 332);
            this.lblExpresion.Name = "lblExpresion";
            this.lblExpresion.Size = new System.Drawing.Size(85, 16);
            this.lblExpresion.TabIndex = 9;
            this.lblExpresion.Text = "Expresión: ";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(26, 294);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.CalcularClick);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(23, 369);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(87, 16);
            this.lblResultado.TabIndex = 11;
            this.lblResultado.Text = "Resultado: ";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(26, 416);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.SalirClick);
            // 
            // Operadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 479);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblExpresion);
            this.Controls.Add(this.rbResto);
            this.Controls.Add(this.rbDivision);
            this.Controls.Add(this.rbMultiplicacion);
            this.Controls.Add(this.rbResta);
            this.Controls.Add(this.rbSuma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOperDcha);
            this.Controls.Add(this.txtOperIzq);
            this.Name = "Operadores";
            this.Text = "MathsOperators";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOperIzq;
        private System.Windows.Forms.TextBox txtOperDcha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbSuma;
        private System.Windows.Forms.RadioButton rbResta;
        private System.Windows.Forms.RadioButton rbMultiplicacion;
        private System.Windows.Forms.RadioButton rbDivision;
        private System.Windows.Forms.RadioButton rbResto;
        private System.Windows.Forms.Label lblExpresion;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnSalir;
    }
}

