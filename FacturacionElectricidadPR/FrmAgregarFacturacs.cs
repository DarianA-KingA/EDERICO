using FacturacionElectricidadPR.EdeRicoDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionElectricidadPR
{
    public partial class FrmAgregarFacturacs : Form
    {
        public FrmAgregarFacturacs()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["EderricoDB"].ConnectionString))
            {
                con.Open();
                var cmd = new SqlCommand("SP_Add_Factura", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CONSUMO", int.Parse(txtConsumo.Text));
                cmd.Parameters.AddWithValue("@TIPO_DOCUMENTO", int.Parse(txtTipoDocumento.Text));
                cmd.Parameters.AddWithValue("@DOCUMENTO", txtDocumento.Text);
                cmd.Parameters.AddWithValue("@NOMBRES", txtNombres.Text);
                cmd.Parameters.AddWithValue("@APELLIDOS", txtApellidos.Text);
                cmd.Parameters.AddWithValue("@CONTRATO", txtContrato.Text);
                cmd.Parameters.AddWithValue("@MONTO", int.Parse(txtMonto.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Factura agregada con exito","Notificacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            tlbFacturaTableAdapter adapter = new tlbFacturaTableAdapter();
            //Este segundo add es para que el table adapter tenga en nuevo registro tambien
            adapter.SP_INSERT_FACTURA(int.Parse(txtConsumo.Text),
                                      int.Parse(txtTipoDocumento.Text),
                                      txtDocumento.Text,
                                      txtNombres.Text,
                                      txtApellidos.Text,
                                      txtContrato.Text,
                                      int.Parse(txtMonto.Text));

        }
    }
}
