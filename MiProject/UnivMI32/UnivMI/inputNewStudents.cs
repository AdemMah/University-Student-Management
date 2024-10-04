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
    public partial class inputNewStudents : Form
    {

        SqlConnection SConx = new SqlConnection("Data Source=DESKTOP-IOTSGEA\\SQLEXPRESS;Initial Catalog=UniversityMi;Persist Security Info=True;User ID=AdamJx0;Password=00007896");
        ClassStudentId IdMakenewStu = new ClassStudentId();

        //here generate students Id and id Count
        public void IdMaker()
        {
            string Mi = "MI-";
            Boolean IsTransf = false;
            string GiveYearBac, GetYearBac;

            string FacNewStuTextNull = "",
                   studentsFiliereNull = "جذع مشترك رياضيات و اعلام الالي",
                   classFac = "",
                   Univ= "جامعة محمد بوضياف المسيلة",
                   Fac= "كلية الرياضيات و الاعلام الالي",
                   UnivNull = "";
            TbUniv.Text = Univ;
            TbFac.Text = Fac;
            TbstudentsFiliere.Text = studentsFiliereNull;
             UnivStu.Text = UnivNull;
            FacNewStu.Text = FacNewStuTextNull;
            ClassFacNewStu.Text = classFac;
            GiveYearBac = CbBacPeriod.Text;
            GetYearBac = IdMakenewStu.YearOfBac(GiveYearBac);
            isTransferNewStu.Checked = IsTransf;


            IdEncrement.Text = IdMakenewStu.GetMaxId();

            IdNewStue.Text = Convert.ToString(Mi + GetYearBac + "-" + DateTime.Now.Year + "-" + IdMakenewStu.GetMaxId());
            labeltest.Text = Mi + GetYearBac + "-" + DateTime.Now.Year + "-" + IdMakenewStu.GetMaxId();
        }
        public inputNewStudents()
        {
            InitializeComponent();
        }
       
        private void inputNewStudents_Load(object sender, EventArgs e)
        {
           
        }



        private void BtnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void TextBox24_TextChanged(object sender, EventArgs e)
        {

        }

        //to use Enter Button
        private void EnterEvent(object sender, KeyEventArgs e)
        {
        }

        private void TextBox19_TextChanged(object sender, EventArgs e)
        {


        }

        private void PanelinputStu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonNext_Click_1(object sender, EventArgs e)
        {
      
        }

        private void PContainer4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TbBirthPlace_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnPrevious_Click_2(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void PContainer3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void TbSubGroup_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelLNameMother_Click(object sender, EventArgs e)
        {

        }

        private void PContainer2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            PageInput.SetPage("PgInformation2");
        }

        private void TbFnameMother_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnNext2_Click_1(object sender, EventArgs e)
        {
            ///go to PgBaciInfo
            PageInput.SetPage("PgBaciInfo");
        }

        private void BtnPrev_Click_1(object sender, EventArgs e)
        {
            /// Back to PgInformation
            PageInput.SetPage("PgInformation");
            ChB1.Checked = false; ChB1.Enabled = false;
            labelinformation.ForeColor = Color.Black;
        }

        private void BtnPrevInfo_Click(object sender, EventArgs e)
        {
            ///Back to PgInformation2
            PageInput.SetPage("PgInformation2");
            ChB2.Checked = false; ChB2.Enabled = false;
            labelBacInf.ForeColor = Color.Black;
        }

        private void BtnNextBacInfo_Click(object sender, EventArgs e)
        {
            ///go to PgStudyInfo
            PageInput.SetPage("PgStudyInfo");
            IdMaker();
        }

        private void BtnPrevBacInfo_Click(object sender, EventArgs e)
        {
            ///Back to PgBaciInfo
            PageInput.SetPage("PgBaciInfo");
            ChB3.Checked = false; ChB3.Enabled = false;
            labelStudyInf.ForeColor = Color.Black;
        }

        private void BtnNextFinish_Click(object sender, EventArgs e)
        {
            //////go to PgFinish
            PageInput.SetPage("PgFinish");
            ChB4.Checked = ChB4.Enabled = true;
            labelFinish.ForeColor = Color.Indigo;
            ////input this paramitetr in dataBase insert this button
            SConx.Open();
            SqlCommand Cmd = SConx.CreateCommand();
            Cmd.CommandType = CommandType.Text;
            IdMaker();
            Cmd.CommandText = "insert into NewStudentsFirstYear values ('" + IdNewStue.Text + "','" + IdEncrement.Text + "','" + TbFname.Text + "','" + TbLname.Text + "','" + TbFnameFr.Text + "','" + TbLnameFr.Text + "','" + DateBirth.Text + "','" + TbBirthPlace.Text + "','" + CBoxCity.Text + "','" + CBoxGender.Text + "','" + TbFathName.Text + "','" + TbFnameMother.Text + "','" + TbAddress.Text +"' ,'" + TbLNameMother.Text + "','" + TbEmail.Text + "' , '"+ Convert.ToDouble(TbBacID.Text) + "','" + CbBacPeriod.Text + "','" + CbBacSpes.Text + "','" + TbBacNote.Text + "','" + CbBacMention.Text + "','" + TbUniv.Text + "','" + TbFac.Text + "','" + CbLevel.Text + "','" + TbstudentsFiliere.Text + "','" + CbThisYear.Text + "','" + TbSpecialist.Text + "','" + TbSectiont.Text + "','" + TbGroup.Text + "','" + TbSubGroup.Text + "','" + UnivStu.Text + "','" + FacNewStu.Text + "','" + ClassFacNewStu.Text + "','" + isTransferNewStu.Checked + "')";

            Cmd.ExecuteNonQuery();
            SConx.Close();

                     

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            //////Back to PgInformation
            PageInput.SetPage("PgInformation");
            ////clear all combo Box/////
            ///Page1///
            TbFname.Clear();
            TbFnameFr.Clear();
            TbLname.Clear();
            TbLnameFr.Clear();
            DateBirth.Text = string.Empty;
            TbBirthPlace.Clear();
            CBoxCity.Text = string.Empty;
            CBoxGender.Text = string.Empty;
            
            ///Page2///
            TbBacID.Clear();
            CbBacPeriod.Text = string.Empty;
            CbBacSpes.Text = string.Empty;
            TbBacNote.Clear();
            CbBacMention.Text = string.Empty;

            ///Page3///
            TbFathName.Clear();
            TbLNameMother.Clear();
            TbFnameMother.Clear();
            TbAddress.Clear();
            TbEmail.Clear();

            ///Page4///
            CbLevel.Text = string.Empty;
            CbThisYear.Text = string.Empty;
            TbSpecialist.Clear();
            TbSectiont.Clear();
            TbGroup.Clear();
            TbSubGroup.Clear();
            ///////////////////////////////////////
            ChB1.Checked = false; ChB1.Enabled = false;
            labelinformation.ForeColor = Color.Black;

            ChB2.Checked = false; ChB2.Enabled = false;
            labelBacInf.ForeColor = Color.Black;

            ChB3.Checked = false; ChB3.Enabled = false;
            labelStudyInf.ForeColor = Color.Black;

            ChB4.Checked = false; ChB4.Enabled = false;
            labelFinish.ForeColor = Color.Black;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
        private void PageInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (PageInput.SelectedIndex)
            {
                case 1:
                    ChB1.Checked = ChB1.Enabled = true;
                    labelinformation.ForeColor = Color.Indigo;               
                    break;
                case 2:
                    ChB2.Checked = ChB2.Enabled = true;
                    labelBacInf.ForeColor = Color.Indigo;
                    break;
                case 3:
                    ChB3.Checked = ChB3.Enabled = true;
                    labelStudyInf.ForeColor = Color.Indigo;
                    break;

            }
        }

        private void TbFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lId_Click(object sender, EventArgs e)
        {
            
        }

        private void PgInformation_Click(object sender, EventArgs e)
        {

        }

        private void guna2VSeparator1_Click(object sender, EventArgs e)
        {

        }
        //....................
    }
}
