using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormationDotNetForms
{
    public partial class InfoSouris : Form
    {
        public InfoSouris()
        {
            InitializeComponent();
        }

        private void InfoSouris_MouseMove(object sender, MouseEventArgs e)
        {
            this.label1.Text = e.X.ToString();
            this.label2.Text = e.Y.ToString();
          
        }
    }
}
