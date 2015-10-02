using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.OleDb;
using System.IO;
using System.Globalization;
using System.Text;

public partial class KrediKazanimUygulamasi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Import_Click(object sender, EventArgs e)
    {
        Boolean IsFirstRowHeader = CheckBox1.Checked;


        if (FileUpload1.HasFile)
        {

            string path = string.Concat(@"\\BTPRDOUT01\OUTPUT\OUTPUT\DMRapor\ALPER\PREGRINE_FOLDER\TempFiles\", FileUpload1.FileName);
            //Save File as Temp then you can delete it if you want
            FileUpload1.SaveAs(path);
            //string path = @"C:\Users\Johnney\Desktop\ExcelData.xls";
            //For Office Excel 2010  please take a look to the followng link  http://social.msdn.microsoft.com/Forums/en-US/exceldev/thread/0f03c2de-3ee2-475f-b6a2-f4efb97de302/#ae1e6748-297d-4c6e-8f1e-8108f438e62e
            string excelConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0", path);

            // string path = FileUpload1.
            Label2.Text = ConvertDataTable2HTMLString(CsvFileToDatatable(path, IsFirstRowHeader));
        }

    }
    public DataTable CsvFileToDatatable(string path, bool IsFirstRowHeader)
    {

        string header = "No";
        string sql = string.Empty;
        DataTable dataTable = null;
        string pathOnly = string.Empty;
        string fileName = string.Empty;
        try
        {
            pathOnly = Path.GetDirectoryName(path);
            fileName = Path.GetFileName(path);
            sql = @"SELECT * FROM [" + fileName + "]";
            if (IsFirstRowHeader)
            {
                header = "Yes";
            }
            using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathOnly +
            ";Extended Properties=\"Text;HDR=" + header + "\""))
            {
                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                    {
                        dataTable = new DataTable();
                        dataTable.Locale = CultureInfo.CurrentCulture;
                        adapter.Fill(dataTable);
                    }
                }
            }
        }
        finally
        {
        }

        return dataTable;
    }
    public string ConvertDataTable2HTMLString(DataTable dt)
    {
        // string strM = "EXEC KKBSITE_SP_FINANSAL " + ViewState["base"].ToString();

        String RVl = "";

        // DataTable dt = new DataTable();
        try
        {

            //  dt = PCL.MsSQL_DBOperations.GetData(STR, "SqlConn");

            // RV = dt.Rows[0]["URUN"].ToString().Trim();

            StringBuilder sb = new StringBuilder();
            sb.Append("<table class=\"urnTable\" style=\"max-width: 1100px; max-height: 750px; overflow: auto;\"><thead><tr>");
            foreach (DataColumn c in dt.Columns)
            {
                sb.AppendFormat("<th>{0}</th>", c.ColumnName);
            }
            sb.AppendLine("</tr></thead><tbody>");
            foreach (DataRow dr in dt.Rows)
            {
                sb.Append("<tr>"); foreach (object o in dr.ItemArray)
                {
                    sb.AppendFormat("<td>{0}</td>",
                    System.Web.HttpUtility.HtmlEncode(o.ToString()));
                } sb.AppendLine("</tr>");
            } sb.AppendLine("</tbody></table>");
            RVl = sb.ToString();
        }
        catch (Exception ex)
        {
            RVl = "HATA: " + ex;//  Page.ClientScript.RegisterStartupScript(typeof(Page), "bisey3", "alert('bunu Alper Özen e gönderiniz\n" + strM + "\n" + ex.ToString() + "');", true);
        }


        return RVl;
    }
}
