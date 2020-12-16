namespace CalculadoraProgramador
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.txtHexa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cboInfo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDecimal
            // 
            this.txtDecimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtDecimal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecimal.Location = new System.Drawing.Point(6, 28);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.ReadOnly = true;
            this.txtDecimal.Size = new System.Drawing.Size(292, 29);
            this.txtDecimal.TabIndex = 0;
            this.txtDecimal.TabStop = false;
            this.txtDecimal.Text = "0";
            this.txtDecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBinario
            // 
            this.txtBinario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtBinario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBinario.Location = new System.Drawing.Point(6, 63);
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.ReadOnly = true;
            this.txtBinario.Size = new System.Drawing.Size(292, 29);
            this.txtBinario.TabIndex = 1;
            this.txtBinario.TabStop = false;
            this.txtBinario.Text = "0";
            this.txtBinario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHexa
            // 
            this.txtHexa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtHexa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHexa.Location = new System.Drawing.Point(6, 98);
            this.txtHexa.Name = "txtHexa";
            this.txtHexa.ReadOnly = true;
            this.txtHexa.Size = new System.Drawing.Size(292, 29);
            this.txtHexa.TabIndex = 3;
            this.txtHexa.TabStop = false;
            this.txtHexa.Text = "0";
            this.txtHexa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cboInfo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn3);
            this.groupBox1.Controls.Add(this.btn6);
            this.groupBox1.Controls.Add(this.btn9);
            this.groupBox1.Controls.Add(this.Borrar);
            this.groupBox1.Controls.Add(this.btn2);
            this.groupBox1.Controls.Add(this.btn5);
            this.groupBox1.Controls.Add(this.btn8);
            this.groupBox1.Controls.Add(this.Btn0);
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Controls.Add(this.btn4);
            this.groupBox1.Controls.Add(this.btn7);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.txtDecimal);
            this.groupBox1.Controls.Add(this.txtHexa);
            this.groupBox1.Controls.Add(this.txtBinario);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 344);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversor de numeros decimales (Proyecto final)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 31;
            this.label5.Text = "Informacion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 33);
            this.button1.TabIndex = 30;
            this.button1.Text = "¡Muestrame!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboInfo
            // 
            this.cboInfo.FormattingEnabled = true;
            this.cboInfo.Items.AddRange(new object[] {
            "Hexa",
            "Binario",
            "Decimal"});
            this.cboInfo.Location = new System.Drawing.Point(305, 183);
            this.cboInfo.Name = "cboInfo";
            this.cboInfo.Size = new System.Drawing.Size(121, 29);
            this.cboInfo.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "Hexadecimal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Binario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Decimal";
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Aqua;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(199, 259);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 34);
            this.btn3.TabIndex = 18;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Aqua;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(199, 219);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 34);
            this.btn6.TabIndex = 17;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Aqua;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(199, 179);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 34);
            this.btn9.TabIndex = 16;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // Borrar
            // 
            this.Borrar.BackColor = System.Drawing.Color.Aqua;
            this.Borrar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrar.Location = new System.Drawing.Point(199, 139);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(75, 34);
            this.Borrar.TabIndex = 15;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = false;
            this.Borrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Aqua;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(118, 259);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 34);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Aqua;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(118, 219);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 34);
            this.btn5.TabIndex = 13;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Aqua;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(118, 179);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 34);
            this.btn8.TabIndex = 12;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.Color.Aqua;
            this.Btn0.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.Location = new System.Drawing.Point(118, 139);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(75, 34);
            this.Btn0.TabIndex = 11;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Aqua;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(37, 259);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 34);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Aqua;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(37, 219);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 34);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Aqua;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(37, 179);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 34);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Aqua;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(37, 139);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "←";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.Del_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(468, 349);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora de Marcos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.TextBox txtBinario;
        private System.Windows.Forms.TextBox txtHexa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboInfo;
        private System.Windows.Forms.Label label5;
    }
}

