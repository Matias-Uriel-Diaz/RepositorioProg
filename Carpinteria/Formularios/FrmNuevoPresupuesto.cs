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
    //public partial class FrmNuevoPresupuesto : Form
    //{
    //    private Presupuesto nuevo;//instanciamos un objeto presupuesto 

    //    public FrmNuevoPresupuesto()
    //    {
    //        InitializeComponent();
    //        nuevo = new Presupuesto();//lo inicializamos al objeto
    //    }

    //    private void FrmNuevoPresupuesto_Load(object sender, EventArgs e)
    //    {
    //        lblNroPresupuesto.Text += ProximoPresupuesto();
    //        CargarProducto();
    //        txtFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");//le damos la fecha que esta ocurrienddo justo ahora
    //        txtCliente.Text = "Consumidor Final";
    //        txtDescuento.Text = "0";
    //        txtCantidad.Text = "1";
    //        //le damos un valor predeterminado a los text box apenas arranca el forms 
    //    }

    //    private int ProximoPresupuesto()//vamos a llamar al SP
    //    {
    //        SqlConnection conn = new SqlConnection();
    //        conn.ConnectionString = @"Data Source=DESKTOP-MTET682\SQLEXPRESS;Initial Catalog=carpinteria_db;Integrated Security=True";
    //        conn.Open();
    //        SqlCommand comm = new SqlCommand();
    //        comm.Connection = conn;
    //        comm.CommandType = CommandType.StoredProcedure;
    //        comm.CommandText = "SP_PROXIMO_ID";
    //        SqlParameter param = new SqlParameter("@next", SqlDbType.Int);//se pone el parametro de salida de tipo entero
    //        param.Direction = ParameterDirection.Output;//le marcamos que va a ser output es decir es un param de salida
    //        comm.Parameters.Add(param);//añadimos el param al comando es decir a donde se ponen las sentencias
    //        comm.ExecuteNonQuery();



    //        conn.Close();
    //        return (int)param.Value; //le añadimos al label el valor del param = al output

    //    }
    //    private void CargarProducto()
    //    {
    //        SqlConnection conn = new SqlConnection();
    //        conn.ConnectionString = @"Data Source=DESKTOP-MTET682\SQLEXPRESS;Initial Catalog=carpinteria_db;Integrated Security=True";
    //        conn.Open();
    //        SqlCommand comm = new SqlCommand();
    //        comm.Connection = conn;
    //        comm.CommandType = CommandType.StoredProcedure;
    //        comm.CommandText = "SP_CONSULTAR_PRODUCTOS";//este sp no tiene parametros
    //        DataTable table = new DataTable();//asi que lo guardamos en una tabla 
    //        table.Load(comm.ExecuteReader());


    //        conn.Close();
    //        cboProductos.DataSource = table;//le damos el valor de la tabla al cbo 
    //        cboProductos.DisplayMember = "n_producto";//muestra esa columna
    //        cboProductos.ValueMember = "id_producto";//toma ese valor
    //    }

    //    private void btnAgregar_Click(object sender, EventArgs e)
    //    {

    //        if (cboProductos.Text.Equals(string.Empty))//si cbo esta vacio muestra un mensaje
    //        {
    //            MessageBox.Show("Debe seleccionar un Producto...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    //            return;
    //        }
    //        if (string.IsNullOrEmpty(txtCantidad.Text) || !int.TryParse(txtCantidad.Text, out _))//si la cantidad es nula o || no es int muestra mensjae el out es como return del try parse
    //        {
    //            MessageBox.Show("Debe ingresar una cantidad válida...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    //            return;
    //        }
    //        //cuando yo haga click en agregar se va añadir todos estos datos 
    //        //los 3 primero svalores se obtienen del combobox y pertenecen a la clase Producto
    //        //el Cant pertenece a la clase detalle presupuesto 
    //        foreach (DataGridViewRow row in dgvDetalles.Rows)//esto es una validacion
    //        {
    //            if (row.Cells["ColProd"].Value.ToString().Equals(cboProductos.Text))//si una fila de la grilla de la columna colprod tiene 2 veces el valor de esta columna salta
    //                MessageBox.Show("Debe ingresar una cantidad válida...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    //            return;
    //        }
    //        DataRowView item = (DataRowView)cboProductos.SelectedItem;//el item seleccionado en el combo va a ser una fila
    //        int prod = Convert.ToInt32(item.Row.ItemArray[0]);//del item obtenido del cbo buscamos en la columna 0 el valor int = prod
    //        string nom = item.Row.ItemArray[1].ToString();//columna 1 
    //        double pre = Convert.ToDouble(item.Row.ItemArray[2]);//columna 2
    //        int cant = Convert.ToInt32(txtCantidad.Text); // 

    //        Producto p = new Producto(prod, nom, pre);//instanciamos el producto con los 3 primeros 
    //        //ahora creamoos un detalle presupuezsto
    //        DetallePresupuesto detalle = new DetallePresupuesto(p, cant);//instanciamos un detallepresupuestpo

    //        nuevo.AgregarDetalle(detalle);//el objeto presupuesto llama al metodo y lo usa como param el obj detallepresup
    //        dgvDetalles.Rows.Add(new object[] { prod, nom, pre, cant });//añadimos filas a la grilla con los valores obtenidos en el combo

    //        CalcularTotales();//actualiza el precio añ añadir fila


    //    }

    //    private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)//evento de la grilla 
    //    {
    //        if (dgvDetalles.CurrentCell.ColumnIndex == 4)//si hace click en la columna con valor 4
    //        {
    //            nuevo.QuitarDetalle(dgvDetalles.CurrentRow.Index);//se elimina la fila de la grilla
    //            dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);//
    //            CalcularTotales();//actualiza el precio al eliminar la fila
    //        }

    //    }

    //    private void CalcularTotales()//calcula el total
    //    {
    //        txtSubTotal.Text = nuevo.CalcularTotal().ToString();//calculamos el subtotal con el metodo de presupuesto

    //        double desc = nuevo.CalcularTotal() - nuevo.CalcularTotal() * Convert.ToDouble(txtDescuento.Text) / 100;//calculamos descuento
    //        txtTotal.Text = (nuevo.CalcularTotal() - desc).ToString();//obtenemos el valor

    //    }



    //}

    public partial class FrmNuevoPresupuesto : Form
    {
        private Presupuesto nuevo;//objeto tipo presupuesot

        public FrmNuevoPresupuesto()
        {
            InitializeComponent();
            nuevo = new Presupuesto();
        }

        private void FrmNuevoPresupuesto_Load(object sender, EventArgs e)
        {
            lblNroPresupuesto.Text += ProximoPresupuesto();
            CargarProductos();
            txtFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
            txtCliente.Text = "Consumidor Final";
            txtDescuento.Text = "0";
            txtCantidad.Text = "1";
        }

        private void CargarProductos()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=DESKTOP-MTET682\SQLEXPRESS;Initial Catalog=carpinteria_db;Integrated Security=True";
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_CONSULTAR_PRODUCTOS";
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();

            cboProductos.DataSource = tabla;
            cboProductos.DisplayMember = tabla.Columns[1].ColumnName;
            cboProductos.ValueMember = tabla.Columns[0].ColumnName;

            //cboProductos.DisplayMember = "n_producto";
            //cboProductos.ValueMember = "id_producto";
        }

        private int ProximoPresupuesto()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=DESKTOP-MTET682\SQLEXPRESS;Initial Catalog=carpinteria_db;Integrated Security=True";
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_PROXIMO_ID";
            SqlParameter param = new SqlParameter("@next", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            comando.Parameters.Add(param);
            comando.ExecuteNonQuery();
            conexion.Close();

            return (int)param.Value;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboProductos.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe seleccionar un Producto...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtCantidad.Text) || !int.TryParse(txtCantidad.Text, out _))
            {
                MessageBox.Show("Debe ingresar una cantidad válida...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (row.Cells["ColProd"].Value.ToString().Equals(cboProductos.Text))
                {
                    MessageBox.Show("Este producto ya está presupuestado...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            DataRowView item = (DataRowView)cboProductos.SelectedItem;

            int prod = Convert.ToInt32(item.Row.ItemArray[0]);
            string nom = item.Row.ItemArray[1].ToString();
            double pre = Convert.ToDouble(item.Row.ItemArray[2]);
            Producto p = new Producto(prod, nom, pre);

            int cant = Convert.ToInt32(txtCantidad.Text);
            DetallePresupuesto detalle = new DetallePresupuesto(p, cant);

            nuevo.AgregarDetalle(detalle);//se añadanm los dertalles
            dgvDetalles.Rows.Add(new object[] { prod, nom, pre, cant });//añade filas

            CalcularTotales();
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 4)
            {
                nuevo.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);
                CalcularTotales();
            }
        }

        private void CalcularTotales()
        {
            txtSubTotal.Text = nuevo.CalcularTotal().ToString();
            double desc = nuevo.CalcularTotal() * Convert.ToDouble(txtDescuento.Text) / 100;
            txtTotal.Text = (nuevo.CalcularTotal() - desc).ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)//vamos a hacer un insert

        {
            //VALIDAR
            if (txtCliente.Text == "")
            {
                MessageBox.Show("FALTAN DATOS");
                return;
            }
            if (txtCantidad.Text == "")
            {
                MessageBox.Show("FALTAN DATOS");
                return;
            }
            if (txtFecha.Text == "")
            {
                MessageBox.Show("FALTAN DATOS");
                return;
            }
            if (dgvDetalles.Rows.Count == 0)//si la grilla esta vaccia
            {
                MessageBox.Show("GRILLA VACIA", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //grabar maestro y detalles
            //vamos a guardar presupuesto 
            GuardarPresupuesto();

        }


        private void GuardarPresupuesto()//este es un metodo de presupuesto ya que es su responsabilidad guardarse
        {//se van a guardar en la BD que es responsabilidad de PRESUPUESTO 
            nuevo.Fecha = Convert.ToDateTime(txtFecha.Text);
            nuevo.Cliente = txtCliente.Text;
            nuevo.Descuento = double.Parse(txtDescuento.Text);
            nuevo.Total = double.Parse(txtTotal.Text);
            if (nuevo.Confirmar() == true)//va a confirmar si se guardo o no
            {
                MessageBox.Show("el presupuesto se grabo","notificacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("el presupuesto no se grabo", "notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)//cierra y libera el form
        {
            this.Dispose();
        }
    }
}
