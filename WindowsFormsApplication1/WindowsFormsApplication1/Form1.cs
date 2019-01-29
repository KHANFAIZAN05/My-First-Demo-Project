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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               DialogResult = MessageBox.Show("Hello From Khan Faizan", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(DialogResult == DialogResult.OK)
                {
                    DialogResult = MessageBox.Show("Closing Bye", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
