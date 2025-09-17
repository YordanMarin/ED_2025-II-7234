namespace Pila
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
            this.btnApilar = new System.Windows.Forms.Button();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDesapilar = new System.Windows.Forms.Button();
            this.btnVistazo = new System.Windows.Forms.Button();
            this.btnCantidad = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnApilar
            // 
            this.btnApilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApilar.Location = new System.Drawing.Point(25, 172);
            this.btnApilar.Name = "btnApilar";
            this.btnApilar.Size = new System.Drawing.Size(145, 42);
            this.btnApilar.TabIndex = 24;
            this.btnApilar.Text = "Apilar";
            this.btnApilar.UseVisualStyleBackColor = true;
            this.btnApilar.Click += new System.EventHandler(this.btnApilar_Click);
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(144, 99);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(325, 30);
            this.textNombre.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 38);
            this.label1.TabIndex = 21;
            this.label1.Text = "PILA - STACK";
            // 
            // btnDesapilar
            // 
            this.btnDesapilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesapilar.Location = new System.Drawing.Point(25, 229);
            this.btnDesapilar.Name = "btnDesapilar";
            this.btnDesapilar.Size = new System.Drawing.Size(145, 42);
            this.btnDesapilar.TabIndex = 25;
            this.btnDesapilar.Text = "Desapilar";
            this.btnDesapilar.UseVisualStyleBackColor = true;
            this.btnDesapilar.Click += new System.EventHandler(this.btnDesapilar_Click);
            // 
            // btnVistazo
            // 
            this.btnVistazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVistazo.Location = new System.Drawing.Point(25, 286);
            this.btnVistazo.Name = "btnVistazo";
            this.btnVistazo.Size = new System.Drawing.Size(145, 42);
            this.btnVistazo.TabIndex = 26;
            this.btnVistazo.Text = "Vistazo";
            this.btnVistazo.UseVisualStyleBackColor = true;
            // 
            // btnCantidad
            // 
            this.btnCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCantidad.Location = new System.Drawing.Point(25, 343);
            this.btnCantidad.Name = "btnCantidad";
            this.btnCantidad.Size = new System.Drawing.Size(145, 42);
            this.btnCantidad.TabIndex = 27;
            this.btnCantidad.Text = "Cantidad";
            this.btnCantidad.UseVisualStyleBackColor = true;
            this.btnCantidad.Click += new System.EventHandler(this.btnCantidad_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(25, 396);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(145, 42);
            this.btnLimpiar.TabIndex = 28;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(195, 159);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(274, 354);
            this.listBox1.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 585);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCantidad);
            this.Controls.Add(this.btnVistazo);
            this.Controls.Add(this.btnDesapilar);
            this.Controls.Add(this.btnApilar);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApilar;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDesapilar;
        private System.Windows.Forms.Button btnVistazo;
        private System.Windows.Forms.Button btnCantidad;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ListBox listBox1;
    }
}

