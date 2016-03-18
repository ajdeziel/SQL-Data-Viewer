using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            readSomethingFromSQL();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.ShowDialog();

            if(openFileDialog1.FileName != null && System.IO.File.Exists(openFileDialog1.FileName))
            {
                tbCsvInput.Text = openFileDialog1.FileName;
                btnImport.Enabled = true;
            }
            else
            {
                MessageBox.Show("You have selected and invalid file.");
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(tbCsvInput.Text))
            {
                
                //MessageBox.Show("Valid file, everything ready for import!");

                System.IO.StreamReader sr = new System.IO.StreamReader(tbCsvInput.Text);

                string line = sr.ReadLine();

                List<string> FirstName = new List<string>();
                List<string> LastName = new List<string>();
                List<string> LoginName = new List<string>();
                List<string> Country = new List<string>();

                line = sr.ReadLine();

                while(line != null)
                {

                    string[] tempSplit = line.Split(",".ToCharArray());

                    FirstName.Add(tempSplit[0]);
                    LastName.Add(tempSplit[1]);
                    LoginName.Add(tempSplit[2]);
                    Country.Add(tempSplit[3]);

                    line = sr.ReadLine();
                }


                sr.Close();

                InsertIntoDB(FirstName, LastName);

                DialogResult query = MessageBox.Show("Would you like to execute the predesignated SQL query?", "SQL Query Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (query == DialogResult.Yes)
                {
                    readSomethingFromSQL();

                }


            }


        }

        public void InsertIntoDB(List<string> FirstName, List<string> LastName)
        {
            string conStr = "Server=localhost\\sqlexpress;Database=AdventureWorks2014;Trusted_Connection=True;";

            System.Data.SqlClient.SqlConnection DbCon = new System.Data.SqlClient.SqlConnection(conStr);
            
            DbCon.Open();

            for (int i = 0; i < FirstName.Count; i++)
            {


                string SqlQuery = "INSERT INTO MyNames (FirstName,LastName) " + 
                                  "VALUES ('" + FirstName[i] + "','" + LastName[i] + "')";
            
         
                System.Data.SqlClient.SqlCommand DbCmd = new System.Data.SqlClient.SqlCommand(SqlQuery, DbCon);

                DbCmd.ExecuteNonQuery();
            }

            DbCon.Close();

        }

        public void readSomethingFromSQL()
        {
            string conStr = "Server=localhost\\sqlexpress;Database=AdventureWorks2014;Trusted_Connection=True;";

            System.Data.SqlClient.SqlConnection DbCon = new System.Data.SqlClient.SqlConnection(conStr);

            string SqlQuery = "SELECT * " +
                              "FROM MyNames";

            DbCon.Open();

            System.Data.SqlClient.SqlCommand DbCmd = new System.Data.SqlClient.SqlCommand(SqlQuery, DbCon);

            //System.Data.SqlClient.SqlDataReader dr = DbCmd.ExecuteReader(); --For reading Database

            System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();

            DataTable dt = new DataTable();
            dt.Locale = System.Globalization.CultureInfo.InvariantCulture;
            da.SelectCommand = DbCmd;
            da.Fill(dt);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dt;

            /* while (dr.Read())
            {

                string bla = dr["FirstName"].ToString();

            }*/ //For use with DataReader

            DbCon.Close();
       }

       private void RetrieveData_Click(object sender, EventArgs e)
       {

           readSomethingFromSQL();

       }
    }
}
