using ProyectoFinal.datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.logica
{
    class Artista
    {
        //creo un obj de la clase AccesoDatos
        AccesoDatos dt = new AccesoDatos();
        public int registrarArtista(int artCodigo, string artTipoArte, string artNombreArtistico,int artAnioNacimiento )
        {
            int resultado;
            /*paso 1: construir la sentencia insert*/
            string consulta;
            consulta = String.Format("INSERT INTO Artista (artCodigo,artTipoArte,artNombreArtistico,artAnioNacimiento) VALUES ({0},'{1}', '{2}',{3})",
                                      artCodigo,artTipoArte,artNombreArtistico,artAnioNacimiento);
            /*paso 2: enviar la consulta a la capa de datos para ejecutarla*/
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }
        public DataSet consultarArtistas()
        {
            DataSet mids = new DataSet();

            string consulta;
            consulta = "SELECT artCodigo,artTipoArte,artNombreArtistico,artAnioNacimiento FROM Artista";
            //envio la consulta al metodo ejecutarSELECT en la capa de datos
            mids = dt.ejecutarSELECT(consulta);
            return mids;
        }

        public string consultarCantidadPor(string columna, string valor)
        {
            DataSet conteo = new DataSet();
            string consulta;
            consulta = String.Format("SELECT count(artCodigo) FROM Artista WHERE {0} LIKE {1}", columna, valor);
            conteo = dt.ejecutarSELECT(consulta);
            return conteo.Tables[0].Rows[0][0].ToString();
        }
    }
}
