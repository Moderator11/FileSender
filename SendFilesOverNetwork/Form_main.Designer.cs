namespace SendFilesOverNetwork
{
    partial class Form_main
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
            this.button_s = new System.Windows.Forms.Button();
            this.button_c = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_s
            // 
            this.button_s.Location = new System.Drawing.Point(12, 12);
            this.button_s.Name = "button_s";
            this.button_s.Size = new System.Drawing.Size(114, 101);
            this.button_s.TabIndex = 0;
            this.button_s.Text = "Server";
            this.button_s.UseVisualStyleBackColor = true;
            this.button_s.Click += new System.EventHandler(this.button_s_Click);
            // 
            // button_c
            // 
            this.button_c.Location = new System.Drawing.Point(132, 12);
            this.button_c.Name = "button_c";
            this.button_c.Size = new System.Drawing.Size(114, 101);
            this.button_c.TabIndex = 1;
            this.button_c.Text = "Client";
            this.button_c.UseVisualStyleBackColor = true;
            this.button_c.Click += new System.EventHandler(this.button_c_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 124);
            this.Controls.Add(this.button_c);
            this.Controls.Add(this.button_s);
            this.Name = "Form_main";
            this.Text = "main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_s;
        private System.Windows.Forms.Button button_c;
    }
}