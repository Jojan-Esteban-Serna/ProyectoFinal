using ProyectoFinal.datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.logica
{
    class AsociacionArtistas
    {
        AccesoDatos dt = new AccesoDatos();
        public int registrarAsociacionArtistas(int asoArtNit, string asoArtNombre, string asoArtModalidad)
        {
            int resultado;
            /*paso 1: construir la sentencia insert*/
            string consulta;
            consulta = String.Format("INSERT INTO AsociacionArtistas (asoArtNit,asoArtNombre,asoArtModalidad) VALUES ({0},'{1}', '{2}')",
                                      asoArtNit, asoArtNombre, asoArtModalidad);
            /*paso 2: enviar la consulta a la capa de datos para ejecutarla*/
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }
        public DataSet consultarAsociacionesArtistas()
        {
            DataSet mids = new DataSet();

            string consulta;
            consulta = "SELECT asoArtNit,asoArtNombre,asoArtModalidad FROM AsociacionArtistas";
            //envio la consulta al metodo ejecutarSELECT en la capa de datos
            mids = dt.ejecutarSELECT(consulta);
            return mids;
        }
    }
}
