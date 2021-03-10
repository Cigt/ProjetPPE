using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppe1
{
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }
        FrmAccueil frm;
        Authentification frmA;
        
        private void btnConnect_Click(object sender, EventArgs e)
        {
            frm = new FrmAccueil(); frm.Show();
      
        }
    }
}
