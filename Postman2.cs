using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Postman2 : UserControl
    {
        public Postman2()
        {
            InitializeComponent();
        }



        private void BodyRadioButtonChanged(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();

            if (rbRaw.Checked)
            {
                pnlBody.Controls.Add(new Postman2_Body_Raw() { Dock = DockStyle.Fill });
            }
        }
    }
}
