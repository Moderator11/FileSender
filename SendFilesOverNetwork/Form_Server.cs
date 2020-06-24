using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SocketServer;
using System.Net;

namespace SendFilesOverNetwork
{
    public partial class Form_Server : Form
    {
        Server s = new Server();
        List<byte[]> files_byte = new List<byte[]>();
        int filecount = 0;
        ulong maxbytealloc = 100000000;
        int recfilecount = 0;
        int fcount = 0;

        public Form_Server()
        {
            InitializeComponent();
        }

        private string GetIP() { string strHostName = ""; strHostName = Dns.GetHostName(); IPHostEntry ipEntry = Dns.GetHostEntry(strHostName); IPAddress[] addr = ipEntry.AddressList; return addr[addr.Length - 1].ToString(); }

        private void Form_Server_Load(object sender, EventArgs e)
        {
            textBox_ip.Text = GetIP();
            s.fs = this;
            s.filecount = this.filecount;
            s.maxallocbytes = this.maxbytealloc;
        }

        private void Form_Server_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            ProcessFIles(s);
            for (int i = 0; i < s.Length; i++)
            {
                listBox1.Items.Add(s[i].Split(Convert.ToChar(@"\"))[s[i].Split(Convert.ToChar(@"\")).Length - 1]);//Displaying Name of it
            }
        }

        private void Form_Server_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void ProcessFIles(string[] files)
        {
            for (int i = 0; i < files.Length; i++)
            {
                files_byte.Add(File.ReadAllBytes(files[i]));
            }
            filecount = files_byte.Count;
            label_FIles_Info.Text = "FileCount : " + files_byte.Count.ToString();
        }

        private void button_clrfile_Click(object sender, EventArgs e)
        {
            files_byte.Clear();
            listBox1.Items.Clear();
            label_FIles_Info.Text = "FileCount : 0";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Alloc_Click(object sender, EventArgs e)
        {
            try
            {
                UInt64 val = UInt64.Parse(textBox_maxbytesalloc.Text);
                if (val / 1000000 == 0)
                {
                    label_byteallocinfo.Text = "MaxBytesAlloc(" + val / 1000000 + "MB)";
                }
                else
                {
                    label_byteallocinfo.Text = "MaxBytesAlloc(" + val / 1000000 + "MB)";
                }
                maxbytealloc = val;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                textBox_maxbytesalloc.Text = "100000000";
                label_byteallocinfo.Text = "MaxBytesAlloc(100MB)";
            }
        }

        public void DataRecieved(byte[] data, bool str)
        {
            int i = 0;//TEST
            if (str == true)
            {
                switch (Encoding.Unicode.GetString(data))
                {
                    case "=_+a1":
                        label_ConnStat.Text = "Connection Status: Connected";
                        break;
                    case "=_+a2":
                        label_ConnStat.Text = "Connection Status: Client Dropped Connection";
                        s.StopServer();
                        button1.Enabled = true;
                        button2.Enabled = false;
                        button_Alloc.Enabled = true;
                        break;
                    default:
                        break;
                }
                if(Encoding.Unicode.GetString(data) == "Done!")
                {
                    MessageBox.Show("Client Said Done!");
                }
                if (Encoding.Unicode.GetString(data).Split('.')[0] == "WantToSendFiles!")
                {
                    MessageBox.Show(string.Format("Client wants to send {0} files", recfilecount = int.Parse(Encoding.Unicode.GetString(data).Split('.')[1])));
                    s.SendMessage("I'm Ready!");
                }
                if (Encoding.Unicode.GetString(data) == "I'm Ready!")
                {
                    MessageBox.Show("Client is ready!");
                    s.SendBytes(files_byte[i]);
                }
                if (Encoding.Unicode.GetString(data).Split('.')[0] == "I got It!")
                {
                    MessageBox.Show("Client got It!(Server)" + Encoding.Unicode.GetString(data).Split('.')[1]);
                    if (filecount > int.Parse(Encoding.Unicode.GetString(data).Split('.')[1]) + 1)
                    {
                        s.SendBytes(files_byte[int.Parse(Encoding.Unicode.GetString(data).Split('.')[1]) + 1]);
                    }
                    else
                    {
                        s.SendMessage("Done!");//Done Sending
                    }
                    i++;
                }
            }
            else
            {
                MessageBox.Show("FIle In coming!(Server)" + string.Format("Rec:{0}, i:{1}", recfilecount, fcount));
                if (recfilecount > fcount)
                {
                    File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + fcount + ".txt", data);
                    s.SendMessage("I got It!." + fcount);
                    fcount++;
                }
                if (fcount == recfilecount)
                {
                    s.SendMessage("Done!");//Done Recieving
                    MessageBox.Show("Done!_Getting_FIles_Server");
                    recfilecount = 0;
                    fcount = 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s.StartServer(ushort.Parse(textBox_port.Text));
            button1.Enabled = false;
            button2.Enabled = true;
            button_Alloc.Enabled = false;
            label_ConnStat.Text = "Connection Status : Listening...";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s.SendMessage("=_+a2");
            s.StopServer();
            button1.Enabled = true;
            button2.Enabled = false;
            button_Alloc.Enabled = true;
            label_ConnStat.Text = "Connection Status : Dropped";
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            //SendWork
            s.SendMessage("WantToSendFiles!." + filecount);
        }
    }
}
