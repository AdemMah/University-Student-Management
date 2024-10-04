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
    public partial class FormReRegisterStu : Form
    {
        public FormReRegisterStu()
        {
            InitializeComponent();
        }

        public void StuListSearchBySpesa()
        {
            using (SqlConnection SconxList = new SqlConnection("Data Source=DESKTOP-IOTSGEA\\SQLEXPRESS;Initial Catalog=UniversityMi;Persist Security Info=True;User ID=AdamJx0;Password=00007896"))
            {
                SconxList.Open();
                SqlCommand SqlDA = new SqlCommand("SELECT idCard FROM NewStudentsFirstYear Where idCard ='" + TbIdRegstStu.Text+ "' ", SconxList);
                SqlCommand Fname = new SqlCommand("SELECT Fname FROM NewStudentsFirstYear Where idCard ='" + TbIdRegstStu.Text + "' ", SconxList);
                SqlCommand Lname = new SqlCommand("SELECT Lname FROM NewStudentsFirstYear Where idCard ='" + TbIdRegstStu.Text + "' ", SconxList);
                SqlCommand DateBirthReGes = new SqlCommand("SELECT DateBirth FROM NewStudentsFirstYear Where idCard ='" + TbIdRegstStu.Text + "' ", SconxList);
                SqlCommand PlaceBirthReGes = new SqlCommand("SELECT PlaceBirth FROM NewStudentsFirstYear Where idCard ='" + TbIdRegstStu.Text + "' ", SconxList);
                SqlCommand CityBithReGes = new SqlCommand("SELECT CityBith FROM NewStudentsFirstYear Where idCard ='" + TbIdRegstStu.Text + "' ", SconxList);
                SqlCommand GenderReGes = new SqlCommand("SELECT Gender FROM NewStudentsFirstYear Where idCard ='" + TbIdRegstStu.Text + "' ", SconxList);
                SqlCommand UnivPhaseReGes = new SqlCommand("SELECT UnivPhase FROM NewStudentsFirstYear Where idCard ='" + TbIdRegstStu.Text + "' ", SconxList);
               // SqlCommand DateBirth = new SqlCommand("SELECT DateBirth FROM NewStudentsFirstYear Where idCard ='" + TbIdRegstStu.Text + "' ", SconxList);
                //SqlCommand SqlDA = new SqlCommand("SELECT idCard FROM NewStudentsFirstYear Where idCard ='" + TbIdRegstStu.Text + "' ", SconxList);
                var id = SqlDA.ExecuteScalar()as string;
                var FnameRe = Fname.ExecuteScalar() as string;
                var LnameRE = Lname.ExecuteScalar() as string;
                var DateBirthRe = DateBirthReGes.ExecuteScalar() as string;
                var PlaceBirthRe = PlaceBirthReGes.ExecuteScalar() as string;
                var CityBithRe = CityBithReGes.ExecuteScalar() as string;
                var GenderRe = GenderReGes.ExecuteScalar() as string;
                var FnameUnivPhaseRe = UnivPhaseReGes.ExecuteScalar() as string;
                IdStu.Text = id;
                IdStu.Visible = true;
                FNameStu.Text = FnameRe;
                FNameStu.Visible = true;
                LNameStu.Text = LnameRE;
                LNameStu.Visible = true;
                BethStu.Text = DateBirthRe;
                BethStu.Visible = true;
                PlaceBirth.Text = PlaceBirthRe;
                PlaceBirth.Visible = true;
                CityBirth.Text = CityBithRe;
                CityBirth.Visible = true;
                Gender.Text = GenderRe;
                Gender.Visible = true;
                PhasReStu.Text = FnameUnivPhaseRe;
                PhasReStu.Visible = true;
            }
        }
        public void StuListSearchBylname()
        {
            using (SqlConnection SconxList = new SqlConnection("Data Source=DESKTOP-IOTSGEA\\SQLEXPRESS;Initial Catalog=UniversityMi;Persist Security Info=True;User ID=AdamJx0;Password=00007896"))
            {
                SconxList.Open();
                SqlCommand UpdateSuLevel = new SqlCommand("Update  NewStudentsFirstYear SET UnivLevel ='" + CbYearReStu.SelectedItem.ToString() +  "' where idCard = '" + TbIdRegstStu.Text + "' ", SconxList);
                UpdateSuLevel.ExecuteNonQuery();
               
                SconxList.Close();
            }
        }
        private void FormReRegisterStu_Load(object sender, EventArgs e)
        {


        }

        private void BtnSearchReGestrStu_Click(object sender, EventArgs e)
        {

            StuListSearchBySpesa();
            CbPathReStu.Visible = true;
            CbFiliereReStu.Visible = true;
            CbSpesyaReStu.Visible = true;
            CbYearReStu.Visible = true;
            Lab1.Visible = true;
            Lab2.Visible = true;
            Lab3.Visible = true;
            Lab4.Visible = true;
            BtnRegester.Visible = true;
            BtnRefreshReGesterStu.Visible = true;
            PicBoxReStu.Visible = false;
        }

        private void BtnRegester_Click(object sender, EventArgs e)
        {

            StuListSearchBylname();
            ReLabel.Visible = true;
        }

        private void BtnRefreshReGesterStu_Click(object sender, EventArgs e)
        {
            TbIdRegstStu.Clear();
            CbPathReStu.Text = string.Empty;
            CbYearReStu.Text = string.Empty;
            CbSpesyaReStu.Text = string.Empty;
            CbFiliereReStu.Text = string.Empty;
        }
    }
}
