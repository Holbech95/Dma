namespace WindowsFormsApp
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
            System.Windows.Forms.Label label1;
            this.listCardSet = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 17);
            label1.TabIndex = 1;
            label1.Text = "Card Set";
            // 
            // listCardSet
            // 
            this.listCardSet.FormattingEnabled = true;
            this.listCardSet.ItemHeight = 16;
            this.listCardSet.Location = new System.Drawing.Point(12, 36);
            this.listCardSet.Name = "listCardSet";
            this.listCardSet.Size = new System.Drawing.Size(167, 420);
            this.listCardSet.TabIndex = 0;
            this.listCardSet.SelectedIndexChanged += new System.EventHandler(this.listCardSet_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 467);
            this.Controls.Add(label1);
            this.Controls.Add(this.listCardSet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listCardSet;
    }
}

