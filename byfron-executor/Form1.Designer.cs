namespace byfron_executor
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.execButton = new System.Windows.Forms.Button();
            this.injectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(350, 133);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "-- script";
            // 
            // execButton
            // 
            this.execButton.Location = new System.Drawing.Point(12, 190);
            this.execButton.Name = "execButton";
            this.execButton.Size = new System.Drawing.Size(176, 22);
            this.execButton.TabIndex = 1;
            this.execButton.Text = "execute";
            this.execButton.UseVisualStyleBackColor = true;
            this.execButton.Click += new System.EventHandler(this.execButton_Click);
            // 
            // injectButton
            // 
            this.injectButton.Location = new System.Drawing.Point(194, 190);
            this.injectButton.Name = "injectButton";
            this.injectButton.Size = new System.Drawing.Size(168, 22);
            this.injectButton.TabIndex = 2;
            this.injectButton.Text = "inject";
            this.injectButton.UseVisualStyleBackColor = true;
            this.injectButton.Click += new System.EventHandler(this.injectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "made using celeryapi, template by github.com/sodareverse";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 239);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.injectButton);
            this.Controls.Add(this.execButton);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "executor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button execButton;
        private System.Windows.Forms.Button injectButton;
        private System.Windows.Forms.Label label1;
    }
}

