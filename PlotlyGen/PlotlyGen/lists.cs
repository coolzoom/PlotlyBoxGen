using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlotlyGen
{
    public partial class lists : UserControl
    {
        public lists()
        {
            InitializeComponent();
        }
        public string datastring;

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var clipboardContent = Clipboard.GetText();

            if (string.IsNullOrEmpty(clipboardContent)) return;

            //Rows in Excel are splitted by Cariage Return - Line Feed ("\r\n")
            var rows = clipboardContent
                .Split(new string[] { "\r\n" }, StringSplitOptions.None)
                .Where(x => !string.IsNullOrEmpty(x))
                .ToList();
            datastring ="[" + clipboardContent.Replace("\r\n",",") + "]";

            ListBox1.Items.Clear();
            foreach (var row in rows)
            {
                ListBox1.Items.Add(row);
                //string data = String.Concat(rows, ',');
            }


        }
    }
}
