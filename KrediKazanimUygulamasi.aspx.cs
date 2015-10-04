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
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Common;

public partial class KrediKazanimUygulamasi : System.Web.UI.Page
{
    /*
    CREATE TABLE [dbo].KKG_T_TEMP(
    PORTFOY_SORUMLUSU	varchar(250)	,
    PORTFOY_SORUMLUSU_SICIL	varchar(10)	,
    SUBE_ADI	varchar(250)	,
    SUBE_ILI	varchar(10)	,
    MUSTERI_NO	int	,
    TAKIP_ID	int	,
    URUN_ADSOYAD	varchar(250)	,
    BASLANGIC_TAHSILATI	float	,
    GUN_TAHSILATI	float	,
    PROJE_KAPSAMINDA_TAHSILAT	float	,
    SON_TAHSILAT_TARIHI	float	,
    A_TUTAR_1	float	,
    A_TUTAR_2	float	,
    A_TUTAR_3	float	,
    B_TUTAR_1	float	,
    B_TUTAR_2	float	,
    B_TUTAR_3	float	
    ) ON [PRIMARY]

create proc KKG_SP_SEARCH (@BASE INT,@USER VARCHAR(10)) as
select *,'<a href="javascript:alert('+convert(varchar(30),TAKIP_ID)+');">ISLEM YAP</a>' from KKG_T_TEMP
where MUSTERI_NO= @BASE

 
 
    */

    private DataTable dataTable = null;
    private bool IsHeader = true;
    private string headerLine = string.Empty;
    private List<string> AllLines = new List<string>();
    private StringBuilder sb = new StringBuilder();
    private char seprateChar = ';';

    public static string connectionString = @"Data Source=.;Initial Catalog=Collection;User Id=sa;Password=Peno0000;  Connection Timeout=1200";
    public static DataTable dtExcelRecords;// = new DataTable();
    public static OleDbConnection con;// = new OleDbConnection(connectionString);
    public static OleDbCommand cmd;// = new OleDbCommand();
    public static OleDbDataAdapter dAdapter;//

    public string USER = "qq";//HttpContext.Current.User.Identity.Name.ToUpper().Replace("İ", "I").Substring(7, 6).ToString();

