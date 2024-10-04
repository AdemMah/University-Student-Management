using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace UnivMI
{
    class ClassStudentId
    {
        //here get count and make id students like this form [MI-**-****-*****]
        public string GetMaxId()
        {
                    int intVal = 0;
                    using (SqlConnection Scon = new SqlConnection("Data Source=DESKTOP-IOTSGEA\\SQLEXPRESS;Initial Catalog=UniversityMi;Persist Security Info=True;User ID=AdamJx0;Password=00007896"))
                    {

                        using (SqlCommand cmdId = new SqlCommand("SELECT MAX(idCount) FROM NewStudentsFirstYear", Scon))
                        {

                            Scon.Open();
                            var pid = cmdId.ExecuteScalar() as string;


                            if (pid == null)
                            {
                                pid = "1";
                                intVal = Convert.ToInt32(pid);
                            }
                            else
                            {
                                intVal = int.Parse(pid);
                                intVal = intVal + 1;
                            }
                            string result = intVal.ToString("00000");
                            cmdId.ExecuteNonQuery();
                            Scon.Close();
                            return result;
                        }
                    }

        }
        public string YearOfBac(string CbBacPeriodOutSiFac)
        {
            string YeBac;
            YeBac = CbBacPeriodOutSiFac;
            string pidyear = YeBac.Substring(4);
            pidyear = pidyear.Substring(3);
            return pidyear;
        }
    }
}
