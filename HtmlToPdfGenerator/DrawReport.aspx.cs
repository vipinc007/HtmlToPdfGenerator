using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Web.UI.HtmlControls;


public partial class DrawReport : System.Web.UI.Page
{

    public string ApplicationBaseUrl = string.Empty;
    public string ReportType = "PDF";
    protected void Page_Load(object sender, EventArgs e)
    {
        ApplicationBaseUrl = Request.Url.GetLeftPart(UriPartial.Authority) + Request.ApplicationPath + "/";
        FillGrid();
    }

    private void FillGrid()
    {
        DataTable table1 = new DataTable();
        table1.Columns.Add("ID");
        table1.Columns.Add("Name");
        table1.Columns.Add("Description");
        table1.Columns.Add("Remark");
        table1.Columns.Add("Country");

        DataRow Row = table1.NewRow();
        Row[0] = "1";
        Row[1] = "Vipin";
        Row[2] = "What is Lorem Ipsum? Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the";
        Row[3] = "The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog.";
        Row[4] = "India";

        table1.Rows.Add(Row);

        Row = table1.NewRow();
        Row[0] = "2";
        Row[1] = "Mark";
        Row[2] = "What is Lorem Ipsum? Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the";
        Row[3] = "The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog.";
        Row[4] = "India";

        table1.Rows.Add(Row);

        Row = table1.NewRow();
        Row[0] = "3";
        Row[1] = "Steve";
        Row[2] = "What is Lorem Ipsum? Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the";
        Row[3] = "The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog.";
        Row[4] = "India";

        table1.Rows.Add(Row);

        Row = table1.NewRow();
        Row[0] = "4";
        Row[1] = "Berchman";
        Row[2] = "What is Lorem Ipsum? Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the";
        Row[3] = "The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog.";
        Row[4] = "India";

        table1.Rows.Add(Row);

        Row = table1.NewRow();
        Row[0] = "5";
        Row[1] = "Carlos";
        Row[2] = "What is Lorem Ipsum? Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the";
        Row[3] = "The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog.";
        Row[4] = "India";

        table1.Rows.Add(Row);

        Row = table1.NewRow();
        Row[0] = "6";
        Row[1] = "David";
        Row[2] = "What is Lorem Ipsum? Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the";
        Row[3] = "The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog.";
        Row[4] = "India";

        table1.Rows.Add(Row);

        Row = table1.NewRow();
        Row[0] = "7";
        Row[1] = "Enmart";
        Row[2] = "What is Lorem Ipsum? Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the";
        Row[3] = "The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog.";
        Row[4] = "India";

        table1.Rows.Add(Row);

        Row = table1.NewRow();
        Row[0] = "8";
        Row[1] = "Fundoo";
        Row[2] = "What is Lorem Ipsum? Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the";
        Row[3] = "The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog.";
        Row[4] = "India";

        table1.Rows.Add(Row);


        Row = table1.NewRow();
        Row[0] = "9";
        Row[1] = "Garry";
        Row[2] = "What is Lorem Ipsum? Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the";
        Row[3] = "The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog.";
        Row[4] = "India";

        table1.Rows.Add(Row);

        Row = table1.NewRow();
        Row[0] = "10";
        Row[1] = "Harrison";
        Row[2] = "What is Lorem Ipsum? Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the";
        Row[3] = "The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog.";
        Row[4] = "India";

        table1.Rows.Add(Row);

        Row = table1.NewRow();
        Row[0] = "11";
        Row[1] = "Issac";
        Row[2] = "What is Lorem Ipsum? Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the";
        Row[3] = "The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog.";
        Row[4] = "India";

        table1.Rows.Add(Row);

        grd1.DataSource = table1;
        grd1.DataBind();
    }
}