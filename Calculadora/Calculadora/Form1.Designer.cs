namespace Calculadora
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txNum1 = new System.Windows.Forms.TextBox();
            this.txNum2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbOper = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um número:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite outro número:";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(267, 80);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txNum1
            // 
            this.txNum1.Location = new System.Drawing.Point(131, 20);
            this.txNum1.Name = "txNum1";
            this.txNum1.Size = new System.Drawing.Size(100, 20);
            this.txNum1.TabIndex = 3;
            // 
            // txNum2
            // 
            this.txNum2.Location = new System.Drawing.Point(131, 46);
            this.txNum2.Name = "txNum2";
            this.txNum2.Size = new System.Drawing.Size(100, 20);
            this.txNum2.TabIndex = 4;
            this.txNum2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Escolha a operação:";
            // 
            // cbOper
            // 
            this.cbOper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOper.FormattingEnabled = true;
            this.cbOper.Items.AddRange(new object[] {
            "SOMAR",
            "SUBTRAIR",
            "MULTIPLICAR",
            "DIVISÃO"});
            this.cbOper.Location = new System.Drawing.Point(131, 80);
            this.cbOper.Name = "cbOper";
            this.cbOper.Size = new System.Drawing.Size(121, 21);
            this.cbOper.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Resultado: ";
            // 
            // txResult
            // 
            this.txResult.Enabled = false;
            this.txResult.Location = new System.Drawing.Point(152, 135);
            this.txResult.Name = "txResult";
            this.txResult.Size = new System.Drawing.Size(99, 20);
            this.txResult.TabIndex = 8;
            this.txResult.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 178);
            this.Controls.Add(this.txResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbOper);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txNum2);
            this.Controls.Add(this.txNum1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txNum1;
        private System.Windows.Forms.TextBox txNum2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbOper;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txResult;
    }
}

