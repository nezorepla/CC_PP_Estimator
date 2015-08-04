using System;

using System.Data;

using System.Collections.Generic;

using System.Globalization;

using System.Web;

 

/// <summary>

/// Summary description for PaymentPlan

/// </summary>

public class PaymentPlan

{

    clsEKB cEKB = new clsEKB();

 

    #region MyClass Private Variables

    private Int64 cIntCode;

    private Decimal cBaseNo;

    private Decimal cCardNo;

    private String cCustName;

    private String cCustGroup;

    private String cPymt_Plan_F;

    private String cBirthDate;

    private Int16 cCustScore;

    private String cDlq_Code_Id;

    private Decimal cLimit;

    private Decimal cPrevLimit;

    private String cOPType;

    private String cStmt_Date; //EKT

    private String cSOT_Date;

    private Decimal cKisitYuzdesi;

    private Decimal cAcikProvizyon;

    private Decimal cIntrerestRate;

    private Decimal cInstallmentAmount;

    private Decimal cToplamBorc;

    private Decimal cGeriOdenecekTutar;

    private Int16 cTaksitSayisi;

    private String cHesapOzetiTarihi;

    private String cProtokolAdresi;

 

    private String cProtokolEmail;

    private String cProtokolFax;

    private String cIlkTaksitTarihi;

    private Int16 cStateIntCode;

    private Decimal cMaxBakiye;

    private String cBSDEDate;

    private String cAdinaProtokol;

    private String cUserId;

    private String cDescription;

    private String cWarning;

    /* Peno*/

    private Boolean cIsPPInfoFound;

    private Int16 cBekleyenTaksitAdet;

    private Decimal cPPSonrasiOdenen;

    private DateTime cPPTarihi;

    private Decimal cTaksitTutari;

    private Int16 cState;

    private Decimal cToplamTutarYYP;

    private Boolean cIsPP;

    private Int32 cDaysPast;

    private Boolean cIsPPAllowed;

    private Boolean cIsYYPAllowed;

    private Boolean cIsException;

    private Boolean cCheckPayment;

    private Boolean cVadeSil;

 

 

    /* Peno*/

    private Decimal cMevAnaPara;

    private Int32 cMevTaksitSayisi;

    private Decimal cMevFaizOrani;

    private Decimal cOPFee;

    private Decimal cFaizOrani;

 

    private String cClassifying_Grade;

 

    /* alper */

    private Int16 cMaxGGS;

    private Boolean cIsCustomerFound;

    private Boolean cDownPayment;

    private string cEDWUserId;

    private string cEDWPassword;

    private Boolean cEdwGecikme;

    private Int16 cFPD_HR;

    private Decimal cFaizsizBakiye;

    private string cCDA_ST;

    private string cFLW_ST;

 

    private Int16 cYY_KATSAYI;

 

    private Int16 cPPCount;

    private Decimal cDefaultFaiz;

 

 

    private string cPOTANSIYEL_F;

 

 

    private String cProtokolAdresi_il;

    private String cProtokolAdresi_ilce;

 

    private Int16 cStartDLQ;

    private Int16 cEndDLQ;

 

    private Boolean cIsBusiness;

    private Boolean cIsSpecial;

    private Boolean cVEFATACIK;

    private Boolean cIKINCILER;

    private Boolean cUCUNCULER;

    private Boolean cBIRTAKSITODEME;

    private Boolean cCDAACIK;

    private Boolean cPESINATISTE;

    private Boolean cBV_YYP_ALLOWED;

 

    private Boolean cIsBACKDOWN;

 

 

 

 

    #endregion

    public Boolean VadeSil

    {

        get

        {

            return cVadeSil;

        }

        set

        {

            cVadeSil = value;

        }

    }

 

    public Boolean IsBACKDOWN

    {

        get

        {

            return cIsBACKDOWN;

        }

        set

        {

            cIsBACKDOWN = value;

        }

    }

 

 

    #region MyClass Public Variables

 

    public Int64 IntCode { get { return cIntCode; } set { cIntCode = value; } }

    public Int16 PPCount

    {

        get

        {

            return cPPCount;

        }

        set

        {

            cPPCount = value;

        }

    }

    public Int16 YY_KATSAYI

    {

        get

        {

            return cYY_KATSAYI;

        }

        set

        {

            cYY_KATSAYI = value;

        }

    }

 

    public Decimal DefaultFaiz

    {

        get

        {

            return cDefaultFaiz;

        }

        set

        {

            cDefaultFaiz = value;

        }

    }

 

 

    public Decimal BaseNo

    {

        get

        {

            return cBaseNo;

        }

        set

        {

            cBaseNo = value;

        }

    }

    public Decimal FaizOrani

    {

        get

        {

            return cFaizOrani;

        }

        set

        {

            cFaizOrani = value;

        }

    }

 

 

    public Decimal CardNo

    {

        get

        {

            return cCardNo;

        }

        set

        {

            cCardNo = value;

        }

    }

    public String CustName

    {

        get

        {

            return cCustName;

        }

        set

        {

            cCustName = value;

        }

    }

    public String CustGroup

    {

        get

        {

            return cCustGroup;

        }

        set

        {

            cCustGroup = value;

        }

    }

    public String Pymt_Plan_F

    {

        get

        {

            return cPymt_Plan_F;

        }

        set

        {

            cPymt_Plan_F = value;

        }

    }

    public String BirthDate

    {

        get

        {

            return cBirthDate;

        }

        set

        {

            cBirthDate = value;

        }

    }

    public Int16 CustScore

    {

        get

        {

            return cCustScore;

        }

        set

        {

            cCustScore = value;

        }

    }

    public String Dlq_Code_Id

    {

        get

        {

            return cDlq_Code_Id;

        }

        set

        {

            cDlq_Code_Id = value;

        }

    }

    public Decimal Limit

    {

        get

        {

            return cLimit;

        }

        set

        {

            cLimit = value;

        }

    }

    public Decimal PrevLimit

    {

        get

        {

            return cPrevLimit;

        }

        set

        {

            cPrevLimit = value;

        }

    }

 

    public String OPType

    {

        get

        {

            return cOPType;

        }

        set

        {

            cOPType = value;

        }

    }

    public String Stmt_Date

    {

        get

        {

            return cStmt_Date;

        }

        set

        {

            cStmt_Date = value;

        }

    }

    public String SOT_Date

    {

        get

        {

            return cSOT_Date;

        }

        set

        {

            cSOT_Date = value;

        }

    }

    public Decimal KisitYuzdesi

    {

        get

        {

            return cKisitYuzdesi;

        }

        set

        {

            cKisitYuzdesi = value;

        }

    }

    public Decimal AcikProvizyon

    {

        get

        {

            return cAcikProvizyon;

        }

        set

        {

            cAcikProvizyon = value;

        }

    }

    public Decimal IntrerestRate

    {

        get

        {

            return cIntrerestRate;

        }

        set

        {

            cIntrerestRate = value;

        }

    }

    public Decimal InstallmentAmount

    {

        get

        {

            return cInstallmentAmount;

        }

        set

        {

            cInstallmentAmount = value;

        }

    }

    public Decimal ToplamBorc

    {

        get

        {

            return cToplamBorc;

        }

        set

        {

            cToplamBorc = value;

        }

    }

    public Decimal GeriOdenecekTutar

    {

        get

        {

            return cGeriOdenecekTutar;

        }

        set

        {

            cGeriOdenecekTutar = value;

        }

    }

    public Int16 TaksitSayisi

    {

        get

        {

            return cTaksitSayisi;

        }

        set

        {

            cTaksitSayisi = value;

        }

    }

    public String HesapOzetiTarihi

    {

        get

        {

            return cHesapOzetiTarihi;

        }

        set

        {

            cHesapOzetiTarihi = value;

        }

    }

    public String ProtokolAdresi

    {

        get

        {

            return cProtokolAdresi;

        }

        set

        {

            cProtokolAdresi = value;

        }

    }

 

 

 

 

    public String ProtokolEmail

    {

        get

        {

            return cProtokolEmail;

        }

        set

        {

            cProtokolEmail = value;

        }

    }

    public String ProtokolFax

    {

        get

        {

            return cProtokolFax;

        }

        set

        {

            cProtokolFax = value;

        }

    }

    public String IlkTaksitTarihi

    {

        get

        {

            return cIlkTaksitTarihi;

        }

        set

        {

            cIlkTaksitTarihi = value;

        }

    }

    public Int16 StateIntCode

    {

        get

        {

            return cStateIntCode;

        }

        set

        {

            cStateIntCode = value;

        }

    }

    public Decimal MaxBakiye

