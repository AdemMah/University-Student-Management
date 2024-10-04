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
    public partial class AddOutsideStudents : Form
    {
        private Form activeForm = null;

        private void openChildFormInPanel(Form childForm)
        {
            //if (ActiveForm != null)
            // ActiveForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PContInputOstud.Controls.Add(childForm);
            PContInputOstud.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public AddOutsideStudents()
        {
            InitializeComponent();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddOutsideStudents_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddOutSideUniv_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new InputOutSideStudents());
            pictureBoxaddOS.Hide();
            BtnAddOutSideFac.Hide();
            BtnAddOutSideUniv.Hide();
            labelAddOutStu.Show();


        }



        private void BtnAddOutSideFac_Click_1(object sender, EventArgs e)
        {
            openChildFormInPanel(new InputInternStudent());
            pictureBoxaddOS.Hide();
            BtnAddOutSideFac.Hide();
            BtnAddOutSideUniv.Hide();
        }
    }
}
