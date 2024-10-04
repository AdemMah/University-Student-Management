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
    public partial class AddStudents_Form : Form
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
            PanelStudents.Controls.Add(childForm);
            PanelStudents.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public AddStudents_Form()
        {
            InitializeComponent();
        }

        private void Panelinput_Paint(object sender, PaintEventArgs e)
        {
          

        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddStudents_Form_Load(object sender, EventArgs e)
        {

        }

        
        private void PinPInput_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnNewStudents_Click(object sender, EventArgs e)
        {
            this.BtnReStudent.Hide();
            
            openChildFormInPanel(new inputNewStudents());
            this.BtnNewStudents.Hide();
           
            this.labelNewStu.Visible = true;


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FormReRegisterStu());
            //this.BtnReStudent.Hide();
            //this.PBtnReStudent.Hide();
        }

        private void PanelNewStudents_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        public void SwitchAddStuForm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
