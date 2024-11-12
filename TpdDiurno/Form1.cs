using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpdDiurno.entidad;
using Microsoft.Reporting.WinForms;

namespace TpdDiurno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        public void setVenta(EVenta venta)
        {
            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("DataVenta",new List<EVenta>() { venta })
                );

            reportViewer1.LocalReport.DataSources.Add(
               new ReportDataSource("DataDetalles", venta.Items)
               );
            reportViewer1.LocalReport.DataSources.Add(
               new ReportDataSource("DataCliente",new List<ECliente>() { venta.Cliente })
               );

            reportViewer1.RefreshReport();

        }
    }
}
