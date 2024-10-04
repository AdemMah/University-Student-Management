using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace UnivMI
{
    public partial class InputOutSideStudents : Form
    {
        SqlConnection SConx = new SqlConnection("Data Source=DESKTOP-IOTSGEA\\SQLEXPRESS;Initial Catalog=UniversityMi;Persist Security Info=True;User ID=AdamJx0;Password=00007896");
        ClassStudentId IdStuExt = new ClassStudentId();
        
        public void IdMaker()
        {
            string Mi = "MI-";
            Boolean  IsTransf = true;
            string GiveYearBac, GetYearBac,Univ= "جامعة محمد بوضياف المسيلة", Fac= "كلية الرياضيات و الاعلام الالي";
            isTransExt.Checked = IsTransf;
            GiveYearBac = CbBacPeriodOutUNiv.Text;

            GetYearBac = IdStuExt.YearOfBac(GiveYearBac);
            TbUniv.Text = Univ;
            TbFac.Text = Fac;
            idIncremntExStu.Text = IdStuExt.GetMaxId();
            IdExStu.Text = Convert.ToString(Mi + GetYearBac + "-" + DateTime.Now.Year + "-" + IdStuExt.GetMaxId());
           // labelIdExStu.Text = Mi + GetYearBac + "-" + DateTime.Now.Year + "-" + IdStuExt.GetMaxId();
            labelIdExStu.Text = Convert.ToString(Mi + GetYearBac + "-" + DateTime.Now.Year + "-" + IdStuExt.GetMaxId());
        }
        public InputOutSideStudents()
        {
            InitializeComponent();
        }

        private void bunifuSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void TbFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void PanelStapes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            //Go to PgInformation2OutS
            PageInputOutS.SetPage("PgInformation2OutS");
        }

        private void BtnPrevInfoOutS_Click(object sender, EventArgs e)
        {
            //back to PgInformation2OutS
            PageInputOutS.SetPage("PgInformation2OutS");
        }

        private void BtnPrevOutS_Click(object sender, EventArgs e)
        {
            //Back To PageInputOutS
            PageInputOutS.SetPage("PgInformationOutS");
        }

        private void BtnNext2OutS_Click(object sender, EventArgs e)
        {
            //Go to PgBaciInfoOutS
            PageInputOutS.SetPage("PgBaciInfoOutS");
        }

        private void BtnNextBacInfoOutS_Click(object sender, EventArgs e)
        {
            //go to PgStudyInfoOutS
            PageInputOutS.SetPage("PgStudyInfoOutS");
            IdMaker();
        }

        private void BtnPrevBacInfoOutS_Click(object sender, EventArgs e)
        {
            PageInputOutS.SetPage("PgBaciInfoOutS");
        }

        private void BtnNextFinishOutS_Click(object sender, EventArgs e)
        {
            PageInputOutS.SetPage("PgFinishOutS");
            SConx.Open();
            SqlCommand Cmd = SConx.CreateCommand();
            Cmd.CommandType = CommandType.Text; 
            IdMaker();
            Cmd.CommandText= "insert into NewStudentsFirstYear values ('" + IdExStu.Text + "','" + idIncremntExStu.Text + "','" + TbFnameOutUNiv.Text + "','" + TbLnameOutUNiv.Text + "','" + TbFnameFrOutUNiv.Text + "','" + TbLnameFrOutUNiv.Text + "','" + DateBirthOutUNiv.Text + "','" + TbBirthPlaceOutUNiv.Text + "','" + CBoxCityOutUNiv.Text + "','" + CBoxGenderOutUNiv.Text + "','" + TbFathNameOutUNiv.Text + "','" + TbFnameMotherOutUNiv.Text + "','" + TbLNameMotherOutUNiv.Text + "','" + TbAddressOutUNiv.Text + "','" + TbEmailOutUNiv.Text + "' , '" + Convert.ToDouble(TbBacIDOutUNiv.Text) + "','" + CbBacPeriodOutUNiv.Text + "','" + CbBacSpesOutUNiv.Text + "','" + TbBacNoteOutUNiv.Text + "','" + CbBacMentionOutUNiv.Text + "','" + TbUniv.Text + "','" + TbFac.Text + "','" + CbLevelOutUNiv.Text + "','" + CbFiliere.Text + "','" + CbThisYearOutUNiv.Text + "','" + CbSpecialty.Text + "','" + TbSectiontOutUNiv.Text + "','" + TbGroupOutUNiv.Text + "','" + TbSubGroupOutUNiv.Text + "','" + CbRealUnivOutUNiv.Text + "','" + FacuOutUNiv.Text + "','" + ClassOutUNiv.Text + "','" + isTransExt.Checked + "')";  
            Cmd.ExecuteNonQuery();
            SConx.Close();
        }

        private void BtnBackOutS_Click(object sender, EventArgs e)
        {
            PageInputOutS.SetPage("PgInformationOutS");

            ///Page1///
            TbFnameOutUNiv.Clear();
            TbFnameFrOutUNiv.Clear();
            TbLnameOutUNiv.Clear();
            TbLnameFrOutUNiv.Clear();
            DateBirthOutUNiv.Text = string.Empty;
            TbBirthPlaceOutUNiv.Clear();
            CBoxCityOutUNiv.Text = string.Empty;
            CBoxGenderOutUNiv.Text = string.Empty;

            ///Page2///
            TbBacIDOutUNiv.Clear();
            CbBacPeriodOutUNiv.Text = string.Empty;
            CbBacSpesOutUNiv.Text = string.Empty;
            TbBacNoteOutUNiv.Clear();
            CbBacMentionOutUNiv.Text = string.Empty;

            ///Page3///
            TbFathNameOutUNiv.Clear();
            TbLNameMotherOutUNiv.Clear();
            TbFnameMotherOutUNiv.Clear();
            TbAddressOutUNiv.Clear();
            TbEmailOutUNiv.Clear();

            ///Page4///
            CbLevelOutUNiv.Text = string.Empty;
            CbFiliere.Text = string.Empty;
            CbThisYearOutUNiv.Text = string.Empty;
            CbSpecialty.Text=string.Empty;
            TbSectiontOutUNiv.Clear();
            TbGroupOutUNiv.Clear();
            TbSubGroupOutUNiv.Clear();
            
            
        }

        private void InputOutSideStudents_Load(object sender, EventArgs e)
        {

        }

        private void RealUnivOutUNiv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
