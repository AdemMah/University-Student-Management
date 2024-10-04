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
    public partial class FormAPP : Form
    {
       // ClassDarkThem DaTemFormApp = new ClassDarkThem();
        //this code  open multi forms in form
        private Form activeForm = null;
        public  bool chekeThemeValue;
        public bool switchCheck(bool SwCheck)
        {
            return SwCheck;
        }
        public class colorSe
        {
            public  Boolean ColS;
           
        }

        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(childForm);
            PanelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public FormAPP()
        {
            InitializeComponent();

            
            ClassDarkThem.DarkTheme(chekeThemeValue);
            
           
               
            
            PanelPlaceButton.Height = BtnDashboard.Height;
            PanelPlaceButton.Top = BtnDashboard.Top;
            openChildFormInPanel(new Dashboard_Form());
            //DarThemForm();
           // ClassDarkThem.isCheke = true;
            DarThemForm();
           



           // ClassDarkThem.DarkTheme();


        }
        private void DarThemForm()
        {

            this.BackColor = ClassDarkThem.BackColor;
            this.labelFormAppMi.ForeColor = ClassDarkThem.FontColor;
            this.labelSwith.ForeColor = ClassDarkThem.FontColor;




        }

       
       

        private void PanelCont_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           //mark selected button
            PanelPlaceButton.Height = BtnAddStudents.Height;
            PanelPlaceButton.Top = BtnAddStudents.Top;
            //...........

            openChildFormInPanel(new AddStudents_Form());

        }

        private void PanelButton_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelNubStudent_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            //mark selected button
            PanelPlaceButton.Height = BtnDashboard.Height;
            PanelPlaceButton.Top = BtnDashboard.Top;
            //...........
            openChildFormInPanel(new Dashboard_Form());
              
            


        }

        private void BtnOutsideStudents_Click(object sender, EventArgs e)
        {
            //mark selected button
            PanelPlaceButton.Height = BtnOutsideStudents.Height;
            PanelPlaceButton.Top = BtnOutsideStudents.Top;
            PanelPlaceButton.Left = BtnOutsideStudents.Left;
            
            openChildFormInPanel(new AddOutsideStudents());
            //...........
        }

        private void BtnStudentsList_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ShowStudentsList());
            //mark selected button
            PanelPlaceButton.Height = BtnStudentsList.Height;
            PanelPlaceButton.Top = BtnStudentsList.Top;
            //...........
        }

        private void PictureBoxTeamWork_Click(object sender, EventArgs e)
        {

        }

       
       public void SwitchThem_CheckedChanged(object sender, EventArgs e)
        {
            //DarThemForm();
            //ClassDarkThem.DarkTheme();
         /* if (SwitchThem.Checked == true)
           {
              this.BackColor = Color.FromArgb(45, 45, 48);
             // this.BtnDashboard.ForeColor = Color.FromArgb(110, 113, 121);
              this.labelFormAppMi.ForeColor = Color.White;
              this.labelSwith.ForeColor = Color.White;
                AddStudents_Form ASF = new AddStudents_Form();
                ASF.BackColor = Color.FromArgb(45, 45, 48);



           }
           else
           {
             this.BackColor = Color.FromArgb(255, 255, 255);
             this.labelFormAppMi.ForeColor = Color.Black;
             this.labelSwith.ForeColor = Color.Black;
                AddStudents_Form ASF = new AddStudents_Form();
                ASF.BackColor = Color.White;
               
            }*/
        }

        private void FormAPP_Load(object sender, EventArgs e)
        {

        }

        private void BtnDarkThem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void SwitchTheme_CheckedChanged(object sender, EventArgs e)
        {

            chekeThemeValue = switchCheck(SwitchTheme.Checked);
        }

        private void BtnReGestrStu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FormReRegisterStu());
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
           DialogResult= MessageBox.Show("هل متاكد من انك تريد الخروج ", "تنبيه", MessageBoxButtons.YesNo);
            if (DialogResult==DialogResult.Yes)
            {
                this.Close();
            }
            
        }
    }
}