    private static void ExecuteSQLStr(string queryString, string connectionString)
    {
        //string sqlConnectionStringyeni = @"Data Source=KRDPRDGEN01yeni;Initial Catalog=CCOps; uid=CollUser; Password = Coll123456;Connection Timeout=120;";
        //string sqlConnectionString = @"Data Source=KRDPRDGEN01;Initial Catalog=CCOps; uid=CollUser; Password = Coll123456;Connection Timeout=120;";

        using (SqlConnection connection = new SqlConnection(
                   connectionString))
        {
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Connection.Open();
            command.ExecuteNonQuery();
        }

        //  Application.Exit();
    }
    protected void btnGet_Click(object sender, EventArgs e)
    {
        DataTable dt = PCL.MsSQL_DBOperations.GetData("EXEC [KKG_SP_SEARCH] '" + txtBase.Text.ToString() + "', '" + USER + "'", "coll");
        lblCont.Text = ConvertDataTable2HTMLString(dt);
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            if (Request["__EVENTTARGET"] == "yap" )
            {
                //do something
                lblCont.Text = Request["__EVENTARGUMENT"].ToString();
            }
        }
    }
    protected void Import_Click(object sender, EventArgs e)
    {
        Boolean IsFirstRowHeader = CheckBox1.Checked;

        ExecuteSQLStr("truncate table KKG_T_TEMP", connectionString);

        if (FileUpload1.HasFile)
        {

            //            string path = string.Concat(@"\\BTPRDOUT01\OUTPUT\OUTPUT\DMRapor\ALPER\PREGRINE_FOLDER\TempFiles\", FileUpload1.FileName);
            string path = string.Concat(@"C:\TempFiles\", FileUpload1.FileName);
            //Save File as Temp then you can delete it if you want

            FileUpload1.SaveAs(path);
            //string path = @"C:\Users\Johnney\Desktop\ExcelData.xls";
            //For Office Excel 2010  please take a look to the followng link  http://social.msdn.microsoft.com/Forums/en-US/exceldev/thread/0f03c2de-3ee2-475f-b6a2-f4efb97de302/#ae1e6748-297d-4c6e-8f1e-8108f438e62e
            string excelConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0", path);


            dtExcelRecords = ReadCSV(path, IsFirstRowHeader, ';');

            //dAdapter.SelectCommand = cmd;
            //dAdapter.Fill(dtExcelRecords);



            try
            {
                //using (DbDataReader dr = cmd.ExecuteReader())
                //{
                    using (SqlBulkCopy bulkCopy =
                               new SqlBulkCopy(connectionString))
                    {
                        bulkCopy.DestinationTableName = "dbo.KKG_T_TEMP";
                        bulkCopy.WriteToServer(dtExcelRecords);


                    }

                //}
                txtUyari.Text = "Data Aktarildi.";
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                txtUyari.Text = ex.ToString();
            }


            // string path = FileUpload1.
            // Label2.Text = ConvertDataTable2HTMLString(CsvFileToDatatable(path, IsFirstRowHeader));
        }

    }
    //public DataTable CsvFileToDatatable(string path, bool IsFirstRowHeader)
    //{

    //    string header = "No";
    //    string sql = string.Empty;
    //    DataTable dataTable = null;
    //    string pathOnly = string.Empty;
    //    string fileName = string.Empty;
    //    try
    //    {
    //        pathOnly = Path.GetDirectoryName(path);
    //        fileName = Path.GetFileName(path);
    //        sql = @"SELECT * FROM [" + fileName + "]";
    //        if (IsFirstRowHeader)
    //        {
    //            header = "Yes";
    //        }
    //        using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathOnly +
    //        ";Extended Properties=\"Text;HDR=" + header + "\""))
    //        {
    //            using (OleDbCommand command = new OleDbCommand(sql, connection))
    //            {
    //                using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
    //                {
    //                    dataTable = new DataTable();
    //                    dataTable.Locale = CultureInfo.CurrentCulture;
    //                    adapter.Fill(dataTable);
    //                }
    //            }
    //        }
    //    }
    //    finally
    //    {
    //    }

    //    return dataTable;
    //}
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
                    //System.Web.HttpUtility.HtmlEncode(o.ToString()));
                    o.ToString());
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



    public DataTable ReadCSV(string path, bool IsReadHeader, char serparationChar)
    {
        seprateChar = serparationChar;
        IsHeader = IsReadHeader;
        using (StreamReader sr = new StreamReader(path, Encoding.Default))
        {
            while (!sr.EndOfStream)
            {
                AllLines.Add(sr.ReadLine());
            }
            createTemplate(AllLines);
        }

        return dataTable;
    }
    public void WriteCSV(string path, DataTable dtable, char serparationChar)
    {
        AllLines = new List<string>();
        seprateChar = serparationChar;
        List<string> StableHeadrs = new List<string>();
        int colCount = 0;
        using (StreamWriter sw = new StreamWriter(path))
        {
            foreach (DataColumn col in dtable.Columns)
            {
                sb.Append(col.ColumnName);
                if (dataTable.Columns.Count - 1 > colCount)
                    sb.Append(seprateChar);
                colCount++;
            }
            AllLines.Add(sb.ToString());

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                // sb.Clear();
                // sb.
                for (int j = 0; j < dtable.Columns.Count; j++)
                {
                    sb.Append(Convert.ToString(dtable.Rows[i][j]));
                    if (dataTable.Columns.Count - 1 > j)
                        sb.Append(seprateChar);
                }
                AllLines.Add(sb.ToString());
            }

            foreach (string dataline in AllLines)
            {
                sw.WriteLine(dataline);
            }
        }


    }

    private DataTable createTemplate(List<string> lines)
    {

        List<string> headers = new List<string>();
        dataTable = new DataTable();
        if (lines.Count > 0)
        {
            string[] argHeaders = null;
            for (int i = 0; i < lines.Count; i++)
            {
                if (i > 0)
                {
                    DataRow newRow = dataTable.NewRow();
                    // others add to rows
                    string[] argLines = lines[i].Split(seprateChar);
                    for (int b = 0; b < argLines.Length; b++)
                    {
                        newRow[b] = argLines[b];
                    }
                    dataTable.Rows.Add(newRow);

                }
                else
                {
                    // header add to columns
                    argHeaders = lines[0].Split(seprateChar);
                    foreach (string c in argHeaders)
                    {
                        DataColumn column = new DataColumn(c, typeof(string));
                        dataTable.Columns.Add(column);
                    }
                }

            }

        }
        return dataTable;
    }


    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
}
