namespace SimpleCalculatorWithHistory
{
    partial class HistoryForm
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
            this.btnClose11 = new System.Windows.Forms.Button();
            this.lstHistory11 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnClose11
            // 
            this.btnClose11.Location = new System.Drawing.Point(70, 162);
            this.btnClose11.Name = "btnClose11";
            this.btnClose11.Size = new System.Drawing.Size(75, 23);
            this.btnClose11.TabIndex = 0;
            this.btnClose11.Text = "Close11";
            this.btnClose11.UseVisualStyleBackColor = true;
            // 
            // lstHistory11
            // 
            this.lstHistory11.FormattingEnabled = true;
            this.lstHistory11.Location = new System.Drawing.Point(70, 39);
            this.lstHistory11.Name = "lstHistory11";
            this.lstHistory11.Size = new System.Drawing.Size(120, 95);
            this.lstHistory11.TabIndex = 1;
            this.lstHistory11.SelectedIndexChanged += new System.EventHandler(this.lstHistory11_SelectedIndexChanged);
            // 
            // HistoryForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lstHistory11);
            this.Controls.Add(this.btnClose11);
            this.Name = "HistoryForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClose11;
        private System.Windows.Forms.ListBox lstHistory11;
    }
}