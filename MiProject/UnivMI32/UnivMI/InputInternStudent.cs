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
using System.Configuration;

namespace UnivMI
{ 
        
    public partial class InputInternStudent : Form
    {
        SqlConnection Sconx = new SqlConnection("Data Source=DESKTOP-IOTSGEA\\SQLEXPRESS;Initial Catalog=UniversityMi;Persist Security Info=True;User ID=AdamJx0;Password=00007896");
        //object of fanction getMaxId and yearOfBac
        ClassStudentId IdMake = new ClassStudentId();
        
       //here generate students Id and id Count
        public void IdMaker()
         {
            string Mi = "MI-";
            Boolean IsTransf = true;
            string GiveYearBac,GetYearBac,UnivNull="", Univ = "جامعة محمد بوضياف المسيلة", Fac = "كلية الرياضيات و الاعلام الالي"; ;
            GiveYearBac = CbBacPeriodOutSiFac.Text;
           GetYearBac= IdMake.YearOfBac(GiveYearBac);
            isTrans.Checked = IsTransf;
            NullUniver.Text = UnivNull;
            TbUniv.Text = Univ;
            TbFac.Text = Fac;

            idIncremnt.Text = IdMake.GetMaxId();

            IdOutSiFac.Text =  Convert.ToString( Mi + GetYearBac + "-" + DateTime.Now.Year + "-" + IdMake.GetMaxId());         
            labelIdGen.Text = Mi + GetYearBac + "-" + DateTime.Now.Year + "-" + IdMake.GetMaxId();
        }
        //-----------------------------------------
        public InputInternStudent()
        {
            InitializeComponent();
            
        }

        private void BtnPrevInfoOutSiFac_Click(object sender, EventArgs e)
        {
            ///go back to PgInformation2OutSiFac
            PageInputOutSiFac.SetPage("PgInformation2OutSiFac");
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            ///go to PgInformation2OutSiFac
            PageInputOutSiFac.SetPage("PgInformation2OutSiFac");
        }

        private void BtnNext2OutSiFac_Click(object sender, EventArgs e)
        {
            ///go to PgBaciInfoOutSiFac
            PageInputOutSiFac.SetPage("PgBaciInfoOutSiFac");
        }

        private void BtnNextFinishOutSiFac_Click(object sender, EventArgs e)
        {
            ///go to PgFinishOutSiFac
            PageInputOutSiFac.SetPage("PgFinishOutSiFac");
            ///Here input internal Students
            Sconx.Open();
            SqlCommand Cmd = Sconx.CreateCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "insert into NewStudentsFirstYear values ('" + IdOutSiFac.Text + "','" + idIncremnt.Text + "','" + TbFnameOutSiFac.Text + "','" + TbLnameOutSiFac.Text + "','" + TbFnameFrOutSiFac.Text + "','" + TbLnameFrOutSiFac.Text + "','" + DateBirthOutSiFac.Text + "','" + TbBirthPlaceOutSiFac.Text + "','" + CBoxCityOutSiFac.Text + "','" + CBoxGenderOutSiFac.Text + "','" + TbFathNameOutSiFac.Text + "','" + TbFnameMotherOutSiFac.Text + "','" + TbLNameMotherOutSiFac.Text + "','" + TbAddressOutSiFac.Text + "','" + TbEmailOutSiFac.Text + "' , '" + Convert.ToDouble(TbBacIDOutSiFac.Text) + "','" + CbBacPeriodOutSiFac.Text + "','" + CbBacSpesOutSiFac.Text + "','" + TbBacNoteOutSiFac.Text + "','" + CbBacMentionOutSiFac.Text + "','" + TbUniv.Text + "','" + TbFac.Text + "','" + CbLevelOutSiFac.Text + "','" + CbFiliereInternal.Text + "','" + CbThisYearOutSiFac.Text + "','" + CbSpecialtyInternal.Text + "','" + TbSectiontOutSiFac.Text + "','" + TbGroupOutSiFac.Text + "','" + TbSubGroupOutSiFac.Text + "','" + NullUniver.Text + "','" + CbFacOutSiFac.Text + "','" + ClassFucOutSiFac.Text + "','" + isTrans.Checked + "')";
            IdMaker();
            Cmd.ExecuteNonQuery();        
            Sconx.Close();
        }

        private void BtnNextBacInfoOutSiFac_Click(object sender, EventArgs e)
        {
            ///go to PgStudyInfoOutSiFac
            PageInputOutSiFac.SetPage("PgStudyInfoOutSiFac");
            IdMaker();
            string id;
            id= CbBacPeriodOutSiFac.Text;
            bacY.Text = IdMake.YearOfBac(id);
            // SetIID.Text =Convert.ToString( setId());

        }
        private void BtnPrevOutSiFac_Click(object sender, EventArgs e)
        {
            ///go back to PgInformationOutSiFac
            PageInputOutSiFac.SetPage("PgInformationOutSiFac");
        }
        private void BtnPrevBacInfoOutSiFac_Click(object sender, EventArgs e)
        {
            ///go back to PgBaciInfoOutSiFac
            PageInputOutSiFac.SetPage("PgBaciInfoOutSiFac");
        }
        private void BtnBackOutSiFac_Click(object sender, EventArgs e)
        {
            //go back to PgInformationOutSiFac
            PageInputOutSiFac.SetPage("PgInformationOutSiFac");

            ///Page1///
            TbFnameOutSiFac.Clear();
            TbFnameFrOutSiFac.Clear();
            TbLnameOutSiFac.Clear();
            TbLnameFrOutSiFac.Clear();
            DateBirthOutSiFac.Text = string.Empty;
            TbBirthPlaceOutSiFac.Clear();
            CBoxCityOutSiFac.Text = string.Empty;
            CBoxGenderOutSiFac.Text = string.Empty;

            ///Page2///
            TbBacIDOutSiFac.Clear();
            CbBacPeriodOutSiFac.Text = string.Empty;
            CbBacSpesOutSiFac.Text = string.Empty;
            TbBacNoteOutSiFac.Clear();
            CbBacMentionOutSiFac.Text = string.Empty;

            ///Page3///
            TbFathNameOutSiFac.Clear();
            TbLNameMotherOutSiFac.Clear();
            TbFnameMotherOutSiFac.Clear();
            TbAddressOutSiFac.Clear();
            TbEmailOutSiFac.Clear();

            ///Page4///
            CbLevelOutSiFac.Text = string.Empty;
            CbFiliereInternal.Text = string.Empty;
            CbThisYearOutSiFac.Text = string.Empty;
            CbSpecialtyInternal.Text=string.Empty;
            TbSectiontOutSiFac.Clear();
            TbGroupOutSiFac.Clear();
            TbSubGroupOutSiFac.Clear();
            CbFacOutSiFac.Text = string.Empty;
            ClassFucOutSiFac.Clear();
          //  GetMaxId();
            
           

        }
        private void Id_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void labelIdGen_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            

        }

        private void TbFnameFrOutSiFac_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputInternStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
