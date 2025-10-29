namespace ABB3
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnMinimo = new System.Windows.Forms.Button();
            this.btnMaximo = new System.Windows.Forms.Button();
            this.btnBalanceado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(262, 160);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(336, 338);
            this.treeView1.TabIndex = 29;
            // 
            // textNumero
            // 
            this.textNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumero.Location = new System.Drawing.Point(262, 112);
            this.textNumero.Margin = new System.Windows.Forms.Padding(2);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(336, 30);
            this.textNumero.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Ingrese número:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 42);
            this.label1.TabIndex = 26;
            this.label1.Text = "ÁRBOL BINARIO DE BUSQUEDA";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(56, 160);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(175, 51);
            this.btnInsertar.TabIndex = 30;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(56, 225);
            this.btnSuma.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(175, 51);
            this.btnSuma.TabIndex = 31;
            this.btnSuma.Text = "Suma";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnMinimo
            // 
            this.btnMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimo.Location = new System.Drawing.Point(56, 295);
            this.btnMinimo.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimo.Name = "btnMinimo";
            this.btnMinimo.Size = new System.Drawing.Size(175, 51);
            this.btnMinimo.TabIndex = 32;
            this.btnMinimo.Text = "Mínimo";
            this.btnMinimo.UseVisualStyleBackColor = true;
            this.btnMinimo.Click += new System.EventHandler(this.btnMinimo_Click);
            // 
            // btnMaximo
            // 
            this.btnMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximo.Location = new System.Drawing.Point(56, 363);
            this.btnMaximo.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximo.Name = "btnMaximo";
            this.btnMaximo.Size = new System.Drawing.Size(175, 51);
            this.btnMaximo.TabIndex = 33;
            this.btnMaximo.Text = "Máximo";
            this.btnMaximo.UseVisualStyleBackColor = true;
            this.btnMaximo.Click += new System.EventHandler(this.btnMaximo_Click);
            // 
            // btnBalanceado
            // 
            this.btnBalanceado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalanceado.Location = new System.Drawing.Point(56, 431);
            this.btnBalanceado.Margin = new System.Windows.Forms.Padding(2);
            this.btnBalanceado.Name = "btnBalanceado";
            this.btnBalanceado.Size = new System.Drawing.Size(175, 51);
            this.btnBalanceado.TabIndex = 34;
            this.btnBalanceado.Text = "Balanceado";
            this.btnBalanceado.UseVisualStyleBackColor = true;
            this.btnBalanceado.Click += new System.EventHandler(this.btnBalanceado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 564);
            this.Controls.Add(this.btnBalanceado);
            this.Controls.Add(this.btnMaximo);
            this.Controls.Add(this.btnMinimo);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.textNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnMinimo;
        private System.Windows.Forms.Button btnMaximo;
        private System.Windows.Forms.Button btnBalanceado;
    }
}

