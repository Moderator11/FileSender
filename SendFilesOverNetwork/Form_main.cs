using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendFilesOverNetwork
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void button_s_Click(object sender, EventArgs e)
        {
            Form sv = new Form_Server();
            sv.Show();
            sv.FormClosed += (s, args) => this.Close();
            Hide();
        }

        private void button_c_Click(object sender, EventArgs e)
        {
            Form cl = new Form_Client();
            cl.Show();
            cl.FormClosed += (s, args) => this.Close();
            Hide();
        }
    }
}
