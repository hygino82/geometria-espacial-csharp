
namespace GeometriaEspacial
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMenorAresta = new System.Windows.Forms.Label();
            this.comboPoliedro = new System.Windows.Forms.ComboBox();
            this.comboBase = new System.Windows.Forms.ComboBox();
            this.txtMaiorAresta = new System.Windows.Forms.MaskedTextBox();
            this.txtAltura = new System.Windows.Forms.MaskedTextBox();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.txtMenorAresta = new System.Windows.Forms.MaskedTextBox();
            this.lista = new System.Windows.Forms.RichTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de poliedro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de base";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(423, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aresta maior";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(569, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Altura";
            // 
            // lbMenorAresta
            // 
            this.lbMenorAresta.AutoSize = true;
            this.lbMenorAresta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenorAresta.Location = new System.Drawing.Point(647, 9);
            this.lbMenorAresta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMenorAresta.Name = "lbMenorAresta";
            this.lbMenorAresta.Size = new System.Drawing.Size(143, 26);
            this.lbMenorAresta.TabIndex = 4;
            this.lbMenorAresta.Text = "Aresta menor\r\n";
            // 
            // comboPoliedro
            // 
            this.comboPoliedro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPoliedro.FormattingEnabled = true;
            this.comboPoliedro.Location = new System.Drawing.Point(14, 37);
            this.comboPoliedro.Margin = new System.Windows.Forms.Padding(2);
            this.comboPoliedro.Name = "comboPoliedro";
            this.comboPoliedro.Size = new System.Drawing.Size(195, 34);
            this.comboPoliedro.TabIndex = 5;
            this.comboPoliedro.SelectedIndexChanged += new System.EventHandler(this.comboPoliedro_SelectedIndexChanged);
            // 
            // comboBase
            // 
            this.comboBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBase.FormattingEnabled = true;
            this.comboBase.Location = new System.Drawing.Point(213, 37);
            this.comboBase.Margin = new System.Windows.Forms.Padding(2);
            this.comboBase.Name = "comboBase";
            this.comboBase.Size = new System.Drawing.Size(210, 34);
            this.comboBase.TabIndex = 6;
            // 
            // txtMaiorAresta
            // 
            this.txtMaiorAresta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaiorAresta.Location = new System.Drawing.Point(427, 39);
            this.txtMaiorAresta.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaiorAresta.Name = "txtMaiorAresta";
            this.txtMaiorAresta.Size = new System.Drawing.Size(128, 32);
            this.txtMaiorAresta.TabIndex = 7;
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(565, 39);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(2);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(76, 32);
            this.txtAltura.TabIndex = 8;
            // 
            // btnCalcula
            // 
            this.btnCalcula.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcula.Location = new System.Drawing.Point(796, 39);
            this.btnCalcula.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(122, 32);
            this.btnCalcula.TabIndex = 9;
            this.btnCalcula.Text = "Calcular";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // txtMenorAresta
            // 
            this.txtMenorAresta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenorAresta.Location = new System.Drawing.Point(651, 40);
            this.txtMenorAresta.Margin = new System.Windows.Forms.Padding(2);
            this.txtMenorAresta.Name = "txtMenorAresta";
            this.txtMenorAresta.Size = new System.Drawing.Size(134, 32);
            this.txtMenorAresta.TabIndex = 10;
            // 
            // lista
            // 
            this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.Location = new System.Drawing.Point(14, 106);
            this.lista.Margin = new System.Windows.Forms.Padding(2);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(904, 310);
            this.lista.TabIndex = 11;
            this.lista.Text = "";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(796, 4);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(122, 32);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 444);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.txtMenorAresta);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtMaiorAresta);
            this.Controls.Add(this.comboBase);
            this.Controls.Add(this.comboPoliedro);
            this.Controls.Add(this.lbMenorAresta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Geometria espacial calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMenorAresta;
        private System.Windows.Forms.ComboBox comboPoliedro;
        private System.Windows.Forms.ComboBox comboBase;
        private System.Windows.Forms.MaskedTextBox txtMaiorAresta;
        private System.Windows.Forms.MaskedTextBox txtAltura;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.MaskedTextBox txtMenorAresta;
        private System.Windows.Forms.RichTextBox lista;
        private System.Windows.Forms.Button btnLimpar;
    }
}

