using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnivMI
{
    public partial class Dashboard_Form : Form
    {
        public Dashboard_Form()
        {
            InitializeComponent();
            DaThemDashord();
        }
        private void DaThemDashord()
        {
            this.BackColor = ClassDarkThem.BackColor;
            this.PanelBashboardSep.FillColor = ClassDarkThem.PanelColor;
            this.PanelOfNumbSep.FillColor = ClassDarkThem.PanelColor1;
        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void SwitchDashTheme_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void Dashboard_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
