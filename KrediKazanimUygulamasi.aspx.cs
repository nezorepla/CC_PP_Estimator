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
 
 CREATE TABLE [dbo].KKG_DEF_DDL(
IntCode int identity(1,1)	,
DDLType varchar(50),
 DDLValue varchar(50))
   
     * 
     * 
     * insert into KKG_DEF_DDL values('ddlTelefonDurumu','Ulaşıldı')
insert into KKG_DEF_DDL values('ddlTelefonDurumu','Ulaşılamadı')
insert into KKG_DEF_DDL values('ddlIletisimSonucu','Peşin Ödeme Sözü Alındı')
insert into KKG_DEF_DDL values('ddlIletisimSonucu','Taksitli Ödeme Sözü Alındı')
insert into KKG_DEF_DDL values('ddlIletisimSonucu','Ödeme Sözü Alınamadı')
insert into KKG_DEF_DDL values('ddlIletisimSonucu','Borctan Sorumlu Olmadığına Dair İtiraz')
insert into KKG_DEF_DDL values('ddlIletisimSonucu','Dosya Avukatına Ödeme Sözü Vermiş')
insert into KKG_DEF_DDL values('ddlIletisimSonucu','Vefat Etmiş')
insert into KKG_DEF_DDL values('ddlAdresZiyareti','Evet')
insert into KKG_DEF_DDL values('ddlAdresZiyareti','Hayır')
insert into KKG_DEF_DDL values('ddlAdresZiyareti','Geçerli Adres Bulunamadı')
insert into KKG_DEF_DDL values('ddlZiyaretSonucu','Ziyaret Gerçekleşti')
insert into KKG_DEF_DDL values('ddlZiyaretSonucu','Adreste Bulunamadı')
insert into KKG_DEF_DDL values('ddlZiyaretSonucu','Adreste Başkası İkamet Ediyor')
insert into KKG_DEF_DDL values('ddlSulhSozlesmesi','Taksitli Sulh Söz. İmzalandı')
insert into KKG_DEF_DDL values('ddlSulhSozlesmesi','Peşin Sulh Söz. İmzalandı')
insert into KKG_DEF_DDL values('ddlSulhSozlesmesi','Hayır')
 
   create table KKG_DAT_ACT(
IntCode int identity(1,1),
 Sicil varchar(30),
 DT datetime,
        lblPortfoySorumlusu varchar(100),
        lblSubeAdi varchar(100) ,
        lblSubeIli varchar(100),
        lblMusteriNosu varchar(100),
        lblTakipId varchar(100),
        lblBilgi varchar(100) ,
        ddlTelefonDurumu varchar(100),
        txtTelefon varchar(100),
        ddlIletisimSonucu varchar(100),
        txtPesinOdemeTarihi varchar(100),
        txtPesinatTutari varchar(100),    
        txtPesinatTarihi varchar(100),
        txtTaksitSayisi varchar(100) ,
        txtPesinTutar varchar(100) ,
        ddlSulhSozlesmesi varchar(100),
        ddlAdresZiyareti varchar(100),
        txtAdres varchar(100),
        ddlZiyaretSonucu varchar(100)
        )
     * 
     create proc KKG_sp_ACT(
  @Sicil varchar(30),
         @lblPortfoySorumlusu varchar(100),
         @lblSubeAdi varchar(100) ,
         @lblSubeIli varchar(100),
         @lblMusteriNosu varchar(100),
         @lblTakipId varchar(100),
         @lblBilgi varchar(100) ,
         @ddlTelefonDurumu varchar(100),
         @txtTelefon varchar(100),
         @ddlIletisimSonucu varchar(100),
         @txtPesinOdemeTarihi varchar(100),
         @txtPesinatTutari varchar(100),    
         @txtPesinatTarihi varchar(100),
         @txtTaksitSayisi varchar(100) ,
         @txtPesinTutar varchar(100) ,
         @ddlSulhSozlesmesi varchar(100),
         @ddlAdresZiyareti varchar(100),
         @txtAdres varchar(100),
         @ddlZiyaretSonucu varchar(100)
          ) as
          
                insert into  KKG_DAT_ACT values( @Sicil ,GETDATE(),
         @lblPortfoySorumlusu ,
         @lblSubeAdi  ,
         @lblSubeIli ,
         @lblMusteriNosu ,
         @lblTakipId ,
         @lblBilgi  ,
         @ddlTelefonDurumu ,
         @txtTelefon ,
         @ddlIletisimSonucu ,
         @txtPesinOdemeTarihi ,
         @txtPesinatTutari ,    
         @txtPesinatTarihi ,
         @txtTaksitSayisi  ,
         @txtPesinTutar  ,
         @ddlSulhSozlesmesi ,
         @ddlAdresZiyareti ,
         @txtAdres ,
         @ddlZiyaretSonucu )*/

    private DataTable dataTable = null;
    private bool IsHeader = true;
    private string headerLine = string.Empty;
    private List<string> AllLines = new List<string>();
    private StringBuilder sb = new StringBuilder();
    private char seprateChar = ';';
    // string sqlConnectionStringyeni = @"Data Source=KRDPRDGEN01yeni;Initial Catalog=CCOps; uid=CollUser; Password = Coll123456;Connection Timeout=120;";
    public static string sqlConnectionStringyeni = @"Data Source=.;Initial Catalog=Collection;User Id=sa;Password=Peno0000;  Connection Timeout=1200";

    public string USER = "A25318";// HttpContext.Current.User.Identity.Name.ToUpper().Replace("İ", "I").Substring(7, 6).ToString();

    //string yol = @"\\BTPRDOUT01\OUTPUT\OUTPUT\DMRapor\ALPER\KKG_FILES\TempFiles\";
    string yol = @"C:\TempFiles\";
    //  string path = string.Concat(@"C:\TempFiles\", FileUpload1.FileName);


    string sqlConnectionString = @"Data Source=KRDPRDGEN01;Initial Catalog=CCOps; uid=CollUser; Password = Coll123456;Connection Timeout=120;";
    public static DataTable dtExcelRecords;// = new DataTable();
    public static OleDbConnection con;// = new OleDbConnection(connectionString);
    public static OleDbCommand cmd;// = new OleDbCommand();
    public static OleDbDataAdapter dAdapter;//


    private static void ExecuteSQLStr(string queryString, string connectionString)
    {

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
        DataTable dt = PCL.MsSQL_DBOperations.GetData("EXEC [KKG_SP_SEARCH] '" + txtBase.Text.ToString() + "', '" + USER + "'", "SqlConny");
        lblCont.Text = ConvertDataTable2HTMLString(HTMLTransposedTable(dt));
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            ImportArea.Visible = false;

            if (Request["__EVENTTARGET"] == "IslemYap")
            {
                //do something
                IslemYap(Request["__EVENTARGUMENT"].ToString());
            }
        }
        else
        {
            FillDDLs(); ClearPage();
            TanimliMusteriler();
        }
    }
    protected void btnTamamla_Click(object sender, EventArgs e)
    {

        string text = "exec KKG_sp_ACT '" + USER + "'," +
        "'" + lblPortfoySorumlusu.Text + "'," +
        "'" + lblSubeAdi.Text + "'," +
        "'" + lblSubeIli.Text + "'," +
        "'" + lblMusteriNosu.Text + "'," +
        "'" + lblTakipId.Text + "'," +
        "'" + lblBilgi.Text + "'," +
        "'" + ddlTelefonDurumu.SelectedValue.Trim() + "'," +
        "'" + txtTelefon.Text + "'," +
        "'" + ddlIletisimSonucu.SelectedValue.Trim() + "'," +
        "'" + txtPesinOdemeTarihi.Text + "'," +
        "'" + txtPesinatTutari.Text + "'," +
        "'" + txtPesinatTarihi.Text + "'," +
        "'" + txtTaksitSayisi.Text + "'," +
        "'" + txtPesinTutar.Text + "'," +
        "'" + ddlSulhSozlesmesi.SelectedValue.Trim() + "'," +
        "'" + ddlAdresZiyareti.SelectedValue.Trim() + "'," +
        "'" + txtAdres.Text + "'," +
        "'" + ddlZiyaretSonucu.SelectedValue.Trim() + "'";


        PCL.MsSQL_DBOperations.ExecuteSQLStr(text, "SqlConny");

        Page.ClientScript.RegisterStartupScript(typeof(Page), "msgseysi2", "alert('Aksiyon Basariyla Eklenmistir.')", true);
        ClearPage();
    }

    void ClearPage()
    {
        lblPortfoySorumlusu.Text = null;
        lblSubeAdi.Text = null;
        lblSubeIli.Text = null;
        lblMusteriNosu.Text = null;
        lblTakipId.Text = null;

        lblBilgi.Text = null;
        //ddlTelefonDurumu
        txtAdres.Text = null;
        txtBase.Text = null;
        txtPesinatTarihi.Text = null;
        txtPesinatTutari.Text = null;
        txtPesinOdemeTarihi.Text = null;
        txtPesinTutar.Text = null;
        txtTaksitSayisi.Text = null;
        txtTelefon.Text = null;


    }
    public void IslemYap(string TakipId)
    {
        FillDDLs();
        ClearPage();
        //  lblCont.Text = "";

        //alert(TakipId);

        //create proc [dbo].[KKG_SP_TAKIPID] (@ID INT)
        //as
        //select  * from dbo.KKG_T_TEMP
        //where TAKIP_ID=@ID



        DataTable dt = PCL.MsSQL_DBOperations.GetData("EXEC KKG_SP_TAKIPID    " + TakipId, "SqlConny");

        //Portföy Sorumlusu	
        //Şube Adı	
        //Şube İli	
        //Müşteri Nosu	
        //Kredi No/Kart No - Adı Soyadı
        //      URUN_ADSOYAD,, PORTFOY_SORUMLUSU_SICIL, SUBE_ADI, SUBE_ILI, MUSTERI_NO
        lblPortfoySorumlusu.Text = dt.Rows[0]["PORTFOY_SORUMLUSU"].ToString();
        lblSubeAdi.Text = dt.Rows[0]["SUBE_ADI"].ToString();
        lblSubeIli.Text = dt.Rows[0]["SUBE_ILI"].ToString();
        lblMusteriNosu.Text = dt.Rows[0]["MUSTERI_NO"].ToString();
        lblBilgi.Text = dt.Rows[0]["URUN_ADSOYAD"].ToString();
        lblTakipId.Text = dt.Rows[0]["TAKIP_ID"].ToString();
    }
    public void TanimliMusteriler()
    {
        try
        {
            DataTable dt = PCL.MsSQL_DBOperations.GetData("EXEC [KKG_SP_TANIMLI]   '" + USER + "'", "SqlConny");
            lblCont.Text = ConvertDataTable2HTMLString(HTMLTransposedTable(dt));
            //;
        }
        catch (Exception e) { }
    }

    public static DataTable HTMLTransposedTable(DataTable inputTable)
    {
        DataTable outputTable = new DataTable();
        // Add columns by looping rows
        // Header row's first column is same as in inputTable
        outputTable.Columns.Add(inputTable.Columns[0].ColumnName.ToString());
        // Header row's second column onwards, 'inputTable's first column taken
        foreach (DataRow inRow in inputTable.Rows)
        {
            string newColName = inRow[0].ToString();
            outputTable.Columns.Add(newColName);
        }
        // Add rows by looping columns       
        for (int rCount = 1; rCount <= inputTable.Columns.Count - 1; rCount++)
        {
            DataRow newRow = outputTable.NewRow();
            // First column is inputTable's Header row's second column
            newRow[0] = inputTable.Columns[rCount].ColumnName.ToString();
            for (int cCount = 0; cCount <= inputTable.Rows.Count - 1; cCount++)
            {
                string colValue = inputTable.Rows[cCount][rCount].ToString();
                newRow[cCount + 1] = colValue;
            }
            outputTable.Rows.Add(newRow);
        }
        return outputTable;

    }

    public void FillDDLs()
    {
        DataTable dt = new DataTable();
        ListItem li = new ListItem("Seçiniz", "0");
        ddlAdresZiyareti.Items.Clear();
        ddlAdresZiyareti.Items.Add(li);


        ddlIletisimSonucu.Items.Clear();
        ddlIletisimSonucu.Items.Add(li);


        ddlSulhSozlesmesi.Items.Clear();
        ddlSulhSozlesmesi.Items.Add(li);


        ddlTelefonDurumu.Items.Clear();
        ddlTelefonDurumu.Items.Add(li);



        ddlZiyaretSonucu.Items.Clear();
        ddlZiyaretSonucu.Items.Add(li);


        dt = PCL.MsSQL_DBOperations.GetData("exec KKG_SP_DDL 'ddlAdresZiyareti'", "SqlConny");
        foreach (DataRow dr in dt.Rows)
        {
            li = new ListItem(dr["DDLValue"].ToString(), dr["IntCode"].ToString());

            ddlAdresZiyareti.Items.Add(li);
        }



        dt = PCL.MsSQL_DBOperations.GetData("exec KKG_SP_DDL 'ddlIletisimSonucu'", "SqlConny");
        foreach (DataRow dr in dt.Rows)
        {
            li = new ListItem(dr["DDLValue"].ToString(), dr["IntCode"].ToString());

            ddlIletisimSonucu.Items.Add(li);
        }

        dt = PCL.MsSQL_DBOperations.GetData("exec KKG_SP_DDL 'ddlSulhSozlesmesi'", "SqlConny");
        foreach (DataRow dr in dt.Rows)
        {
            li = new ListItem(dr["DDLValue"].ToString(), dr["IntCode"].ToString());

            ddlSulhSozlesmesi.Items.Add(li);
        }

        dt = PCL.MsSQL_DBOperations.GetData("exec KKG_SP_DDL 'ddlTelefonDurumu'", "SqlConny");
        foreach (DataRow dr in dt.Rows)
        {
            li = new ListItem(dr["DDLValue"].ToString(), dr["IntCode"].ToString());

            ddlTelefonDurumu.Items.Add(li);
        }


        dt = PCL.MsSQL_DBOperations.GetData("exec KKG_SP_DDL 'ddlZiyaretSonucu'", "SqlConny");
        foreach (DataRow dr in dt.Rows)
        {
            li = new ListItem(dr["DDLValue"].ToString(), dr["IntCode"].ToString());

            ddlZiyaretSonucu.Items.Add(li);
        }



    }


    protected void Import_Click(object sender, EventArgs e)
    {
        Boolean IsFirstRowHeader = CheckBox1.Checked;

        ExecuteSQLStr("truncate table KKG_T_TEMP", sqlConnectionStringyeni);

        if (FileUpload1.HasFile)
        {

            string path = string.Concat(yol, FileUpload1.FileName);

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
                           new SqlBulkCopy(sqlConnectionStringyeni))
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
            sb.Append("<table class=\"urnTable\" style=\"max-width: 1100px; max-height: 750px; overflow: auto;  border-style: solid;   border-width: 1px;\"><thead><tr>");
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
        if (USER == "A25318" || USER == "A11267" || USER == "A15894")
        {
            ImportArea.Visible = true;
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(typeof(Page), "msgseysi", "alert('Bu Islem Icin Yetkiniz Bulunmamaktadir.')", true);
        }
    }

}
