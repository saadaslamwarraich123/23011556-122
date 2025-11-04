namespace SimpleCalculatorWithHistory
{
    partial class Result11
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
            this.btnAdd11 = new System.Windows.Forms.Button();
            this.btnSubtract11 = new System.Windows.Forms.Button();
            this.btnMultiply11 = new System.Windows.Forms.Button();
            this.btnDivide11 = new System.Windows.Forms.Button();
            this.btnShowHistory11 = new System.Windows.Forms.Button();
            this.txtNumber11 = new System.Windows.Forms.Label();
            this.txtNumber22 = new System.Windows.Forms.Label();
            this.txtResult11 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd11
            // 
            this.btnAdd11.Location = new System.Drawing.Point(0, 113);
            this.btnAdd11.Name = "btnAdd11";
            this.btnAdd11.Size = new System.Drawing.Size(75, 23);
            this.btnAdd11.TabIndex = 0;
            this.btnAdd11.Text = "Add11";
            this.btnAdd11.UseVisualStyleBackColor = true;
            // 
            // btnSubtract11
            // 
            this.btnSubtract11.Location = new System.Drawing.Point(12, 142);
            this.btnSubtract11.Name = "btnSubtract11";
            this.btnSubtract11.Size = new System.Drawing.Size(75, 23);
            this.btnSubtract11.TabIndex = 1;
            this.btnSubtract11.Text = "Subtract11";
            this.btnSubtract11.UseVisualStyleBackColor = true;
            // 
            // btnMultiply11
            // 
            this.btnMultiply11.Location = new System.Drawing.Point(70, 142);
            this.btnMultiply11.Name = "btnMultiply11";
            this.btnMultiply11.Size = new System.Drawing.Size(75, 23);
            this.btnMultiply11.TabIndex = 2;
            this.btnMultiply11.Text = "Multiply11";
            this.btnMultiply11.UseVisualStyleBackColor = true;
            // 
            // btnDivide11
            // 
            this.btnDivide11.Location = new System.Drawing.Point(137, 142);
            this.btnDivide11.Name = "btnDivide11";
            this.btnDivide11.Size = new System.Drawing.Size(75, 23);
            this.btnDivide11.TabIndex = 3;
            this.btnDivide11.Text = "Divide11";
            this.btnDivide11.UseVisualStyleBackColor = true;
            // 
            // btnShowHistory11
            // 
            this.btnShowHistory11.Location = new System.Drawing.Point(209, 142);
            this.btnShowHistory11.Name = "btnShowHistory11";
            this.btnShowHistory11.Size = new System.Drawing.Size(75, 23);
            this.btnShowHistory11.TabIndex = 4;
            this.btnShowHistory11.Text = "ShowHistory11";
            this.btnShowHistory11.UseVisualStyleBackColor = true;
            // 
            // txtNumber11
            // 
            this.txtNumber11.AutoSize = true;
            this.txtNumber11.Location = new System.Drawing.Point(26, 61);
            this.txtNumber11.Name = "txtNumber11";
            this.txtNumber11.Size = new System.Drawing.Size(56, 13);
            this.txtNumber11.TabIndex = 5;
            this.txtNumber11.Text = "Number11";
            this.txtNumber11.Click += new System.EventHandler(this.txtNumber11_Click);
            // 
            // txtNumber22
            // 
            this.txtNumber22.AutoSize = true;
            this.txtNumber22.Location = new System.Drawing.Point(40, 87);
            this.txtNumber22.Name = "txtNumber22";
            this.txtNumber22.Size = new System.Drawing.Size(56, 13);
            this.txtNumber22.TabIndex = 6;
            this.txtNumber22.Text = "Number22";
            // 
            // txtResult11
            // 
            this.txtResult11.AutoSize = true;
            this.txtResult11.Location = new System.Drawing.Point(29, 190);
            this.txtResult11.Name = "txtResult11";
            this.txtResult11.Size = new System.Drawing.Size(49, 13);
            this.txtResult11.TabIndex = 7;
            this.txtResult11.Text = "Result11";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(88, 61);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(88, 87);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(88, 187);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 10;
            // 
            // Result11
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtResult11);
            this.Controls.Add(this.txtNumber22);
            this.Controls.Add(this.txtNumber11);
            this.Controls.Add(this.btnShowHistory11);
            this.Controls.Add(this.btnDivide11);
            this.Controls.Add(this.btnMultiply11);
            this.Controls.Add(this.btnSubtract11);
            this.Controls.Add(this.btnAdd11);
            this.Name = "Result11";
            this.Load += new System.EventHandler(this.Result11_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnShowHistory;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txtNumber1;
        private System.Windows.Forms.Label txtNumber2;
        private System.Windows.Forms.Label txtResult;
        private System.Windows.Forms.Button btnAdd11;
        private System.Windows.Forms.Button btnSubtract11;
        private System.Windows.Forms.Button btnMultiply11;
        private System.Windows.Forms.Button btnDivide11;
        private System.Windows.Forms.Button btnShowHistory11;
        private System.Windows.Forms.Label txtNumber11;
        private System.Windows.Forms.Label txtNumber22;
        private System.Windows.Forms.Label txtResult11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}