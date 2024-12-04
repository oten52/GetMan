using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmPostman : Form
    {
        public frmPostman()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmPostman_Load(object sender, EventArgs e)
        {
            panel1.Controls.Add(new Postman2() { Dock = DockStyle.Fill });
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

          

        }
    }
}
