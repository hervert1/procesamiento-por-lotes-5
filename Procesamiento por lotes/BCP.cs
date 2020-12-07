using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procesamiento_por_lotes
{
    public partial class BCP : Form
    { 
        public BCP()
        {
            InitializeComponent(); 
        }

        public void BCP_Load(object sender, EventArgs e)
        {
        }

        private void BCP_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void BCP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "67"){
                title.Text = "c";
                this.Hide();
            }
        }

        private void BCP_Leave(object sender, EventArgs e)
        {

        }
    }
}
