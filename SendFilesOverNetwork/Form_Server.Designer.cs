namespace SendFilesOverNetwork
{
    partial class Form_Server
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label_FIles_Info = new System.Windows.Forms.Label();
            this.button_clrfile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_ConnStat = new System.Windows.Forms.Label();
            this.button_Send = new System.Windows.Forms.Button();
            this.textBox_maxbytesalloc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_byteallocinfo = new System.Windows.Forms.Label();
            this.button_Alloc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 97);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(413, 268);
            this.listBox1.TabIndex = 0;
            // 
            // label_FIles_Info
            // 
            this.label_FIles_Info.AutoSize = true;
            this.label_FIles_Info.Location = new System.Drawing.Point(10, 371);
            this.label_FIles_Info.Name = "label_FIles_Info";
            this.label_FIles_Info.Size = new System.Drawing.Size(62, 12);
            this.label_FIles_Info.TabIndex = 1;
            this.label_FIles_Info.Text = "FileCount:";
            // 
            // button_clrfile
            // 
            this.button_clrfile.Location = new System.Drawing.Point(213, 371);
            this.button_clrfile.Name = "button_clrfile";
            this.button_clrfile.Size = new System.Drawing.Size(103, 45);
            this.button_clrfile.TabIndex = 2;
            this.button_clrfile.Text = "Clear FIles";
            this.button_clrfile.UseVisualStyleBackColor = true;
            this.button_clrfile.Click += new System.EventHandler(this.button_clrfile_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Listen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(81, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Drop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(12, 29);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.ReadOnly = true;
            this.textBox_ip.Size = new System.Drawing.Size(92, 21);
            this.textBox_ip.TabIndex = 5;
            this.textBox_ip.Text = "000.000.000.000";
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(110, 30);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(38, 21);
            this.textBox_port.TabIndex = 6;
            this.textBox_port.Text = "1512";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "IP";
            // 
            // label_ConnStat
            // 
            this.label_ConnStat.AutoSize = true;
            this.label_ConnStat.Location = new System.Drawing.Point(10, 82);
            this.label_ConnStat.Name = "label_ConnStat";
            this.label_ConnStat.Size = new System.Drawing.Size(142, 12);
            this.label_ConnStat.TabIndex = 9;
            this.label_ConnStat.Text = "Connection Status : Null";
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(322, 371);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(103, 45);
            this.button_Send.TabIndex = 10;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // textBox_maxbytesalloc
            // 
            this.textBox_maxbytesalloc.Location = new System.Drawing.Point(154, 30);
            this.textBox_maxbytesalloc.Name = "textBox_maxbytesalloc";
            this.textBox_maxbytesalloc.Size = new System.Drawing.Size(92, 21);
            this.textBox_maxbytesalloc.TabIndex = 11;
            this.textBox_maxbytesalloc.Text = "100000000";
            this.textBox_maxbytesalloc.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Port";
            // 
            // label_byteallocinfo
            // 
            this.label_byteallocinfo.AutoSize = true;
            this.label_byteallocinfo.Location = new System.Drawing.Point(152, 9);
            this.label_byteallocinfo.Name = "label_byteallocinfo";
            this.label_byteallocinfo.Size = new System.Drawing.Size(137, 12);
            this.label_byteallocinfo.TabIndex = 12;
            this.label_byteallocinfo.Text = "MaxBytesAlloc(100MB)";
            // 
            // button_Alloc
            // 
            this.button_Alloc.Location = new System.Drawing.Point(154, 56);
            this.button_Alloc.Name = "button_Alloc";
            this.button_Alloc.Size = new System.Drawing.Size(67, 23);
            this.button_Alloc.TabIndex = 13;
            this.button_Alloc.Text = "Alloc";
            this.button_Alloc.UseVisualStyleBackColor = true;
            this.button_Alloc.Click += new System.EventHandler(this.button_Alloc_Click);
            // 
            // Form_Server
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 426);
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_clrfile);
            this.Controls.Add(this.label_FIles_Info);
            this.Controls.Add(this.listBox1);
            this.Name = "Form_Server";
            this.Text = "server";
            this.Load += new System.EventHandler(this.Form_Server_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form_Server_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form_Server_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label_FIles_Info;
        private System.Windows.Forms.Button button_clrfile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_ConnStat;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.TextBox textBox_maxbytesalloc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_byteallocinfo;
        private System.Windows.Forms.Button button_Alloc;
    }
}

