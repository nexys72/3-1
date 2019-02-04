using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_практика
{
    public partial class img : Form
    {
        public static Bitmap image { get; private set; }

        public img()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (opendlg.ShowDialog() == DialogResult.OK)
                img.image = new Bitmap(opendlg.FileName);
        }
    }
}
