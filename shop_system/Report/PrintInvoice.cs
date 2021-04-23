using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop_system.Report
{
    public partial class PrintInvoice : Form
    {
        string _invoice_id;
        public PrintInvoice(string _id)
        {
            _invoice_id = _id;
            InitializeComponent();
        }

        private void PrintInvoice_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DRAGEN94; database=shop; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            DataSet1 ds = new DataSet1();
            SqlDataAdapter da = new SqlDataAdapter("select * from [View_Bill] where InvoiceID='"+ _invoice_id + "'",con);
            da.Fill(ds, "DataTable_Invoice");
            ReportDataSource datasource = new ReportDataSource("DataSet_Report",ds.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
            
        }
    }
}
