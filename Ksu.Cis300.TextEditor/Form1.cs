/* Form1.cs
 * Author: Sidharth
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

namespace Ksu.Cis300.TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uxOpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void uxOpen_Click(object sender, EventArgs e)
        {
            if (uxOpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Sorry the file"+ uxOpenFileDialog1.FileName +" can not be open");
            }
        }

        private void uxSaveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) ;
            {
                MessageBox.Show("Can not write to the file"+ saveFileDialog1.FileName);
            }
        }
    }
}
