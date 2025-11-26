namespace GrafoPrim
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
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textVert = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textCosto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textDestino = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.textOrigen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrim = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnMatriz = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(276, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 25);
            this.label5.TabIndex = 55;
            this.label5.Text = "Ingrese número de vertices:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(668, 65);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 39);
            this.button1.TabIndex = 56;
            this.button1.Text = "Insertar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textVert
            // 
            this.textVert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVert.Location = new System.Drawing.Point(549, 71);
            this.textVert.Margin = new System.Windows.Forms.Padding(2);
            this.textVert.Name = "textVert";
            this.textVert.Size = new System.Drawing.Size(99, 30);
            this.textVert.TabIndex = 57;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textCosto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textDestino);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnInsertar);
            this.groupBox1.Controls.Add(this.textOrigen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(70, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 203);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aristas";
            // 
            // textCosto
            // 
            this.textCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCosto.Location = new System.Drawing.Point(99, 105);
            this.textCosto.Margin = new System.Windows.Forms.Padding(2);
            this.textCosto.Name = "textCosto";
            this.textCosto.Size = new System.Drawing.Size(74, 30);
            this.textCosto.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 46;
            this.label4.Text = "Costo:";
            // 
            // textDestino
            // 
            this.textDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDestino.Location = new System.Drawing.Point(99, 64);
            this.textDestino.Margin = new System.Windows.Forms.Padding(2);
            this.textDestino.Name = "textDestino";
            this.textDestino.Size = new System.Drawing.Size(76, 30);
            this.textDestino.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "Destino:";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(57, 144);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(118, 48);
            this.btnInsertar.TabIndex = 40;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // textOrigen
            // 
            this.textOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOrigen.Location = new System.Drawing.Point(99, 24);
            this.textOrigen.Margin = new System.Windows.Forms.Padding(2);
            this.textOrigen.Name = "textOrigen";
            this.textOrigen.Size = new System.Drawing.Size(74, 30);
            this.textOrigen.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Origen:";
            // 
            // btnPrim
            // 
            this.btnPrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrim.Location = new System.Drawing.Point(275, 391);
            this.btnPrim.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrim.Name = "btnPrim";
            this.btnPrim.Size = new System.Drawing.Size(611, 48);
            this.btnPrim.TabIndex = 59;
            this.btnPrim.Text = "Algoritmo de PRIM";
            this.btnPrim.UseVisualStyleBackColor = true;
            this.btnPrim.Click += new System.EventHandler(this.btnPrim_Click);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(275, 455);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(611, 179);
            this.listBox2.TabIndex = 58;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(275, 175);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(611, 211);
            this.richTextBox1.TabIndex = 54;
            this.richTextBox1.Text = "";
            // 
            // btnMatriz
            // 
            this.btnMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatriz.Location = new System.Drawing.Point(275, 117);
            this.btnMatriz.Margin = new System.Windows.Forms.Padding(2);
            this.btnMatriz.Name = "btnMatriz";
            this.btnMatriz.Size = new System.Drawing.Size(611, 48);
            this.btnMatriz.TabIndex = 53;
            this.btnMatriz.Text = "Matriz de Costo";
            this.btnMatriz.UseVisualStyleBackColor = true;
            this.btnMatriz.Click += new System.EventHandler(this.btnMatriz_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(97, 292);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(146, 354);
            this.listBox1.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 42);
            this.label1.TabIndex = 51;
            this.label1.Text = "GRAFOS DIRIGIDOS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 698);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textVert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrim);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnMatriz);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textVert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textCosto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox textOrigen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrim;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnMatriz;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}

