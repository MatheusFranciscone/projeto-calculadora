namespace ativ_calculadora
{
    partial class frm_calculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_calculadora));
            this.txt_Valor1 = new System.Windows.Forms.TextBox();
            this.txt_Valor2 = new System.Windows.Forms.TextBox();
            this.btn_Soma = new System.Windows.Forms.Button();
            this.lbl_Valor1 = new System.Windows.Forms.Label();
            this.lbl_Valor2 = new System.Windows.Forms.Label();
            this.btn_Multiplicar = new System.Windows.Forms.Button();
            this.btn_Subtrair = new System.Windows.Forms.Button();
            this.btn_Dividir = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.lbl_calculadora = new System.Windows.Forms.Label();
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Valor1
            // 
            this.txt_Valor1.ForeColor = System.Drawing.Color.Navy;
            this.txt_Valor1.Location = new System.Drawing.Point(82, 55);
            this.txt_Valor1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Valor1.Name = "txt_Valor1";
            this.txt_Valor1.Size = new System.Drawing.Size(116, 23);
            this.txt_Valor1.TabIndex = 0;
            this.txt_Valor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Valor1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Valor1_KeyPress);
            // 
            // txt_Valor2
            // 
            this.txt_Valor2.ForeColor = System.Drawing.Color.Navy;
            this.txt_Valor2.Location = new System.Drawing.Point(82, 102);
            this.txt_Valor2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Valor2.Name = "txt_Valor2";
            this.txt_Valor2.Size = new System.Drawing.Size(116, 23);
            this.txt_Valor2.TabIndex = 1;
            this.txt_Valor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Valor2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Valor2_KeyPress);
            // 
            // btn_Soma
            // 
            this.btn_Soma.BackColor = System.Drawing.Color.Navy;
            this.btn_Soma.ForeColor = System.Drawing.Color.White;
            this.btn_Soma.Location = new System.Drawing.Point(238, 47);
            this.btn_Soma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Soma.Name = "btn_Soma";
            this.btn_Soma.Size = new System.Drawing.Size(87, 38);
            this.btn_Soma.TabIndex = 2;
            this.btn_Soma.Text = "Somar";
            this.btn_Soma.UseVisualStyleBackColor = false;
            this.btn_Soma.Click += new System.EventHandler(this.btn_Soma_Click);
            // 
            // lbl_Valor1
            // 
            this.lbl_Valor1.AutoSize = true;
            this.lbl_Valor1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Valor1.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Valor1.Location = new System.Drawing.Point(9, 59);
            this.lbl_Valor1.Name = "lbl_Valor1";
            this.lbl_Valor1.Size = new System.Drawing.Size(67, 19);
            this.lbl_Valor1.TabIndex = 4;
            this.lbl_Valor1.Text = "Valor 1:";
            // 
            // lbl_Valor2
            // 
            this.lbl_Valor2.AutoSize = true;
            this.lbl_Valor2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Valor2.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Valor2.Location = new System.Drawing.Point(9, 106);
            this.lbl_Valor2.Name = "lbl_Valor2";
            this.lbl_Valor2.Size = new System.Drawing.Size(67, 19);
            this.lbl_Valor2.TabIndex = 5;
            this.lbl_Valor2.Text = "Valor 2:";
            // 
            // btn_Multiplicar
            // 
            this.btn_Multiplicar.BackColor = System.Drawing.Color.Navy;
            this.btn_Multiplicar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Multiplicar.ForeColor = System.Drawing.Color.White;
            this.btn_Multiplicar.Location = new System.Drawing.Point(238, 94);
            this.btn_Multiplicar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Multiplicar.Name = "btn_Multiplicar";
            this.btn_Multiplicar.Size = new System.Drawing.Size(87, 38);
            this.btn_Multiplicar.TabIndex = 6;
            this.btn_Multiplicar.Text = "Multiplicar";
            this.btn_Multiplicar.UseVisualStyleBackColor = false;
            this.btn_Multiplicar.Click += new System.EventHandler(this.btn_Multiplicar_Click);
            // 
            // btn_Subtrair
            // 
            this.btn_Subtrair.BackColor = System.Drawing.Color.Navy;
            this.btn_Subtrair.ForeColor = System.Drawing.Color.White;
            this.btn_Subtrair.Location = new System.Drawing.Point(331, 47);
            this.btn_Subtrair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Subtrair.Name = "btn_Subtrair";
            this.btn_Subtrair.Size = new System.Drawing.Size(87, 38);
            this.btn_Subtrair.TabIndex = 7;
            this.btn_Subtrair.Text = "Subtrair";
            this.btn_Subtrair.UseVisualStyleBackColor = false;
            this.btn_Subtrair.Click += new System.EventHandler(this.btn_Subtrair_Click);
            // 
            // btn_Dividir
            // 
            this.btn_Dividir.BackColor = System.Drawing.Color.Navy;
            this.btn_Dividir.ForeColor = System.Drawing.Color.White;
            this.btn_Dividir.Location = new System.Drawing.Point(331, 94);
            this.btn_Dividir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Dividir.Name = "btn_Dividir";
            this.btn_Dividir.Size = new System.Drawing.Size(87, 38);
            this.btn_Dividir.TabIndex = 8;
            this.btn_Dividir.Text = "Dividir";
            this.btn_Dividir.UseVisualStyleBackColor = false;
            this.btn_Dividir.Click += new System.EventHandler(this.btn_Dividir_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.Navy;
            this.btn_Sair.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.ForeColor = System.Drawing.Color.White;
            this.btn_Sair.Location = new System.Drawing.Point(284, 146);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(97, 38);
            this.btn_Sair.TabIndex = 9;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // lbl_calculadora
            // 
            this.lbl_calculadora.AutoSize = true;
            this.lbl_calculadora.BackColor = System.Drawing.Color.White;
            this.lbl_calculadora.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calculadora.ForeColor = System.Drawing.Color.Navy;
            this.lbl_calculadora.Location = new System.Drawing.Point(139, 9);
            this.lbl_calculadora.Name = "lbl_calculadora";
            this.lbl_calculadora.Size = new System.Drawing.Size(149, 27);
            this.lbl_calculadora.TabIndex = 10;
            this.lbl_calculadora.Text = "Calculadora";
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.Enabled = false;
            this.txt_Resultado.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Resultado.ForeColor = System.Drawing.Color.Navy;
            this.txt_Resultado.Location = new System.Drawing.Point(98, 149);
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.Size = new System.Drawing.Size(100, 25);
            this.txt_Resultado.TabIndex = 11;
            this.txt_Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.ForeColor = System.Drawing.Color.Navy;
            this.lbl_resultado.Location = new System.Drawing.Point(10, 157);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(82, 17);
            this.lbl_resultado.TabIndex = 12;
            this.lbl_resultado.Text = "Resultado:";
            // 
            // frm_calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 197);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.txt_Resultado);
            this.Controls.Add(this.lbl_calculadora);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Dividir);
            this.Controls.Add(this.btn_Subtrair);
            this.Controls.Add(this.btn_Multiplicar);
            this.Controls.Add(this.lbl_Valor2);
            this.Controls.Add(this.lbl_Valor1);
            this.Controls.Add(this.btn_Soma);
            this.Controls.Add(this.txt_Valor2);
            this.Controls.Add(this.txt_Valor1);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Valor1;
        private System.Windows.Forms.TextBox txt_Valor2;
        private System.Windows.Forms.Button btn_Soma;
        private System.Windows.Forms.Label lbl_Valor1;
        private System.Windows.Forms.Label lbl_Valor2;
        private System.Windows.Forms.Button btn_Multiplicar;
        private System.Windows.Forms.Button btn_Subtrair;
        private System.Windows.Forms.Button btn_Dividir;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Label lbl_calculadora;
        private System.Windows.Forms.TextBox txt_Resultado;
        private System.Windows.Forms.Label lbl_resultado;
    }
}

