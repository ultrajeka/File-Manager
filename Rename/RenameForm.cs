using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rename
{
    public partial class RenameForm : Form
    {        
        public RenameForm()
        {
            InitializeComponent();                                 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnApplyRename_Click(object sender, EventArgs e)
        {            
            DialogResult = DialogResult.OK;
            
            if(DialogResult == DialogResult.OK)
            {                                
                Close();
            }
        }
    }
}
