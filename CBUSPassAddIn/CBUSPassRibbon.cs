using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.Diagnostics;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CBUSPassAddIn
{
    public partial class CBUSPassRibbon
    {
        TableValue rtv = new TableValue();
        
        private void CBUSPassRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            rtv.RuntimeValue = "Not set";
        }

        private void btnReports_Click(object sender, RibbonControlEventArgs e)
        {
            Process.Start("http://google.com");
        }

        private void ebUserInput_TextChanged(object sender, RibbonControlEventArgs e)
        {
            try
            {
                rtv.UpdateRuntimeValue(ebUserInput.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid value");
            }
        }

        private void btnSubmit_Click(object sender, RibbonControlEventArgs e)
        {
            SqlConnectionStringBuilder sqlConnString = new SqlConnectionStringBuilder();
            sqlConnString.DataSource = "localhost";
            sqlConnString.InitialCatalog = "CBUSPass";
            sqlConnString.IntegratedSecurity = true;

            SqlConnection sqlConn = new SqlConnection(sqlConnString.ConnectionString);
            SqlCommand execCommand = new SqlCommand("UPDATE dbo.RunTimeVariable SET RuntimeValue = '" + rtv.RuntimeValue.ToString() + "'", sqlConn);
            sqlConn.Open();
            int result = execCommand.ExecuteNonQuery();
            sqlConn.Close();

            MessageBox.Show("Number of rows updated: " + result.ToString());

        }

        private void btnExecute_Click(object sender, RibbonControlEventArgs e)
        {
            SqlConnectionStringBuilder sqlConnString = new SqlConnectionStringBuilder();
            sqlConnString.DataSource = "localhost";
            sqlConnString.InitialCatalog = "CBUSPass";
            sqlConnString.IntegratedSecurity = true;

            SqlConnection sqlConn = new SqlConnection(sqlConnString.ConnectionString);
            SqlCommand execCommand = new SqlCommand("EXEC msdb.dbo.sp_start_job @job_name = 'CBUSPass Job';", sqlConn);

            DialogResult dr = MessageBox.Show("Please confirm."
            + Environment.NewLine + "Job will be executed."
            , "Confirmation"
            , MessageBoxButtons.OKCancel
            , MessageBoxIcon.Question
            , MessageBoxDefaultButton.Button1);

            if (dr == DialogResult.OK)
            {
                sqlConn.Open();
                int result = execCommand.ExecuteNonQuery();
                sqlConn.Close();
            }
        }
    }

    public class TableValue
    {
        public string RuntimeValue {get;set;}

        public void UpdateRuntimeValue(string runtimevalue)
        {
            RuntimeValue = runtimevalue;
        }
    }
}
