using FacturacionElectricidadPR.EdeRicoDataSetTableAdapters;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionElectricidadPR
{
    public partial class FrmReporte : Form
    {
        public FrmReporte()
        {
            InitializeComponent();
            RefreshReportView(adapter.GetData());
        }
        tlbFacturaTableAdapter adapter = new tlbFacturaTableAdapter();
        public void RefreshReportView(EdeRicoDataSet.tlbFacturaDataTable tlbFacturas)
        {
            var reportDataSrc = new ReportDataSource("RPPEdeRicoDataSet", (DataTable)tlbFacturas);
            RwFacturas.LocalReport.DataSources.Clear();
            RwFacturas.LocalReport.ReportPath = "RpFacturaPR.rdlc";
            RwFacturas.LocalReport.DataSources.Add(reportDataSrc);

        }
        private void FrmReporte_Load(object sender, EventArgs e)
        {
            RwFacturas.RefreshReport();
        }

        private void BtnBuscarContrato_Click(object sender, EventArgs e)
        {
            var result = adapter.FindFacturaByContrato(TxtContrato.Text);
            RefreshReportView(result);
            RwFacturas.RefreshReport();
        }
    }
}
