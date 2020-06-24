namespace SendFilesOverNetwork
{
    partial class Form_Client
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
            this.button_Alloc = new System.Windows.Forms.Button();
            this.label_byteallocinfo = new System.Windows.Forms.Label();
            this.textBox_maxbytesalloc = new System.Windows.Forms.TextBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.label_ConnStat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.button_clrfile = new System.Windows.Forms.Button();
            this.label_FIles_Info = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_Alloc
            // 
            this.button_Alloc.Location = new System.Drawing.Point(154, 56);
            this.button_Alloc.Name = "button_Alloc";
            this.button_Alloc.Size = new System.Drawing.Size(67, 23);
            this.button_Alloc.TabIndex = 27;
            this.button_Alloc.Text = "Alloc";
            this.button_Alloc.UseVisualStyleBackColor = true;
            this.button_Alloc.Click += new System.EventHandler(this.button_Alloc_Click);
            // 
            // label_byteallocinfo
            // 
            this.label_byteallocinfo.AutoSize = true;
            this.label_byteallocinfo.Location = new System.Drawing.Point(152, 9);
            this.label_byteallocinfo.Name = "label_byteallocinfo";
            this.label_byteallocinfo.Size = new System.Drawing.Size(137, 12);
            this.label_byteallocinfo.TabIndex = 26;
            this.label_byteallocinfo.Text = "MaxBytesAlloc(100MB)";
            // 
            // textBox_maxbytesalloc
            // 
            this.textBox_maxbytesalloc.Location = new System.Drawing.Point(154, 30);
            this.textBox_maxbytesalloc.Name = "textBox_maxbytesalloc";
            this.textBox_maxbytesalloc.Size = new System.Drawing.Size(92, 21);
            this.textBox_maxbytesalloc.TabIndex = 25;
            this.textBox_maxbytesalloc.Text = "100000000";
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(322, 371);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(103, 45);
            this.button_Send.TabIndex = 24;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // label_ConnStat
            // 
            this.label_ConnStat.AutoSize = true;
            this.label_ConnStat.Location = new System.Drawing.Point(10, 82);
            this.label_ConnStat.Name = "label_ConnStat";
            this.label_ConnStat.Size = new System.Drawing.Size(142, 12);
            this.label_ConnStat.TabIndex = 23;
            this.label_ConnStat.Text = "Connection Status : Null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "Port";
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(110, 30);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(38, 21);
            this.textBox_port.TabIndex = 20;
            this.textBox_port.Text = "1512";
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(12, 29);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(92, 21);
            this.textBox_ip.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(81, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Drop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(12, 56);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(63, 23);
            this.button_Connect.TabIndex = 17;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // button_clrfile
            // 
            this.button_clrfile.Location = new System.Drawing.Point(213, 371);
            this.button_clrfile.Name = "button_clrfile";
            this.button_clrfile.Size = new System.Drawing.Size(103, 45);
            this.button_clrfile.TabIndex = 16;
            this.button_clrfile.Text = "Clear FIles";
            this.button_clrfile.UseVisualStyleBackColor = true;
            this.button_clrfile.Click += new System.EventHandler(this.button_clrfile_Click);
            // 
            // label_FIles_Info
            // 
            this.label_FIles_Info.AutoSize = true;
            this.label_FIles_Info.Location = new System.Drawing.Point(10, 371);
            this.label_FIles_Info.Name = "label_FIles_Info";
            this.label_FIles_Info.Size = new System.Drawing.Size(62, 12);
            this.label_FIles_Info.TabIndex = 15;
            this.label_FIles_Info.Text = "FileCount:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 97);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(413, 268);
            this.listBox1.TabIndex = 14;
            // 
            // Form_Client
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 423);
            this.Controls.Add(this.button_Alloc);
            this.Controls.Add(this.label_byteallocinfo);
            this.Controls.Add(this.textBox_maxbytesalloc);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.label_ConnStat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.button_clrfile);
            this.Controls.Add(this.label_FIles_Info);
            this.Controls.Add(this.listBox1);
            this.Name = "Form_Client";
            this.Text = "client";
            this.Load += new System.EventHandler(this.Form_Client_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form_Client_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form_Client_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Alloc;
        private System.Windows.Forms.Label label_byteallocinfo;
        private System.Windows.Forms.TextBox textBox_maxbytesalloc;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.Label label_ConnStat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Button button_clrfile;
        private System.Windows.Forms.Label label_FIles_Info;
        private System.Windows.Forms.ListBox listBox1;
    }
}