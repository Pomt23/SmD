using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Transposition t;

        public Form1()
        {
            InitializeComponent();

            t = new Transposition();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            t.SetKey(KeyTextBox1.Text);
            
            if (encryptRadioButton1.Checked)
                outputTextBox2.Text = t.Encrypt(inputTextBox2.Text);
            else
                outputTextBox1.Text = t.Decrypt(inputTextBox1.Text);


        }

    }
}
