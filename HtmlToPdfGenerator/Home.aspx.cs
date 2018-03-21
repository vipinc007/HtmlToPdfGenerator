using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;



public partial class Home : System.Web.UI.Page
{
    string ReportPage = "DrawReport.aspx?ReportType={0}";
    string ApplicationBaseUrl = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        ApplicationBaseUrl = Request.Url.GetLeftPart(UriPartial.Authority) + Request.ApplicationPath + "/";
    }
    protected void btnReport_Click(object sender, EventArgs e)
    {
        DownloadReportAsPDF();
    }

    private void DownloadReportAsPDF()
    {
        try
        {           
            string url = ApplicationBaseUrl + string.Format(ReportPage,"PDF");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            String ver = response.ProtocolVersion.ToString();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string htmlContent = reader.ReadToEnd();

            NReco.PdfGenerator.HtmlToPdfConverter obj = new NReco.PdfGenerator.HtmlToPdfConverter();
            string respondentName = string.Empty;

            obj.PageHeaderHtml = getHeader();
            obj.PageFooterHtml = getFooter();
            
            var pdfBytes = obj.GeneratePdf(htmlContent);
            Response.Clear();
            MemoryStream ms = new MemoryStream(pdfBytes);
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Report.pdf");
            Response.Buffer = true;
            ms.WriteTo(Response.OutputStream);
            Response.End();
        }
        catch (Exception ex)
        {

        }
    }

    protected string getHeader()
    {
        return "<table  width='100%' ><tr><td>&nbsp;</td><td></td></tr></table>";
    }
    protected string getFooter()
    {
        return "<table  width='100%' ><tr><td>&nbsp;</td><td></td></tr><tr border='0' bordercolor='blue' bgcolor='#E7E7FF'><td style='font-family:sans-serif;   font-size:12px;'><b>Date : " + DateTime.Now.ToShortDateString() + "</b></td><td align='right' style='font-family:sans-serif;   font-size:23px;'><div>Page <span class='page'></span></strong></span></div></td></tr></table>";
    }


    protected void btnHtmlReport_Click(object sender, EventArgs e)
    {
        Response.Redirect(string.Format(ReportPage, ""));
        Response.End();
    }
}