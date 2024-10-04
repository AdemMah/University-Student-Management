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
   
    public partial class ShowStudentsList : Form
    {
        public void StuListView()
        {
            using (SqlConnection SconxList = new SqlConnection("Data Source=DESKTOP-IOTSGEA\\SQLEXPRESS;Initial Catalog=UniversityMi;Persist Security Info=True;User ID=AdamJx0;Password=00007896"))
            {
                SconxList.Open();
                SqlDataAdapter SqlDA = new SqlDataAdapter("SELECT  *FROM NewStudentsFirstYear order by idCount asc", SconxList);

                DataTable ListSorthing = new DataTable();
                DataTable ListStuTabel = new DataTable();
                SqlDA.Fill(ListStuTabel);
                GridViewListStu.AutoGenerateColumns = false;
                GridViewListStu.DataSource = ListStuTabel;

            }
        }
        public void StuListSearchByidCard()
        {
            using (SqlConnection SconxList = new SqlConnection("Data Source=DESKTOP-IOTSGEA\\SQLEXPRESS;Initial Catalog=UniversityMi;Persist Security Info=True;User ID=AdamJx0;Password=00007896"))
            {
                SconxList.Open();
                SqlDataAdapter SqlDA = new SqlDataAdapter("SELECT  *FROM NewStudentsFirstYear Where idCard ='" + TbSearchList.Text+ "' ", SconxList);

                DataTable ListStuTabel = new DataTable();
                SqlDA.Fill(ListStuTabel);
                GridViewListStu.AutoGenerateColumns = false;
                GridViewListStu.DataSource = ListStuTabel;
                SconxList.Close();

            }
        }
        public void StuListSearchByPath()
        {
            using (SqlConnection SconxList = new SqlConnection("Data Source=DESKTOP-IOTSGEA\\SQLEXPRESS;Initial Catalog=UniversityMi;Persist Security Info=True;User ID=AdamJx0;Password=00007896"))
            {
                SconxList.Open();
                SqlDataAdapter SqlDA = new SqlDataAdapter("SELECT  *FROM NewStudentsFirstYear Where UnivPhase ='" + CbPathStuLIst.SelectedItem.ToString() + "' ", SconxList);

                DataTable ListStuTabel = new DataTable();
                SqlDA.Fill(ListStuTabel);
                GridViewListStu.AutoGenerateColumns = false;
                GridViewListStu.DataSource = ListStuTabel;
                SconxList.Close();

            }
        }
        public void StuListSearchByYear()
        {
            using (SqlConnection SconxList = new SqlConnection("Data Source=DESKTOP-IOTSGEA\\SQLEXPRESS;Initial Catalog=UniversityMi;Persist Security Info=True;User ID=AdamJx0;Password=00007896"))
            {
                SconxList.Open();
                SqlDataAdapter SqlDA = new SqlDataAdapter("SELECT  *FROM NewStudentsFirstYear Where UnivLevel ='" + CbYearStuLIst.SelectedItem.ToString() + "' ", SconxList);

                DataTable ListStuTabel = new DataTable();
                SqlDA.Fill(ListStuTabel);
                GridViewListStu.AutoGenerateColumns = false;
                GridViewListStu.DataSource = ListStuTabel;
                SconxList.Close();

            }
        }
        public void StuListSearchBySpesa()
        {
            using (SqlConnection SconxList = new SqlConnection("Data Source=DESKTOP-IOTSGEA\\SQLEXPRESS;Initial Catalog=UniversityMi;Persist Security Info=True;User ID=AdamJx0;Password=00007896"))
            {
                SconxList.Open();
                SqlDataAdapter SqlDA = new SqlDataAdapter("SELECT  *FROM NewStudentsFirstYear Where UnivSpecialty ='" + CbSpesyaStuLIst.SelectedItem.ToString() + "' ", SconxList);

                DataTable ListStuTabel = new DataTable();
                SqlDA.Fill(ListStuTabel);
                GridViewListStu.AutoGenerateColumns = false;
                GridViewListStu.DataSource = ListStuTabel;
                SconxList.Close();

            }
        }
      
        public void StuListSearchByFiliere()
        {
            using (SqlConnection SconxList = new SqlConnection("Data Source=DESKTOP-IOTSGEA\\SQLEXPRESS;Initial Catalog=UniversityMi;Persist Security Info=True;User ID=AdamJx0;Password=00007896"))
            {
                SconxList.Open();
                SqlDataAdapter SqlDA = new SqlDataAdapter("SELECT  *FROM NewStudentsFirstYear Where UnivFiliere ='" + CbFiliereStuLIst.SelectedItem.ToString() + "'  ", SconxList);

                DataTable ListStuTabel = new DataTable();
                SqlDA.Fill(ListStuTabel);
                GridViewListStu.AutoGenerateColumns = false;
                GridViewListStu.DataSource = ListStuTabel;
                SconxList.Close();

            }
        }
        public void StuListSearchBylname()
        {
            using (SqlConnection SconxList = new SqlConnection("Data Source=DESKTOP-IOTSGEA\\SQLEXPRESS;Initial Catalog=UniversityMi;Persist Security Info=True;User ID=AdamJx0;Password=00007896"))
            {
                SconxList.Open();
                SqlDataAdapter SqlDA = new SqlDataAdapter("SELECT  *FROM NewStudentsFirstYear Where Fname ='" + TbSearchList.Text + "' AND Lname ='" + TbSearchList.Text + "' ", SconxList);

                DataTable ListStuTabel = new DataTable();
                SqlDA.Fill(ListStuTabel);
                GridViewListStu.AutoGenerateColumns = false;
                GridViewListStu.DataSource = ListStuTabel;
                SconxList.Close();
            }
        }


        public ShowStudentsList()
        {
            InitializeComponent();
            StuListView();


        }
       
        private void ShowStudentsList_Load(object sender, EventArgs e)
        {

        }

        private void GridViewListStu_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
            VScrollBarList.Maximum = GridViewListStu.RowCount-1;
            }
            catch (Exception)
            {

                
            }

        }

        private void VScrollBarList_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            try
            {
            GridViewListStu.FirstDisplayedScrollingRowIndex = GridViewListStu.Rows[e.Value].Index;
            }
            catch (Exception)
            {

                
            }

        }

        private void GridViewListStu_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                VScrollBarList.Maximum = GridViewListStu.RowCount - 1;
            }
            catch (Exception)
            {


            }
           
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if(TbSearchList.Text=="")
            {
                MessageBox.Show("لم تقم بادخال قيمة ", "تنبيه", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                StuListSearchByidCard();
            
            }

        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            StuListView();
            TbSearchList.Clear();
            CbFiliereStuLIst.Text = string.Empty;
            CbPathStuLIst.Text = string.Empty;
            CbSpesyaStuLIst.Text = string.Empty;
            CbYearStuLIst.Text = string.Empty;

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {


            if (CbFiliereStuLIst.SelectedItem==null& CbPathStuLIst.SelectedItem == null & CbSpesyaStuLIst.SelectedItem == null & CbYearStuLIst.SelectedItem == null)
            {
                MessageBox.Show("لم تقم بادخال قيمة ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                

            }






        }

        private void CbPathStuLIst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbPathStuLIst.SelectedItem.ToString() == "الكل")
            {
                StuListView();
            }
            else
            {
            StuListSearchByPath();
            }

        }

        private void CbYearStuLIst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbPathStuLIst.SelectedItem.ToString() == "الكل")
            {
                StuListView();
            }
            else
            {
                StuListSearchByYear();
            }
            
        }

        private void CbSpesyaStuLIst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbPathStuLIst.SelectedItem.ToString() == "الكل")
            {

                StuListView();
            }
            else
            {
                StuListSearchBySpesa();
            }
            
        }

        private void CbFiliereStuLIst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbPathStuLIst.SelectedItem.ToString() == "الكل")
            {
                StuListView();
            }
            else
            {
                StuListSearchByFiliere();
            }

        }
    }
}
