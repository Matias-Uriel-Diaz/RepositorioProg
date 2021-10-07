using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Carpinteria
{
    class Presupuesto
    {
        public int PresupuestoNro { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public double Total { get; set; }
        public double Descuento { get; set; }
        public DateTime FechaBaja { get; set; }
        public List<DetallePresupuesto> Detalles { get; set; }

        public Presupuesto()
        {
            Detalles = new List<DetallePresupuesto>();
        }

        public void AgregarDetalle(DetallePresupuesto detalle)
        {
            Detalles.Add(detalle);
        }

        public void QuitarDetalle(int indice)
        {
            Detalles.RemoveAt(indice);
        }

        public double CalcularTotal()
        {
            double total = 0;
            //for (int i = 0; i < Detalles.Count; i++)
            //{
            //    total += Detalles[i].CalcularSubtotal();
            //}
            foreach (DetallePresupuesto item in Detalles)
            {
                total += item.CalcularSubtotal();
            }
            return total;
        }
        public bool Confirmar()

        {//LO GUARDA EN LA TABLA PRESUPUESOT
            SqlConnection conexion = new SqlConnection();
            SqlTransaction transaccion = null;
            bool estado = true;
            try // necesitamos ejecutar el try con transsaction 
            {

                  
                
                conexion.ConnectionString = @"Data Source=DESKTOP-MTET682\SQLEXPRESS;Initial Catalog=carpinteria_db;Integrated Security=True";
                conexion.Open();
                transaccion = conexion.BeginTransaction();//arrancamos la transaccion despues de estar abierta la conexin
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.Transaction = transaccion;//y darle al comando la transcaccion
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_INSERTAR_MAESTRO";//nombre del sp
                comando.Parameters.AddWithValue("@cliente", this.Cliente);//parametros de entrada con addwithvalue y se les da el valor del atributo
                comando.Parameters.AddWithValue("@dto", this.Descuento);
                comando.Parameters.AddWithValue("@total", this.Total);
                //paramerto de salida
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@presupuesto_nro";
                param.SqlDbType = SqlDbType.Int;//tipo que devuelve en el SP
                param.Direction = ParameterDirection.Output;//direccion output
                comando.Parameters.Add(param);//se añade al comando 
                comando.ExecuteNonQuery();//
                this.PresupuestoNro = (int)param.Value;//nos devuelve el presuoesto
                int detallenum = 1;//va a ser el @detalle del sp insertar_detalle

                //LAS 2 FORMAS DE HACER 
                //for (int i=1;i<Detalles.Count;i++)
                //{
                //    SqlCommand comando2 = new SqlCommand();//nuevo comando que va  a trabajar con la list y otro SP
                //    comando2.Connection = conexion;
                //    comando2.CommandType = CommandType.StoredProcedure;
                //    comando2.CommandText = "SP_INSERTAR_DETALLE";//nombre del sp
                //    comando2.Parameters.AddWithValue("@presupuesto_nro", this.PresupuestoNro);//
                //    comando2.Parameters.AddWithValue("@detalle", i);//contador va a ser el valor de ese param
                //    comando2.Parameters.AddWithValue("@id_producto", Detalles[i].Producto.ProductoNro);//composicion porducto sale del detalle presupuesto 
                //    comando2.Parameters.AddWithValue("@cantidad", Detalles[i].Cantidad);
                //    comando2.ExecuteNonQuery();
                //    detallenum++; //para actualizar el numero del detalle
                //}
                foreach (DetallePresupuesto i in Detalles)//lo guarda en la TABLA DETALLES_PRESUPUESTO
                {
                    SqlCommand comando2 = new SqlCommand();//nuevo comando que va  a trabajar con la list y otro SP
                    comando2.Connection = conexion;
                    comando2.Transaction = transaccion;
                    comando2.CommandType = CommandType.StoredProcedure;
                    comando2.CommandText = "SP_INSERTAR_DETALLE";//nombre del sp
                    comando2.Parameters.AddWithValue("@presupuesto_nro", this.PresupuestoNro);//
                    comando2.Parameters.AddWithValue("@detalle", detallenum);//contador va a ser el valor de ese param
                    comando2.Parameters.AddWithValue("@id_producto", i.Producto.ProductoNro);//composicion porducto sale del detalle presupuesto 
                    comando2.Parameters.AddWithValue("@cantidad", i.Cantidad);
                    comando2.ExecuteNonQuery();
                    detallenum++; //para actualizar el numero del detalle y se necesita para no repetir PK
                }
                transaccion.Commit();//termina el transacction si todo termian bien y va a la BD
                
            }
            catch (Exception e)//si hay error returna false y no se puede grabar 
            {
                transaccion.Rollback();//deja todo como esta si no se cumple todo , no se hace nada
                estado= false;
            }
            finally//si entra al catch se ejecuta el finally que este cierra la conexion 
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return estado;//creamos una variable que se ejecuta de forma correcta si no se ejecuta el catch pero si entra alli se vuelve false 
        }
    }
}
