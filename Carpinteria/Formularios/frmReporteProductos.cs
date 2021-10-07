using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Carpinteria.Formularios
{
    public partial class frmReporteProductos : Form
    {
        public frmReporteProductos()
        {
            InitializeComponent();
        }

        private void frmReporteProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSProductos.T_PRODUCTOS' Puede moverla o quitarla según sea necesario.
            this.t_PRODUCTOSTableAdapter.Fill(this.dSProductos.T_PRODUCTOS);
            
            this.rvProducto.RefreshReport();
            this.rvProducto.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //validar rango de fechas
            string fecDesde = dtpDesde.Value.ToString();
            string fecHasta = dtpHasta.Text;//es lo mismo las 2 formas
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=DESKTOP-MTET682\SQLEXPRESS;Initial Catalog=carpinteria_db;Integrated Security=True";
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_REPORTE_PRODUCTOS";
            comando.Parameters.AddWithValue("@fecha",dtpDesde.Value);
            comando.Parameters.AddWithValue("@fecha_hasta", dtpHasta.Value);
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());

            rvProducto.LocalReport.DataSources.Clear();
            rvProducto.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1",tabla));
            rvProducto.RefreshReport();



            conexion.Close();
        }
    }
}