    {

        get

        {

            return cMaxBakiye;

        }

        set

        {

            cMaxBakiye = value;

        }

    }

    public String BSDEDate

    {

        get

        {

            return cBSDEDate;

        }

        set

        {

            cBSDEDate = value;

        }

    }

    public String AdinaProtokol

    {

        get

        {

            return cAdinaProtokol;

        }

        set

        {

            cAdinaProtokol = value;

        }

    }

    public String UserId

    {

        get

        {

           return cUserId;

        }

        set

        {

            cUserId = value;

        }

    }

    public String Description

    {

        get

        {

            return cDescription;

        }

        set

        {

            cDescription = value;

        }

    }

    public Int16 BekleyenTaksitAdet

    {

        get

        {

            return cBekleyenTaksitAdet;

        }

        set

        {

            cBekleyenTaksitAdet = value;

        }

    }

    public Decimal PPSonrasiOdenen

    {

        get

        {

            return cPPSonrasiOdenen;

        }

        set

        {

            cPPSonrasiOdenen = value;

        }

    }

    public DateTime PPTarihi

    {

        get

        {

            return cPPTarihi;

        }

        set

        {

            cPPTarihi = value;

        }

    }

    public Decimal TaksitTutari

    {

        get

        {

            return cTaksitTutari;

        }

        set

        {

            cTaksitTutari = value;

        }

    }

    public Int16 State

    {

        get

        {

            return cState;

        }

        set

        {

            cState = value;

        }

    }

    public Decimal ToplamTutarYYP

    {

        get

        {

            return cToplamTutarYYP;

        }

        set

        {

            cToplamTutarYYP = value;

        }

    }

    public Boolean IsPP

    {

        get

        {

            return cIsPP;

        }

        set

        {

            cIsPP = value;

        }

    }

    public Int32 DaysPast

    {

        get

        {

            return cDaysPast;

        }

        set

        {

            cDaysPast = value;

        }

    }

    public Boolean IsPPInfoFound

    {

        get

        {

            return cIsPPInfoFound;

        }

        set

        {

            cIsPPInfoFound = value;

        }

    }

 

 

    public Boolean IsPPAllowed

    {

        get

        {

            return cIsPPAllowed;

        }

        set

        {

            cIsPPAllowed = value;

        }

    }

    public Boolean IsYYPAllowed

    {

        get

        {

            return cIsYYPAllowed;

        }

        set

        {

            cIsYYPAllowed = value;

        }

    }

    public Boolean IsException

    {

        get

        {

            return cIsException;

        }

        set

        {

            cIsException = value;

        }

    }

    public Boolean CheckPayment

    { get { return cCheckPayment; } }

    public String Warning

    { get { return cWarning; } }

    public Decimal OPFee

    { get { return cOPFee; } }

    public String Classifying_Grade

    { get { return cClassifying_Grade; } }

 

 

 

    /* alper */

 

    public Int16 MaxGGS

    {

        get

        {

            return cMaxGGS;

        }

        set

        {

            cMaxGGS = value;

        }

    }

    public Boolean IsCustomerFound

    {

        get

        {

            return cIsCustomerFound;

        }

        set

        {

            cIsCustomerFound = value;

        }

    }

    public Boolean DownPayment

    {

        get

        {

            return cDownPayment;

        }

        set

        {

            cDownPayment = value;

        }

    }

    public Boolean EdwGecikme

    {

        get

        {

            return cEdwGecikme;

        }

        set

        {

            cEdwGecikme = value;

        }

    }

    public Boolean IsBusiness

    {

        get

        {

            return cIsBusiness;

        }

        set

        {

            cIsBusiness = value;

        }

    }

    public Boolean IsSpecial

    {

        get

        {

            return cIsSpecial;

        }

        set

        {

            cIsSpecial = value;

        }

    }

 

 

    public Boolean CDAACIK

    {

        get

        {

            return cCDAACIK;

        }

        set

        {

            cCDAACIK = value;

        }

    }

 

    public Boolean VEFATACIK

    {

        get

        {

            return cVEFATACIK;

        }

        set

        {

            cVEFATACIK = value;

        }

    }

    public Boolean IKINCILER

    {

        get

        {

            return cIKINCILER;

        }

        set

        {

            cIKINCILER = value;

        }

    }

 

    public Boolean UCUNCULER

    {

        get

        {

            return cUCUNCULER;

        }

        set

        {

            cUCUNCULER = value;

        }

    }

 

 

    public Boolean BIRTAKSITODEME

    {

        get

        {

            return cBIRTAKSITODEME;

        }

        set

        {

            cBIRTAKSITODEME = value;

        }

    }

    public Boolean PESINATISTE

    {

        get

        {

            return cPESINATISTE;

        }

        set

        {

            cPESINATISTE = value;

        }

    }

    public Boolean BV_YYP_ALLOWED

    {

        get

        {

            return cBV_YYP_ALLOWED;

        }

        set

        {

            cBV_YYP_ALLOWED = value;

        }

    }

 

 

    public Int16 FPD_HR { get { return cFPD_HR; } set { cFPD_HR = value; } }

    public Int16 StartDLQ { get { return cStartDLQ; } set { cStartDLQ = value; } }

    public Int16 EndDLQ { get { return cEndDLQ; } set { cEndDLQ = value; } }

    public Decimal FaizsizBakiye

    { get { return cFaizsizBakiye; } set { cFaizsizBakiye = value; } }

    public String CDA_ST { get { return cCDA_ST; } set { cCDA_ST = value; } }

    public String FLW_ST { get { return cFLW_ST; } set { cFLW_ST = value; } }

    public String POTANSIYEL_F { get { return cPOTANSIYEL_F; } set { cPOTANSIYEL_F = value; } }

 

    public String ProtokolAdresi_il

    {

        get

        {

            return cProtokolAdresi_il;

        }

        set

        {

            cProtokolAdresi_il = value;

        }

    }

    public String ProtokolAdresi_ilce

    {

        get

        {

            return cProtokolAdresi_ilce;

        }

        set

        {

            cProtokolAdresi_ilce = value;

        }

    }

 

    #endregion

 

    public PaymentPlan()

    {

        InitializeClass();

    }

    public Boolean IsNumeric(String s)

    {

        float f;

 

        return float.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out f);

