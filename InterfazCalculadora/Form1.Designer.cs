namespace InterfazCalculadora
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnDivisión = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplicación = new System.Windows.Forms.Button();
            this.txtSuma1 = new System.Windows.Forms.TextBox();
            this.txtSuma2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultadoSuma = new System.Windows.Forms.TextBox();
            this.txtResultadoResta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtResta2 = new System.Windows.Forms.TextBox();
            this.txtResta1 = new System.Windows.Forms.TextBox();
            this.txtResultadoMultiplicacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMultiplicacion2 = new System.Windows.Forms.TextBox();
            this.txtMultiplicación1 = new System.Windows.Forms.TextBox();
            this.txtResultadoDivision = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDivision2 = new System.Windows.Forms.TextBox();
            this.txtDivision1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOLA BIENVENIDO!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese la operación que desea realizar";
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(126, 121);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 23);
            this.btnSuma.TabIndex = 2;
            this.btnSuma.Text = "Suma";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnDivisión
            // 
            this.btnDivisión.Location = new System.Drawing.Point(126, 257);
            this.btnDivisión.Name = "btnDivisión";
            this.btnDivisión.Size = new System.Drawing.Size(119, 23);
            this.btnDivisión.TabIndex = 3;
            this.btnDivisión.Text = "División";
            this.btnDivisión.UseVisualStyleBackColor = true;
            this.btnDivisión.Click += new System.EventHandler(this.btnDivisión_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(126, 164);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(75, 23);
            this.btnResta.TabIndex = 4;
            this.btnResta.Text = "Resta";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnMultiplicación
            // 
            this.btnMultiplicación.Location = new System.Drawing.Point(126, 209);
            this.btnMultiplicación.Name = "btnMultiplicación";
            this.btnMultiplicación.Size = new System.Drawing.Size(119, 23);
            this.btnMultiplicación.TabIndex = 5;
            this.btnMultiplicación.Text = "Multiplicación";
            this.btnMultiplicación.UseVisualStyleBackColor = true;
            this.btnMultiplicación.Click += new System.EventHandler(this.btnMultiplicación_Click);
            // 
            // txtSuma1
            // 
            this.txtSuma1.Location = new System.Drawing.Point(225, 122);
            this.txtSuma1.Name = "txtSuma1";
            this.txtSuma1.Size = new System.Drawing.Size(100, 22);
            this.txtSuma1.TabIndex = 6;
            // 
            // txtSuma2
            // 
            this.txtSuma2.Location = new System.Drawing.Point(353, 122);
            this.txtSuma2.Name = "txtSuma2";
            this.txtSuma2.Size = new System.Drawing.Size(100, 22);
            this.txtSuma2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "=";
            // 
            // txtResultadoSuma
            // 
            this.txtResultadoSuma.Location = new System.Drawing.Point(479, 121);
            this.txtResultadoSuma.Name = "txtResultadoSuma";
            this.txtResultadoSuma.Size = new System.Drawing.Size(100, 22);
            this.txtResultadoSuma.TabIndex = 10;
            // 
            // txtResultadoResta
            // 
            this.txtResultadoResta.Location = new System.Drawing.Point(479, 163);
            this.txtResultadoResta.Name = "txtResultadoResta";
            this.txtResultadoResta.Size = new System.Drawing.Size(100, 22);
            this.txtResultadoResta.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(459, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "-";
            // 
            // txtResta2
            // 
            this.txtResta2.Location = new System.Drawing.Point(353, 164);
            this.txtResta2.Name = "txtResta2";
            this.txtResta2.Size = new System.Drawing.Size(100, 22);
            this.txtResta2.TabIndex = 12;
            // 
            // txtResta1
            // 
            this.txtResta1.Location = new System.Drawing.Point(225, 164);
            this.txtResta1.Name = "txtResta1";
            this.txtResta1.Size = new System.Drawing.Size(100, 22);
            this.txtResta1.TabIndex = 11;
            // 
            // txtResultadoMultiplicacion
            // 
            this.txtResultadoMultiplicacion.Location = new System.Drawing.Point(513, 208);
            this.txtResultadoMultiplicacion.Name = "txtResultadoMultiplicacion";
            this.txtResultadoMultiplicacion.Size = new System.Drawing.Size(100, 22);
            this.txtResultadoMultiplicacion.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(493, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "*";
            // 
            // txtMultiplicacion2
            // 
            this.txtMultiplicacion2.Location = new System.Drawing.Point(387, 209);
            this.txtMultiplicacion2.Name = "txtMultiplicacion2";
            this.txtMultiplicacion2.Size = new System.Drawing.Size(100, 22);
            this.txtMultiplicacion2.TabIndex = 17;
            // 
            // txtMultiplicación1
            // 
            this.txtMultiplicación1.Location = new System.Drawing.Point(259, 209);
            this.txtMultiplicación1.Name = "txtMultiplicación1";
            this.txtMultiplicación1.Size = new System.Drawing.Size(100, 22);
            this.txtMultiplicación1.TabIndex = 16;
            // 
            // txtResultadoDivision
            // 
            this.txtResultadoDivision.Location = new System.Drawing.Point(513, 256);
            this.txtResultadoDivision.Name = "txtResultadoDivision";
            this.txtResultadoDivision.Size = new System.Drawing.Size(100, 22);
            this.txtResultadoDivision.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(493, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "=";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(367, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "/";
            // 
            // txtDivision2
            // 
            this.txtDivision2.Location = new System.Drawing.Point(387, 257);
            this.txtDivision2.Name = "txtDivision2";
            this.txtDivision2.Size = new System.Drawing.Size(100, 22);
            this.txtDivision2.TabIndex = 22;
            // 
            // txtDivision1
            // 
            this.txtDivision1.Location = new System.Drawing.Point(259, 257);
            this.txtDivision1.Name = "txtDivision1";
            this.txtDivision1.Size = new System.Drawing.Size(100, 22);
            this.txtDivision1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResultadoDivision);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDivision2);
            this.Controls.Add(this.txtDivision1);
            this.Controls.Add(this.txtResultadoMultiplicacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMultiplicacion2);
            this.Controls.Add(this.txtMultiplicación1);
            this.Controls.Add(this.txtResultadoResta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtResta2);
            this.Controls.Add(this.txtResta1);
            this.Controls.Add(this.txtResultadoSuma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSuma2);
            this.Controls.Add(this.txtSuma1);
            this.Controls.Add(this.btnMultiplicación);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnDivisión);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnDivisión;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplicación;
        private System.Windows.Forms.TextBox txtSuma1;
        private System.Windows.Forms.TextBox txtSuma2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResultadoSuma;
        private System.Windows.Forms.TextBox txtResultadoResta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtResta2;
        private System.Windows.Forms.TextBox txtResta1;
        private System.Windows.Forms.TextBox txtResultadoMultiplicacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMultiplicacion2;
        private System.Windows.Forms.TextBox txtMultiplicación1;
        private System.Windows.Forms.TextBox txtResultadoDivision;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDivision2;
        private System.Windows.Forms.TextBox txtDivision1;
    }
}

