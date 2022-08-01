using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ProyectoFinal.datos
{
    internal class AccesoDatos
    {
        //Paso 0:agregar las referencias dll para que el codigo en c# me reconozca el
        //codigo de oracle.

        //Paso 1: creo la cadena de conexion
        private string cadenaConexion = "DATA SOURCE=localhost; USER ID=BASES1; Password = oracle";

        //paso 2: crear el metodo que ejecuta una instruccion DML
        //insert delete update
        public int ejecutarDML(string consulta)
        {
            int filasAfectadas = 0;
            //paso 1: crear la conexion, creando un objeto
            //del tipo OracleConnection
            OracleConnection miConexion = new OracleConnection(cadenaConexion);
            //paso2: crear un obj de tipo OracleCommand
            OracleCommand miComando = new OracleCommand(consulta, miConexion);
            //paso 3: abrir la conexion
            miConexion.Open();
            /*paso 4: ejecutar el comando. Al ejecutar un objeto de tipo comando
             * este devuelve un valor entero que me indica las filas que se
             * afectaron en la operacion DML(insert, update,delete). */
            filasAfectadas = miComando.ExecuteNonQuery();
            //paso 5: cierro la conexion
            miConexion.Close();
            return filasAfectadas;
        }

        public DataSet ejecutarSELECT(string consulta)
        {
            //paso 1: crear un dataset vacio
            DataSet ds = new DataSet();
            //paso 2: creo un adaptador
            OracleDataAdapter miAdaptador = new OracleDataAdapter(consulta, cadenaConexion);
            //paso 3: a través de adaptador llenamos el dataset
            miAdaptador.Fill(ds, "ResultadoDatos");
            //paso 4: retorno el dataset lleno
            return ds;
        }
    }
}