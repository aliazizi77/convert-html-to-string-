using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace html_to_string
{
    public partial class Form1 : Form
    {
        int i;
        string a;
        string b;
        public Form1()
        {
            InitializeComponent();
        }



        private void BtnConvert_Click(object sender, EventArgs e)
        {
            for (i = 0; i < Int16.Parse(textBox1.Lines.Length.ToString()); i++)
            {
                a = textBox1.Lines[i];
                a = a.Replace("\"", "\\\"");
                a = "\"" + a + "\"";
                b = b + Environment.NewLine + a;
            }
            textBox2.Text = b;
            Clipboard.SetText(textBox2.Text);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
