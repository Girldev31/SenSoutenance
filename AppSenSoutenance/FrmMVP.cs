using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSenSoutenance
{
    public partial class FrmMVP : Form
    {
        public FrmMVP()
        {
            InitializeComponent();
        }

        private void btnQuitte_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
