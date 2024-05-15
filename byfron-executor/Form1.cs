/*
* made by github.com/sodareverse using celeryapi
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CeleryAPI; // use celeryapi for injection and execution

namespace byfron_executor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void execButton_Click(object sender, EventArgs e)
        {
            // there are more api features than execute and inject
            CeleryAPI.ByfronPlayer.execute(richTextBox1.Text);
        }

        private void injectButton_Click(object sender, EventArgs e)
        {
            // inject into roblox
            CeleryAPI.ByfronPlayer.Inject();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