        //float.TryParse(s, out output);

    }

    private void InitializeClass()

    {

        cIntCode = 0;

        cBaseNo = 0;

        cIntrerestRate = 0;

        cAcikProvizyon = 0;

        cBirthDate = "";

        cCardNo = 0;

        cCustGroup = "";

        cCustName = "";

        cCustScore = 0;

        cDlq_Code_Id = "";

        cGeriOdenecekTutar = 0;

        cHesapOzetiTarihi = "";

        cIlkTaksitTarihi = "";

        cOPType = "";

        cSOT_Date = "";

        cProtokolAdresi = "";

 

        cProtokolEmail = "";

        cProtokolFax = "";

        cPymt_Plan_F = "";

        cStmt_Date = "";

        cTaksitSayisi = 0;

        cToplamBorc = 0;

        cInstallmentAmount = 0;

        cLimit = 0;

        cPrevLimit = 0;

        cKisitYuzdesi = 0;

        cStateIntCode = 0;

        cMaxBakiye = 0;

        cBSDEDate = "";

        cAdinaProtokol = "";

        cUserId = "";

        cDescription = "";

        cIsPPInfoFound = false;

        cBekleyenTaksitAdet = 0;

        cPPSonrasiOdenen = 0;

        cPPTarihi = Convert.ToDateTime("01.01.0001");

        cTaksitTutari = 0;

        cState = -1;

        cToplamTutarYYP = 0;

        cIsPP = false;

        cDaysPast = -1;

        cIsPPAllowed = true;

        cIsYYPAllowed = true;

        cIsException = false;

        cCheckPayment = false;

        cOPFee = 0;

        cClassifying_Grade = "";

        /* alper */

        cIsCustomerFound = false;

        cMaxGGS = 0;

        cDownPayment = false;

        cEdwGecikme = false;

        cFPD_HR = 0;

        cFaizsizBakiye = 0;

        cWarning = "";

        cProtokolAdresi_il = "";

        cProtokolAdresi_ilce = "";

    }

    private void GetFee()

    {

        cOPFee = 0;

        DataTable dt;

        string strSql = "SELECT * FROM Col_T_Int_AppSettings WHERE [Key] = 'Fee'";

        try

        {

            dt = PCL.MsSQL_DBOperations.GetData(strSql, "SqlConn");

            if (dt.Rows.Count > 0)

            {

                cOPFee = PCL.Utility.DBtoMT.ToDecimal(dt.Rows[0]["DecValue"]);

            }

        }

        catch

        {

            cOPFee = 0;

        }

    }

 

    public String m_GetPaymentPlan(Decimal CustId, Decimal GuncelToplamBorc)

    {

        String retVal = "";

        retVal = m_GetPaymentPlanFromEDW(CustId);

        if (retVal == "1")

        {

            retVal = m_GetPaymentPlanFromEDWData(GuncelToplamBorc);

        }

        if (retVal == "1")

        {

            retVal = SayfaKurallari();

        }

 

        if (retVal == "1")

        {

            retVal = m_IsPPAllowed();

        }

        if (retVal == "1" & cIsPPAllowed)

        {

            retVal = m_GGSRange(); //boşta bir fn. direk 1 return

        }

        if (retVal == "1" & cIsPPAllowed)

       {

            retVal = m_IsCustomerAllowed();

        }

        if (retVal == "1" & cIsPPAllowed)

        {

            retVal = m_SifirFaiz();

        }

 

        GetFee();

        SetDerivedFields();

        return retVal;

    }

 

    private void SetDerivedFields()

    {

        cIsPP = (cPymt_Plan_F.Trim() == "Y" || cPymt_Plan_F.Trim() == "H");

 

        if (cIsPP)

        {

            TimeSpan ts = TimeSpan.Zero;

            ts = DateTime.Now.Subtract(cPPTarihi);

            cDaysPast = Convert.ToInt32(ts.Days);

        }

    }

 

    private String m_GetPaymentPlanFromEDWData(Decimal GuncelToplamBorc)

    {

        String retVal = "1";

        cEKB.BaseNo = cBaseNo;

        cEKB.GuncelToplamBorc = GuncelToplamBorc;

        CultureInfo CultureInfoTR = CultureInfo.CreateSpecificCulture("tr-TR");

        cEKB.EKT = Convert.ToDateTime(cStmt_Date.Replace("/", "."), CultureInfoTR);

        cEKB.m_GetPaymentPlanYYP();

        cPPSonrasiOdenen = cEKB.YYSonrasiOdeme;

        cClassifying_Grade = cEKB.Classifying_Grade;

        cIsPPInfoFound = true;

        //EDW Ödenen Tutar

        //cPPSonrasiOdenen = cEKB.;

        //EDW PROCESSDATE

        cPPTarihi = cEKB.PPTarihi;

        //EDW OPODEMEPLANIBAKIYESI/TAKSITSAYISI

        cMevTaksitSayisi = cEKB.TaksitSayisi;

        cToplamTutarYYP = cEKB.Kalan_VF_KKDF_BSMV_YYP;

 

        cState = 2;

        cIsYYPAllowed = cEKB.IsAllowedYYP;

 

        return retVal;

    }

 

 

    public String m_IsIVNAccepted()

    {

        String retVal = "0";

        if (cIsPPAllowed)

        {

            DataTable dt = new DataTable();

 

 

            string strSql = " SELECT /*parallel(4)*/  MUSNO, to_char(ACCEPTED_DATE,'DD/MM/YYYY') ACCEPTED_DATE, VADE, FAIZ_ORANI from A25318.IVN_OP_ACCEPTED "

                            + "     where MUSNO= " + cBaseNo + " and trunc(ACCEPTED_DATE) >= TRUNC(sysdate)-4";

 

            dt = PCL.Oracle_DBOperations.GetData(strSql, "EDWConn", cEDWUserId, cEDWPassword);

 

            string VADE;

            string FAIZ;

            string ZAMAN;

            //string MSG;

            if (dt.Rows.Count > 0)

            {

                VADE = dt.Rows[0]["VADE"].ToString().Trim();

                // FAIZ = dt.Rows[0]["FAIZ_ORANI"].ToString().Trim();

                ZAMAN = dt.Rows[0]["ACCEPTED_DATE"].ToString().Trim();

 

                retVal = "Müşteri " + ZAMAN + " tarihinde " + VADE + " aylık yapılandırmayı kabul etmiştir. Farklı vade seçeneği ile Ödeme Planı sunulması durumunda operasyon birimine bilgi veriniz.";

                cWarning = cWarning + "<br /><br />Farklı vade seçeneği ile Ödeme Planı sunulması durumunda operasyon birimine bilgi veriniz.";

                ////

                //Response.Write("<script language='javascript' type='text/javascript'>");

                //Response.Write("window.clipboardData.setData('Text','" + cPaymentPlan.Description + "');");

                //Response.Write("</script>");

 

 

 

            }

            else

            {

                retVal = "0";

            }

 

            //InterestSelectionChanged('" + theMessage + "');

        }

        return retVal;

    }

 

 

    private String m_IsCustomerAllowed()

    {

        String retVal = "1";

        DataTable dt;

 

 

        string strSql = "EXECUTE Col_SP_GetCustomerConstraintsV2 " + cBaseNo + "";

        try

        {

            dt = PCL.MsSQL_DBOperations.GetData(strSql, "SqlConn");

 

            dt = PCL.MsSQL_DBOperations.GetData(strSql, "SqlConn");

            if (dt.Rows.Count > 0)

            {

                if (cIsPPAllowed)

                {

                    if (PCL.Utility.DBtoMT.ToBoolean(dt.Rows[0]["IsAllowed"]) & cMaxGGS > 30)

                    {

                        cIsPPAllowed = PCL.Utility.DBtoMT.ToBoolean(dt.Rows[0]["IsAllowed"]);

                        cDownPayment = PCL.Utility.DBtoMT.ToBoolean(dt.Rows[0]["DownPayment"]);

                        /*zaten dolmuyor

               

                        cIsException = PCL.Utility.DBtoMT.ToBoolean(dt.Rows[0]["IsException"]);

                         */

                        cDescription = PCL.Utility.DBtoMT.ToString(dt.Rows[0]["ExceptionDesc"]);

                        cWarning = PCL.Utility.DBtoMT.ToString(dt.Rows[0]["Warning"]) + "<br />";

                        cCheckPayment = PCL.Utility.DBtoMT.ToBoolean(dt.Rows[0]["CheckPayment"]);

 

                        cIsCustomerFound = true;

                    }

                }

            }

            /* if (!cIsPPAllowed)

             {

                 cWarning = PCL.Utility.DBtoMT.ToString(dt.Rows[0]["DisallowReason"]);

             }

             else

             { }

             * */

        }

        catch (Exception ex)

        {

            retVal = ex.Message;

        }

 

        return retVal;

    }

    public String TRXMsg(decimal b)

    {

        String retVal = "<hr>";

        DataTable dt;

 

        string strSql = " Select AGG_BY_MONTH,IX,nvl(TRX_AMT_DOM_OD,0) TRX_AMT_DOM_OD, NVL(TRX_AMT_DOM,0) TRX_AMT_DOM  from a25318.kk_yy_limit_trx_AY A left JOIN (select * from  a25318.kk_yy_limit_trx  where  CUST_ID= " + cBaseNo + "  ) B ON TO_NUMBER(TRX_MNTH)=AGG_BY_MONTH        ORDER BY  2";

        string Clue = "<table border=1><tr><th></th><th>TARIH</th><th>NAKDI ODEME</th> <th>ILAVE+ODEME TOPLAMI</th></tr> ";

 

 

 

        try

        {

            dt = PCL.Oracle_DBOperations.GetData(strSql, "EDWConn", cEDWUserId, cEDWPassword);

 

            if (dt.Rows.Count > 0)

            {

                foreach (DataRow dr in dt.Rows)

                {

                    Clue = Clue + "<tr><td>" + PCL.Utility.DBtoMT.ToString(dr["IX"]) + "</td><td>" + PCL.Utility.DBtoMT.ToString(dr["AGG_BY_MONTH"]) + "</td><td>" + PCL.Utility.DBtoMT.ToString(dr["TRX_AMT_DOM_OD"]) + "</td><td>" + PCL.Utility.DBtoMT.ToString(dr["TRX_AMT_DOM"]) + "</td></tr>";

                    retVal = retVal + "" + PCL.Utility.DBtoMT.ToString(dr["AGG_BY_MONTH"]) + " : " + PCL.Utility.DBtoMT.ToString(dr["TRX_AMT_DOM_OD"]) + " |";

                }

                Clue = Clue + "</table>";

                retVal = retVal + "<a class=\"ClueTips\" href=\"#\" onclick=\"InterestSelectionChanged('" + Clue + "')\" title=\"Ödeme Tarihçesi&nbsp;|\"> Ödeme Geçmişi</a>";

 

                // retVal = "<hr>" + cBaseNo.ToString() + " Base Numaralı müşterinin kredi kartına en son " +retVal = "<hr>" + + " tarihinde, " + PCL.Utility.DBtoMT.ToString(dt.Rows[0]["FAIZORAN"]) + " faiz oranıyla yapılandırma IVN sunulmuştur. <a class=\"ClueTips\" href=\"#\" onclick=\"InterestSelectionChanged('" + Clue + "')\" title=\"IVN Çıkış Tarihçesi&nbsp;|\">Tarihçe</a>";

 

 

 

            }

            else

            {

                retVal = "Müşterinin ödemelerine ulaşılamamaktadır.";

 

 

            }

        }

        catch (Exception ex)

        {

            retVal = ex.Message;

        }

 

        return retVal;

 

    }

    public String IVNMsg(decimal b)

    {

        String retVal = "";

        DataTable dt;

 

        string strSql = " SELECT /*parallel(4)*/ TO_CHAR(YUKLEMETRH,'DD/MM/YYYY') AS TARIH,FAIZORAN "

           + " from    A25318.KUMULATIF_IVNODEMEPLANI  "

           + " WHERE CUST_ID =" + cBaseNo + " "

           + " Order by YUKLEMETRH desc ";

 

        string Clue = "<table border=1><tr><th>TARIH</th><th>FAIZ</th></tr> ";

 

 

 

        try

        {

            dt = PCL.Oracle_DBOperations.GetData(strSql, "EDWConn", cEDWUserId, cEDWPassword);

 

            if (dt.Rows.Count > 0)

            {

                foreach (DataRow dr in dt.Rows)

                {

                    Clue = Clue + "<tr><td>" + PCL.Utility.DBtoMT.ToString(dr["TARIH"]) + "</td><td>" + PCL.Utility.DBtoMT.ToString(dr["FAIZORAN"]) + "</td></tr>";

 

                }

                Clue = Clue + "</table>";

 

 

                retVal = "<hr>" + cBaseNo.ToString() + " Base Numaralı müşterinin kredi kartına en son " + PCL.Utility.DBtoMT.ToString(dt.Rows[0]["TARIH"]) + " tarihinde, " + PCL.Utility.DBtoMT.ToString(dt.Rows[0]["FAIZORAN"]) + " faiz oranıyla yapılandırma IVN sunulmuştur. <a class=\"ClueTips\" href=\"#\" onclick=\"InterestSelectionChanged('" + Clue + "')\" title=\"IVN Çıkış Tarihçesi&nbsp;|\">Tarihçe</a>";

 

 

 

            }

            else

            {

                retVal = "<hr>Müşteriye yapılandırma IVN sunulmamış.";

            }

        }

        catch (Exception ex)

        {

            retVal = ex.Message;

        }

 

        return retVal;

 

    }

 

    private String m_SifirFaiz()

    {

        String retVal = "1";

        DataTable dt;

 

        string strSql = " SELECT /*parallel(4)*/  WARNING_CODE_DESC "

                    + "from CLDM.COLLTN_CUST_WARNING  "

                    + "where WARNING_CODE in (21) "

                    + "AND CUST_ID=  " + cBaseNo;

 

 

 

 

        try

        {

            dt = PCL.Oracle_DBOperations.GetData(strSql, "EDWConn", cEDWUserId, cEDWPassword);

 

            if (dt.Rows.Count > 0)

            {

                if (cIsPPAllowed)

               {

                    cWarning = PCL.Utility.DBtoMT.ToString(dt.Rows[0]["WARNING_CODE_DESC"]) + "<br />";

 

                    /* if (PCL.Utility.DBtoMT.ToBoolean(dt.Rows[0]["IsAllowed"]) & cMaxGGS > 30)

                     {

                         cIsPPAllowed = PCL.Utility.DBtoMT.ToBoolean(dt.Rows[0]["IsAllowed"]);

                         cDownPayment = PCL.Utility.DBtoMT.ToBoolean(dt.Rows[0]["DownPayment"]);

                         cDescription = PCL.Utility.DBtoMT.ToString(dt.Rows[0]["ExceptionDesc"]);

                         cWarning = PCL.Utility.DBtoMT.ToString(dt.Rows[0]["Warning"]) + "<br />";

                         cCheckPayment = PCL.Utility.DBtoMT.ToBoolean(dt.Rows[0]["CheckPayment"]);

 

                         cIsCustomerFound = true;

                     }

                     */

 

                    if (cPPCount == 1)

                        cWarning += "<input type=\"hidden\" id=\"DefaultFaiz\" class=\"DefaultFaiz\" value=\"0.00\">";

                    //cDefaultFaiz = PCL.Utility.UItoMT.ToDecimal("2.02");

                }

            }

            else

            {

 

 

                // tabloda geçmiyor 60

                if (cMaxGGS <= cStartDLQ && !cIsBusiness && !cIsSpecial)

                {

                    cIsPPAllowed = false;

                    cWarning = "GGS " + cStartDLQ.ToString() + " gün ve üzerine ödeme planı yapılabilir.";

 

                }

                else

                {

                    if (cPPCount == 1)

                        cWarning += "<input type=\"hidden\" id=\"DefaultFaiz\" class=\"DefaultFaiz\" value=\"" + cDefaultFaiz.ToString() + "\">";

 

                }

            }

        }

        catch (Exception ex)

        {

            retVal = ex.Message;

        }

 

 

        return retVal;

    }

 

 

    private void OzelMi()

    {

        cIsSpecial = false;

 

        try

        {

            DataTable dt;

            //string strSql = "select isnull(count(*),0) as Adet from KKBSITE_CUSTOMERS where CUST_ID=" + cBaseNo;

            string strSql = "select CASE WHEN nvl(count(*),0)>0 THEN 1 ELSE 0 END  as ADET from A38427.AG_YILDIZ_DATA_DAILY where CUST_ID=" + cBaseNo;

 

           dt = PCL.Oracle_DBOperations.GetData(strSql, "EDWConn", cEDWUserId, cEDWPassword);

            // dt = PCL.MsSQL_DBOperations.GetData(strSql, "SqlConn");

            if (dt.Rows.Count > 0)

            {

                cIsSpecial = PCL.Utility.DBtoMT.ToBoolean(dt.Rows[0]["ADET"]);

            }

        }

        catch (Exception ex)

        {

            cIsSpecial = false;

        }

    }

 

 

    private void CaymaKurali()

    {

        cIsBACKDOWN = false;

        try

        {

            DataTable dt;

            //string strSql = "select isnull(count(*),0) as Adet from KKBSITE_CUSTOMERS where CUST_ID=" + cBaseNo;

            string strSql = "select NVL(max(BACKDOWN_ST),0) BACKDOWN_ST  from CLDM.STRTGY_PD_INFO where CUST_ID=" + cBaseNo;

 

            dt = PCL.Oracle_DBOperations.GetData(strSql, "EDWConn", cEDWUserId, cEDWPassword);

            // dt = PCL.MsSQL_DBOperations.GetData(strSql, "SqlConn");

            if (dt.Rows.Count > 0)

            {

                cIsBACKDOWN = PCL.Utility.DBtoMT.ToBoolean(dt.Rows[0][0]);

            }

        }

        catch (Exception ex)

        {

            cIsBACKDOWN = false;

        }

    }

    private string SayfaKurallari()

    {

 

 

        String retVal = "1";

 

        DataTable dt;

        //  select StartDLQ,EndDLQ,CDA,VEFAT,IKINCILER, Warning from  Col_T_Def_DLQRangeConstraints where IsActive=1

        string strSql = "exec COL_SP_SAYFAKURALLARI";

        dt = PCL.MsSQL_DBOperations.GetData(strSql, "SqlConn");

        if (dt.Rows.Count > 0)

        {

 

            cStartDLQ = PCL.Utility.UItoMT.ToInt16(dt.Rows[0]["StartDLQ"].ToString().Trim());

            cEndDLQ = PCL.Utility.UItoMT.ToInt16(dt.Rows[0]["EndDLQ"].ToString().Trim());

            cCDAACIK = PCL.Utility.UItoMT.ToBoolean(dt.Rows[0]["CDA"].ToString());

            cVEFATACIK = PCL.Utility.UItoMT.ToBoolean(dt.Rows[0]["VEFAT"].ToString());

            cIKINCILER = PCL.Utility.UItoMT.ToBoolean(dt.Rows[0]["IKINCILER"].ToString());

            cBIRTAKSITODEME = PCL.Utility.UItoMT.ToBoolean(dt.Rows[0]["BIRTAKSITODEME"].ToString());

            cPESINATISTE = PCL.Utility.UItoMT.ToBoolean(dt.Rows[0]["PESINATISTE"].ToString());

            cUCUNCULER = PCL.Utility.UItoMT.ToBoolean(dt.Rows[0]["UCUNCULER"].ToString());

 

            cBV_YYP_ALLOWED = PCL.Utility.UItoMT.ToBoolean(dt.Rows[0]["BV_YYP_ALLOWED"].ToString());

            cYY_KATSAYI = PCL.Utility.UItoMT.ToInt16(dt.Rows[0]["YY_KATSAYI"].ToString().Trim());

 

        }

        return retVal;

    }

 

    private String m_GGSRange()

    {

        String retVal = "1";

 

        //DataTable dt;

 

        //string strSql = "select StartDLQ,EndDLQ, Warning from  Col_T_Def_DLQRangeConstraints where IsActive=1";

        //dt = PCL.MsSQL_DBOperations.GetData(strSql, "SqlConn");

        //if (dt.Rows.Count > 0)

        //{

        //    // msg = PCL.Utility.DBtoMT.ToString(dt.Rows[0]["Warning"]);

        //    cStartDLQ = PCL.Utility.UItoMT.ToInt16(dt.Rows[0]["StartDLQ"].ToString().Trim());

        //    cEndDLQ = PCL.Utility.UItoMT.ToInt16(dt.Rows[0]["EndDLQ"].ToString().Trim());

        //}

        /*  if (cPymt_Plan_F.Trim() == "Y" || cPymt_Plan_F.Trim() == "H")

   {

       if (cMaxGGS >= 50)

       {

 

           cWarning = cWarning + "<br />Kural gereği 0 Faiz seçeneğiyle 18 Ay'a kadar vade için uygundur.";

       }

   }

   else

   {

       if (cMaxGGS >= cStartDLQ && cMaxGGS <= cEndDLQ)

       {

           cWarning = cWarning + "<br />Kural gereği 2.02 Faiz seçeneğiyle işlem yapılabilir.";

       }

       else if (cMaxGGS > cEndDLQ)

       {

           cWarning = cWarning + "<br />Kural gereği 0 Faiz seçeneğiyle 18 Ay'a kadar vade için uygundur.";

 

       }

   }

 

*/

 

 

        /*

         * 27/02/2014 kaldırıldı

        Boolean Grupkisit = false;

        string[] strArray = new string[] { "257", "258", "259", "291", "293", "295", "292", "294", "296", "359", "360", "361", "383", "384", "385" };

*/

 

        Boolean PPVar;

        if (cPymt_Plan_F.Trim() == "Y" || cPymt_Plan_F.Trim() == "H")

        {

            PPVar = true;

        }

        else

        {

            PPVar = false;

        }

 

 

 

        //if (PPVar & cIsPPAllowed & IKINCILER)

        //{

 

        CaymaKurali();

        OzelMi();

 

        //zaten başka yerde geçiyor.

 

        //if (cBIRTAKSITODEME & cIsPPAllowed)

        //{

 

        //    if (!cIsYYPAllowed)

        //    {

        //        cIsPPAllowed = false;

        //        cWarning = "Bir taksit tutarı kadar ödeme olmadığı için YYP kriterlerine uygun değildir. <br />";

        //    }

        //}

 

 

        if (PPVar && cIsPPAllowed && cPPCount > 2 && cMaxGGS < 50)

        {

            cWarning = "Kural gereği GGS 50 altına 3'üncü ve 4'üncü yapılandırma yapılamaz.";

            cIsPPAllowed = false;

        }

        //       

        if (PPVar && cIsPPAllowed && IsBACKDOWN)

        {

            cWarning = "Cayma kuralı işlenen ürününden dolayı yapılandırma yapılamaz.";

            cIsPPAllowed = false;

        }

        //

        if (PPVar & cIsPPAllowed & IKINCILER)

        {

            if (IsBusiness && !cBV_YYP_ALLOWED)

            {

 

                cWarning = "BV Kartlara 2'nci Yapılandırma Yapılamaz.";

                cIsPPAllowed = false;

            }

            else

            {

 

 

                //değişiklikler burda 02/10/2014

 

 

 

 

 

 

                //08/10/2014 çoklu faiz oranı değişikliği çalışması

                //    cWarning = cWarning + "<br />Kural gereği 1.5 Faiz seçeneğiyle işlem yapılabilir.";

            }

        }

        //else if (PPVar & cIsPPAllowed & !IKINCILER)

        //{

        //    if (cIsSpecial)

        //    {

        //        cWarning = cWarning + "<br />AG YILDIZ müşterisine 2'nci yapılandırma yapılmaktadır. <br />Kural gereği 1.5 Faiz seçeneğiyle işlem yapılabilir. ";

        //    }

        //    else

        //    {

        //        cWarning = "2'nci Yapılandırma Yapılamaz.";

        //        cIsPPAllowed = false;

        //    }

        //}

        //else if (PPVar & cIsPPAllowed & !IKINCILER & cIsSpecial)

        //{

        //    cWarning = cWarning + "<br />AG YILDIZ müşterisine 2'nci yapılandırma yapılmaktadır. Kural gereği 1.5 Faiz seçeneğiyle işlem yapılabilir. ";

 

        //    cIsPPAllowed = true;

        //}

        else if (!PPVar & cIsPPAllowed)

        {

            cWarning = cWarning + "<br />Kural gereği 2.02 Faiz seçeneğiyle işlem yapılabilir.";

        }

        //}

        //else {

 

        //    cWarning =  "Ilk yapılandırmalara izin verilmektedir..";

        //    retVal = "1";

        //    cIsPPAllowed = false;

        //}

 

        /*

              if (PPVar & cIsPPAllowed)

             {

                 if (cMaxGGS < 50)

                 {

                     foreach (string str in strArray)

                     {

                         if (cCustGroup.Substring(0, 3) == str)

                         {

                             Grupkisit = true;

                         }

                     }

 

                     if (Grupkisit)

                     {

                         cWarning = "GGS 50 altında olan müşteriye 3. Ödeme planı sunulamaz.";

                         cIsPPAllowed = false;

                     }

                     if (!Grupkisit)

                     {

                         cWarning = cWarning + "<br />Kural gereği 1.5 Faiz seçeneğiyle işlem yapılabilir.";

                     }

 

                 }

                 else

                 {

                     cWarning = cWarning + "<br />Kural gereği 1.5 Faiz seçeneğiyle işlem yapılabilir.";

                 }

 

 

             }

             else if (!PPVar & cIsPPAllowed)

             {

                 cWarning = cWarning + "<br />Kural gereği 2.02 Faiz seçeneğiyle işlem yapılabilir.";

             }

            */

 

 

        return retVal;

    }

 

 

 

    public string GetLast(string source, int tail_length)

    {

        if (tail_length >= source.Length)

            return source;

        return source.Substring(source.Length - tail_length);

    }

 

    private String m_IsPPAllowed()

    {

        String retVal = "1";

        DataTable dt;

 

        string strSql = "EXECUTE Col_SP_GetCustomerGroupConstraints '" + cCustGroup.Substring(0, 3) + "'";

       try

        {

            dt = PCL.MsSQL_DBOperations.GetData(strSql, "SqlConn");

            if (dt.Rows.Count > 0 && cPymt_Plan_F != "2")

            {

                cIsPPAllowed = PCL.Utility.DBtoMT.ToBoolean(dt.Rows[0]["IsAllowed"]);

                cIsException = PCL.Utility.DBtoMT.ToBoolean(dt.Rows[0]["IsException"]);

                cDescription = PCL.Utility.DBtoMT.ToString(dt.Rows[0]["ExceptionDesc"]);

                cWarning = PCL.Utility.DBtoMT.ToString(dt.Rows[0]["Warning"]);

                cCheckPayment = PCL.Utility.DBtoMT.ToBoolean(dt.Rows[0]["CheckPayment"]);

                //cEKB.IsBV  = PCL.Utility.DBtoMT.ToBoolean(dt.Rows[0]["IsBusiness"]);

                cIsBusiness = PCL.Utility.DBtoMT.ToBoolean(dt.Rows[0]["IsBusiness"]);

 

 

                cPPCount = PCL.Utility.DBtoMT.ToInt16(dt.Rows[0]["PPCount"]);

                //cDefaultFaiz = PCL.Utility.DBtoMT.ToDecimal(dt.Rows[0]["InterestRate"]);

 

 

            }

            if (!cIsPPAllowed)

            {

                cWarning = PCL.Utility.DBtoMT.ToString(dt.Rows[0]["DisallowReason"]);

            }

            else

            {

                int katsayi = 1;

                if (cPPCount > cYY_KATSAYI)

                    katsayi = cPPCount - 1;

 

 

 

               if (cCheckPayment && (cPPSonrasiOdenen < (cEKB.OPToplamTaksitTutari * katsayi)))

                {

                    cIsPPAllowed = false;

                    cWarning = PCL.Utility.DBtoMT.ToString(dt.Rows[0]["DisallowReason"]);

                }

                else

                {

                    //else den devam edecek

 

                    Boolean PPVar;

                    if (cPymt_Plan_F.Trim() == "Y" || cPymt_Plan_F.Trim() == "H")

                    {

                        PPVar = true;

                    }

                    else

                    {

                        PPVar = false;

                    }

 

 

 

                    if ((string.IsNullOrEmpty(cPPCount.ToString()) || cPPCount == 0) && PPVar)

                    {

                        //ikinci yapılandırma yapılacak

 

                        cPPCount = 2;

                    } if ((string.IsNullOrEmpty(cPPCount.ToString()) || cPPCount == 0) && !PPVar)

                    {

                        //ilk yapılandırma yapılacak

 

                        cPPCount = 1;

 

                        cDefaultFaiz = PCL.Utility.UItoMT.ToDecimal("2.02");

                    }

                    //// ikinci yapılandırmanın default faiz oranı belirlenir

                    //if (PPVar && PPCount == 2 && cBaseNo.ToString().Substring(0,1) == "6")//1 temsili

                    //{

                    //    cDefaultFaiz = PCL.Utility.UItoMT.ToDecimal("0.99"); cWarning += "<br />Kural gereği " + cDefaultFaiz.ToString() + " Faiz seçeneğiyle işlem yapılabilir.";

 

                    //}

                    //if (PPVar && PPCount == 2 && cBaseNo.ToString().Substring(0,1) != "6")

                    //{

                    //    cDefaultFaiz = PCL.Utility.UItoMT.ToDecimal("1.9"); cWarning += "<br />Kural gereği " + cDefaultFaiz.ToString() + " Faiz seçeneğiyle işlem yapılabilir.";

                    //}

                    //// üçüncü yapılandırmanın default faiz oranı belirlenir

                    //if (PPVar && PPCount == 3 && cBaseNo.ToString().Substring(0,1) == "5")

                    //{

                    //    cDefaultFaiz = PCL.Utility.UItoMT.ToDecimal("1.5"); cWarning += "<br />Kural gereği " + cDefaultFaiz.ToString() + " Faiz seçeneğiyle işlem yapılabilir.";

                    //} if (PPVar && PPCount == 3 && cBaseNo.ToString().Substring(0,1) != "5")

                    //{

                    //    cDefaultFaiz = PCL.Utility.UItoMT.ToDecimal("1.8"); cWarning += "<br />Kural gereği " + cDefaultFaiz.ToString() + " Faiz seçeneğiyle işlem yapılabilir.";

                    //}

 

                    //// dördüncü yapılandırmanın default faiz oranı belirlenir

                    //if (PPVar && PPCount == 4)

                    //{

                    //    cDefaultFaiz = PCL.Utility.UItoMT.ToDecimal("1.8"); cWarning += "<br />Kural gereği " + cDefaultFaiz.ToString() + " Faiz seçeneğiyle işlem yapılabilir.";

                    //}

 

 

 

                    // ikinci yapılandırmanın default faiz oranı belirlenir

                    if (PPVar && PPCount == 2)

                    {

                        cDefaultFaiz = PCL.Utility.UItoMT.ToDecimal("1.5"); cWarning += "<br />Kural gereği " + cDefaultFaiz.ToString() + " Faiz seçeneğiyle işlem yapılabilir.";

 

                    }

 

 

                    // üçüncü yapılandırmanın default faiz oranı belirlenir

                    if (PPVar && PPCount == 3)

                    {

                        cDefaultFaiz = PCL.Utility.UItoMT.ToDecimal("1.4"); cWarning += "<br />Kural gereği " + cDefaultFaiz.ToString() + " Faiz seçeneğiyle işlem yapılabilir.";

                    }

 

 

                    // dördüncü yapılandırmanın default faiz oranı belirlenir

                    if (PPVar && PPCount == 4)

                    {

                        cDefaultFaiz = PCL.Utility.UItoMT.ToDecimal("1.4"); cWarning += "<br />Kural gereği " + cDefaultFaiz.ToString() + " Faiz seçeneğiyle işlem yapılabilir.";

                    }

 

 

 

                }

            }

        }

        catch (Exception ex)

        {

            retVal = ex.Message;

        }

 

        finally

        {

 

        }

 

 

        // cWarning += "";

 

 

        if (!cVEFATACIK & cIsPPAllowed)

        {

            if (cFLW_ST == "V")

            {

                cIsPPAllowed = false;

                cWarning = "Takip Statüsü VEFAT olan müşterilere Ödeme Planı Simülasyonu oluşturulamaz. <br />";

            }

        }

 

        //ilk önce yyp yapılacaksa checkpayment yapıyor sonra buraya uğruyor

        // taşındı burdan başka yere

        if (cBIRTAKSITODEME & cIsPPAllowed)

        {

 

            if (!cIsYYPAllowed)

            {

                cIsPPAllowed = false;

                cWarning = "Bir taksit tutarı kadar ödeme olmadığı için YYP kriterlerine uygun değildir. <br />";

            }

        }

 

 

        if (cClassifying_Grade.Trim() == "3" || cClassifying_Grade.Trim() == "4" || cClassifying_Grade.Trim() == "5" && cIsPPAllowed)

        {

            cIsPPAllowed = false;

            cWarning = "Sınıflama notu nedeniyle yapılandırma kriterlerine uygun değildir (Sınıflama Notu = " + cClassifying_Grade.Trim() + "). <br />";

        }

 

 

        // found = true ise YYP yapılıyor

 

        /*

        if (cMaxGGS == 90 && !cEKB.PPIsFound && cIsPPAllowed)

        {

            cIsPPAllowed = true;

                    cWarning += "DİKKAT!!! GGS 90 olan müşterinin hesap özeti <u>bugüne</u> çalıştırılmalıdır. <br />";

        }

        if (cMaxGGS > 90 && !cEKB.PPIsFound)

        {

            cIsPPAllowed = false;

                       cWarning += "GGS 90 günün üstünde olan müşteriye Ödeme Planı yapılamamaktadır. <br />";

        }

        if (cMaxGGS > 89 && cEKB.PPIsFound)

        {

            cIsPPAllowed = false;

                   cWarning += "GGS 89 üstünde olan müşteriye Yeniden Yapılandırma yapılmamaktadır. <br />";

        }

 

        if (cMaxGGS == 89 && cEKB.PPIsFound && cIsPPAllowed)

        {

           cIsPPAllowed = true;

            cWarning += "DİKKAT!!! GGS 89 olan müşterinin hesap özeti <u>bugüne</u> çalıştırılmalıdır. <br />";

        }

   

         */

 

        if (cFaizsizBakiye < 150 & !cIsCustomerFound & cIsPPAllowed)

        {

            cWarning = "Müşterinin faizsiz toplam bakiyesi 150 TL altında olduğundan Ödeme Planı yapılamaz";

            cIsPPAllowed = false;

        }

        /*   if (cFPD_HR == 1)

           {

               cWarning = "Yüksek riskli yeni müşteri olduğundan Ödeme Planı yapılamaz";

               cIsPPAllowed = false;

       }

         */

        VadeSil = false;

        if (cEKB.GuncelToplamBorc >= 150 && cEKB.GuncelToplamBorc < 301 & !cIsCustomerFound & cIsPPAllowed)

        {

            cWarning += "<p>En fazla 6 aya kadar taksitlendirme yapılabilir</p>";

 

            cIsException = true;

            VadeSil = true;

            //  cWarning += "<script language='javascript' type='text/javascript'> vadeSil(); </script>";

        }

 

        //cPPCount = 1;

        // TaksitSys

 

 

 

        /* ÇDA DEĞİŞİKLİKLERİ HEP BURDAN */

        if (!cCDAACIK & cIsPPAllowed)

        {

            if (cCDA_ST != "N" & !cIsCustomerFound)

            {

                if (cPOTANSIYEL_F == "0")

                {

                    cIsPPAllowed = false;

                    cWarning = "ÇDA statüsünden dolayı Ödeme Planı yapılamaz.";

                }

                else

                {

                    cWarning += "DİKKAT! ÇDA statüsündeki potansiyel müşterisi.";

                }

            }

        }

 

        if (cCardNo.ToString().Substring(0, 4) == "4030" || cCardNo.ToString().Substring(0, 4) == "4273" || cCardNo.ToString().Substring(0, 4) == "5475" || cCardNo.ToString().Substring(0, 4) == "5478")

        {

            if (!cIsBusiness)

            {

                cIsPPAllowed = false;

                cWarning = "Müsteri Grubu - Kart Prefix Uyuşmazlığı. Lütfen Operasyon birimine bilgi veriniz.<br />";

            }

 

        }

 

 

        return retVal;

    }

 

 

    private void InitEDWUser()

    {

        DataTable dt = PCL.MsSQL_DBOperations.GetData("SELECT * FROM [SSIS Configurations] WHERE ConfigurationFilter = 'EDWConn'", "SqlConn");

        if (dt.Rows.Count > 0)

        {

            foreach (DataRow dr in dt.Rows)

            {

                string PackagePath = PCL.Utility.DBtoMT.ToString(dr["PackagePath"]);

                string ConfiguredValue = PCL.Utility.DBtoMT.ToString(dr["ConfiguredValue"]);

                if (PackagePath == "UserId") { cEDWUserId = ConfiguredValue; }

                if (PackagePath == "Password") { cEDWPassword = ConfiguredValue; }

            }

        }

    }

 

    public String m_GetPaymentPlanFromEDW(Decimal CustId)

    {

        DataTable dt = new DataTable();

        String retVal = "1";

 

        InitEDWUser();

        string strSql = " SELECT /*parallel(4)*/ TRUNC(SYSDATE-1)-F.AS_OF_DT GECIKME, "

                        + "         (TRUNC(SYSDATE-1)-F.AS_OF_DT)+c.DLQ_DAY_CNT GC_GGS ,"

                        + "         A.CUST_ID BASENO,C.CARD_NO KARTNO,"

                        + "         C.DLQ_DAY_CNT MAXGGS , "

                        + "         E.LAST_STMT_TOT_BLNC_DOM MAXBAKIYE ,"

                        + "         C.DLQ_CODE_ID  MAXEKSTRESTATU_MAX ,  "

                        + "         D.FULL_NM ADSOYAD, "

                        + "         A.LIMIT, A.PREV_LIMIT, "

                        + "         A.CUST_GRP MUSTERIGRUBU, "

                        + "         FI_SCORE SKOR,A.FLW_ST, "

                        + "         TO_CHAR(D.BIRTH_DT,'YYYYMMDD') DOGUMTARIHI, "

                        + "         TO_CHAR(E.LAST_STMT_DT,'yyyymmdd') EKT,  "

                        + "         TO_CHAR(E.LAST_PYMNT_DT,'yyyymmdd') SOT, "

                        + "         CASE  WHEN A.PYMT_PLAN_F='1' THEN 'Y' ELSE A.PYMT_PLAN_F END  ODEMEPLANIFLAG ,"

                        + "         CASE WHEN FI_SCORE IN (13, 15) OR trunc(APPL_DT ,'YEAR' ) =trunc(sysdate, 'YEAR')   THEN 1 ELSE 0 END AS YUKSEK_RISKLI_YENI_MUSTERI, "

                        + "         CASE WHEN SUBSTR(A.CUST_GRP, 1, 3) IN ('271', '272', '273', '274', '275', '276','262', '266', '267', '268', '269', '270','279', '280', '281', '282', '283', '284') THEN 0.25  "

                        + "               WHEN SUBSTR(A.CUST_GRP, 1, 3) IN ('261', '277', '263', '264', '265', '278') THEN 0.5  "

                        + "               WHEN SUBSTR(A.CUST_GRP, 1, 3) IN ('329','330','331','340','341','342') THEN 0.5  "

                        + "               WHEN SUBSTR(A.CUST_GRP, 1, 3) IN ('326','327','328','332','333','334','319','320','321','322','323','324','353','354','355','391','390','392') THEN 0  "

                        + "                  ELSE 1 END AS   KISIT_YUZDESI,"

                        + "         SUM(F.BAL_TOT) FAIZSIZ_BKY,A.CDA_ST, case when C.DLQ_DAY_CNT >= 90-to_number(LAST_DAY(sysdate)-sysdate) then 1 else 0 end POTANSIYEL_F "

                        + "    FROM CDM.CC_CUST A,   CDM.CC_DAILY C , EDW.CUST D , CDM.CC_CUST_STMT E , CDM.CC_CARD_ENR F /*,(SELECT CUST_ID FROM CLDM.COLLTN_CUST_WARNING WHERE WARNING_CODE = 21) W*/ "

                        + "   WHERE A.CUST_ID=C.CUST_ID(+)"

                        + "     /*AND A.DLQ_DAY_CNT=C.DLQ_DAY_CNT(+) 30032015 gecikmeli kart girmiyor diye*/"

                        + "     AND A.CUST_ID =D.CUST_ID(+)"

                        + "     AND A.CUST_ID =E.CUST_ID(+)"

                        + "     AND C.CARD_NO=E.CARD_NO "

                        + "     AND A.CUST_ID =f.CUST_ID(+) "

                        + "     /*AND A.CUST_ID =W.CUST_ID(+)*/ "

                        + "     AND (F.AS_OF_DT=TRUNC(SYSDATE-1) or  F.AS_OF_DT=TRUNC(SYSDATE-2) )"

                        + "     AND A.CUST_ID =" + CustId + " "

                        + " GROUP BY TRUNC(SYSDATE-1)-F.AS_OF_DT,"

                        + "         (TRUNC(SYSDATE-1)-F.AS_OF_DT)+C.DLQ_DAY_CNT , "

                        + "         A.CUST_ID ,"

                        + "         C.CARD_NO ,"

                        + "         C.DLQ_DAY_CNT  , "

                        + "         E.LAST_STMT_TOT_BLNC_DOM  ,"

                        + "         C.DLQ_CODE_ID   ,  "

                        + "         D.FULL_NM , "

                        + "         A.LIMIT,A.PREV_LIMIT,  "

                        + "         A.CUST_GRP , "

                        + "         FI_SCORE ,A.FLW_ST, "

                        + "         TO_CHAR(D.BIRTH_DT,'YYYYMMDD') , "

                        + "         TO_CHAR(E.LAST_STMT_DT,'yyyymmdd') ,  "

                        + "         TO_CHAR(E.LAST_PYMNT_DT,'yyyymmdd') , "

                        + "         CASE  WHEN A.PYMT_PLAN_F='1' THEN 'Y' ELSE A.PYMT_PLAN_F END   ,"

                        + "         CASE WHEN FI_SCORE IN (13, 15) OR trunc(APPL_DT ,'YEAR' ) =trunc(sysdate, 'YEAR')   THEN 1 ELSE 0 END, "

                        + "         CASE WHEN SUBSTR(A.CUST_GRP, 1, 3) IN ('271', '272', '273', '274', '275', '276') THEN 0  WHEN SUBSTR(A.CUST_GRP, 1, 3) IN ('262', '266', '267', '268', '269', '270') THEN 0.1  WHEN SUBSTR(A.CUST_GRP, 1, 3) IN ('279', '280', '281', '282', '283', '284') THEN 0.2  WHEN SUBSTR(A.CUST_GRP, 1, 3) IN ('261', '277', '263', '264', '265', '278') THEN 0.5  ELSE 1 END,A.CDA_ST  "

                        + "ORDER BY GECIKME aSC,MAXGGS desc  ";

 

        dt = PCL.Oracle_DBOperations.GetData(strSql, "EDWConn", cEDWUserId, cEDWPassword);

 

 

        if (dt.Rows.Count > 0)

        {

            //Set class properties

            cBaseNo = PCL.Utility.UItoMT.ToDecimal(dt.Rows[0]["BASENO"].ToString().Trim());

            cCardNo = PCL.Utility.UItoMT.ToDecimal(dt.Rows[0]["KARTNO"].ToString().Trim());

            cDlq_Code_Id = dt.Rows[0]["MAXEKSTRESTATU_MAX"].ToString().Trim();

            cMaxBakiye = PCL.Utility.UItoMT.ToDecimal(dt.Rows[0]["MAXBAKIYE"].ToString().Trim());

            cCustName = dt.Rows[0]["ADSOYAD"].ToString().Trim();

            cLimit = PCL.Utility.UItoMT.ToDecimal(dt.Rows[0]["LIMIT"].ToString().Trim());

            cPrevLimit = PCL.Utility.UItoMT.ToDecimal(dt.Rows[0]["PREV_LIMIT"].ToString().Trim());

            cCustGroup = dt.Rows[0]["MUSTERIGRUBU"].ToString().Trim();

            cCustScore = PCL.Utility.UItoMT.ToInt16(dt.Rows[0]["SKOR"].ToString().Trim());

            cBirthDate = dt.Rows[0]["DOGUMTARIHI"].ToString().Trim();

            cStmt_Date = dt.Rows[0]["EKT"].ToString().Trim().Substring(6, 2) + "/" + dt.Rows[0]["EKT"].ToString().Trim().Substring(4, 2) + "/" + dt.Rows[0]["EKT"].ToString().Trim().Substring(0, 4);

            cSOT_Date = dt.Rows[0]["SOT"].ToString().Trim().Substring(6, 2) + "/" + dt.Rows[0]["SOT"].ToString().Trim().Substring(4, 2) + "/" + dt.Rows[0]["SOT"].ToString().Trim().Substring(0, 4);

            cPymt_Plan_F = dt.Rows[0]["ODEMEPLANIFLAG"].ToString().Trim();

            cKisitYuzdesi = PCL.Utility.UItoMT.ToDecimal(dt.Rows[0]["KISIT_YUZDESI"].ToString().Trim());

            // cFaizOrani = PCL.Utility.UItoMT.ToDecimal(dt.Rows[0]["FAIZORAN"].ToString().Trim());

            cMaxGGS = PCL.Utility.UItoMT.ToInt16(dt.Rows[0]["MAXGGS"].ToString().Trim());

            cFPD_HR = PCL.Utility.UItoMT.ToInt16(dt.Rows[0]["YUKSEK_RISKLI_YENI_MUSTERI"].ToString().Trim());

            cFaizsizBakiye = PCL.Utility.UItoMT.ToDecimal(dt.Rows[0]["FAIZSIZ_BKY"].ToString().Trim());

            cCDA_ST = dt.Rows[0]["CDA_ST"].ToString().Trim();

            cFLW_ST = dt.Rows[0]["FLW_ST"].ToString().Trim();

            cPOTANSIYEL_F = dt.Rows[0]["POTANSIYEL_F"].ToString().Trim();

            if (PCL.Utility.UItoMT.ToInt16(dt.Rows[0]["GECIKME"].ToString().Trim()) > 0)

            {

 

                cEdwGecikme = true;

                cMaxGGS = PCL.Utility.UItoMT.ToInt16(dt.Rows[0]["GC_GGS"].ToString().Trim());

            }

        }

        else

        {

            retVal = "0";

        }

        return retVal;

    }

 

 

    public String m_ProcessPaymentPlan(Char CmdType, Decimal CardNo, Decimal CustId, String CustGrp, String Pymt_Flag, Decimal CustScore, String BirthDate, String StmtDate, String Dlq_Code_Id, String NameSurname, Decimal Limit, Decimal Kisit, Decimal AcikProvizyon, Decimal FaizOrani, Decimal ToplamBorc, Decimal GeriOdemeTutari, Int16 TaksitSayisi, String HesapOzetiTarihi, String ProtokolAdresi, String IlkTaksitTarihi, String OPType, Decimal InstallmentAmount, String UserId, Boolean ExceptionFlag, String Description, String SOT_Date, String ProtokolEmail, String ProtokolFax, Boolean IslemUcreti, Boolean IsYYP, Int16 GGS, Boolean KismiOdemeFlag, String ilbilgisi, String ilcebilgisi, Boolean ISBV, Boolean AdreseIstemez)

    {

        long ReturnValue = 0;

        String strRetVal = "";

 

        string strSql = "EXEC Col_SP_ProcessPP_Ver2 '" + CmdType.ToString() + "'," + CardNo.ToString() + "," + CustId.ToString() + ",'" + CustGrp + "','" + Pymt_Flag + "'," + CustScore.ToString() + ",'" + BirthDate.ToString() + "','" + StmtDate.ToString() + "','" + Dlq_Code_Id + "','" + NameSurname + "'," + Limit.ToString() + ",'" + Kisit.ToString() + "'," + AcikProvizyon.ToString() + "," + FaizOrani.ToString() + "," + ToplamBorc.ToString() + "," + GeriOdemeTutari.ToString() + "," + TaksitSayisi.ToString() + ",'" + HesapOzetiTarihi.ToString() + "','" + ProtokolAdresi + "','" + IlkTaksitTarihi.ToString() + "','" + OPType + "'," + InstallmentAmount.ToString() + ",'" + UserId + "'," + ExceptionFlag.ToString() + ",'" + Description + "','" + SOT_Date + "','" + ProtokolEmail + "','" + ProtokolFax + "'," + IslemUcreti.ToString() + "," + IsYYP.ToString() + "," + GGS.ToString() + "," + KismiOdemeFlag.ToString() + ",'" + ilbilgisi + "','" + ilcebilgisi + "'," + ISBV.ToString() + "," + AdreseIstemez.ToString();

 

        try

        {

            ReturnValue = PCL.MsSQL_DBOperations.ExecuteScalarSQLStr(strSql, "SqlConn");

            strRetVal = ReturnValue.ToString();

        }

        catch (Exception ex)

        {

            strRetVal = " The process failed. Error = " + ex.Message;

        }

 

        return strRetVal;

    }

 

    public DataTable m_GetYYAmounts(String MusteriNo)

    {

        DataTable dt = new DataTable();

        string strSql = "SELECT  * "

                    + " FROM OdemePlaniTemmuz_V3 WHERE MusteriNo = '" + MusteriNo + "'";

 

        dt = PCL.MsSQL_DBOperations.GetData(strSql, "SqlConn");

 

        return dt;

    }

 

    public DataTable m_MGLimit()

    {

        string visitorIPAddress = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

        if (String.IsNullOrEmpty(visitorIPAddress))

            visitorIPAddress = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];

        if (string.IsNullOrEmpty(visitorIPAddress))

            visitorIPAddress = HttpContext.Current.Request.UserHostAddress;

 

 

 

        Int16 OPF;

        if (cPymt_Plan_F.Trim() == "Y" || cPymt_Plan_F.Trim() == "H")

        {

            OPF = 1;

        }

        else

        {

            OPF = 0;

        }

        DataTable dt = new DataTable();

        string strSql = "exec  dbo.Col_SP_MGLimit '" + cCustGroup.Trim() + "'/*MG*/,'" + cLimit + "' /*LIMIT*/,'" + cCustScore + "' /*SCORE*/,'" + OPF + "'/*OPFLAG*/,'" + cBaseNo + "'/*BASENO*/,'" + HttpContext.Current.User.Identity.Name.ToUpper().Replace("İ", "I").ToString() + "'/*USER*/,'" + cEKB.GuncelToplamBorc + "'/* ekrana yazılan tutar*/,'" + visitorIPAddress + "','" + cToplamTutarYYP + "',/*YYPANAPARA*/'" + cWarning.Replace("'", " ") + "'/*WARNTEXT*/";

 

 

        dt = PCL.MsSQL_DBOperations.GetData(strSql, "SqlConn");

 

        return dt;

    }

 

    public DataTable m_SearchPaymentPlans(string strSql)

    {

        DataTable dt;

        string cSteSQL = strSql;

        if (cSteSQL == "")

            cSteSQL = "SELECT * FROM Col_T_Dat_PaymentPlans ";

 

        dt = PCL.MsSQL_DBOperations.GetData(cSteSQL, "SqlConn");

        System.Data.DataColumn dc = new DataColumn("Secim", typeof(bool));

        dt.Columns.Add(dc);

        return dt;

    }

 

    public DataTable m_GetPPDetail(Int64 IntCode)

    {

        DataTable dt = new DataTable();

        String strSQL = "EXECUTE COL_SP_GetPPDetail " + IntCode.ToString();

 

        try

        {

            dt = PCL.MsSQL_DBOperations.GetData(strSQL, "SqlConn");

        }

        catch (Exception ex)

        {

            throw (ex);

        }

 

        return dt;

    }

    public Boolean m_GetEligibility(Decimal CustId)

    {

        Boolean Offer = true;

 

        DataTable dt = new DataTable();

 

        String strSQL = "SELECT COUNT(*) AS CNT FROM Col_T_Dat_PPOfferCheck WHERE CustId =" + CustId.ToString();

 

        try

        {

            dt = PCL.MsSQL_DBOperations.GetData(strSQL, "SqlConn");

 

            if (PCL.Utility.UItoMT.ToInt16(dt.Rows[0]["CNT"].ToString()) > 0)

            {

                Offer = false;

            }

        }

        catch (Exception ex)

        {

            throw (ex);

        }

 

        return Offer;

    }

    public DataTable m_GetPPDescription(Int64 IntCode)

    {

        DataTable dt = new DataTable();

 

        try

        {

            dt = PCL.MsSQL_DBOperations.GetData("Col_SP_GetDescriptionHistory2 " + IntCode.ToString(), "SqlConn");

        }

        catch (Exception ex)

        {

            throw (ex);

        }

        return dt;

    }

}
