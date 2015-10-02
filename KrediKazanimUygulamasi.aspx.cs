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

public partial class KrediKazanimUygulamasi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Import_Click(object sender, EventArgs e)
    {

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

}
