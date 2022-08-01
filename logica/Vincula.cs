using ProyectoFinal.datos;
using System;
using System.Data;

namespace ProyectoFinal.logica
{
    internal class Vincula
    {
        private AccesoDatos dt = new datos.AccesoDatos();

        public int registrarVinculacion(int vinID, int asoArtNit, int artCodigo, string vinFechaInicio, string vinFechaFin)
        {
            int resultado;
            /*paso 1: construir la sentencia insert*/
            string consulta;
            if (vinFechaFin.Length > 0)
            {
                consulta = String.Format("INSERT INTO Vincula (vinID, asoArtNit, artCodigo, vinFechaInicio, vinFechaFin) VALUES({0}, {1}, {2}, to_date('{3}','dd/mm/yyyy'), to_date('{4}','dd/mm/yyyy'))",
                                vinID, asoArtNit, artCodigo, vinFechaInicio, vinFechaFin);
            }
            else
            {
                consulta = String.Format("INSERT INTO Vincula (vinID, asoArtNit, artCodigo, vinFechaInicio, vinFechaFin) VALUES({0}, {1}, {2}, to_date('{3}','dd/mm/yyyy'), NULL)",
                               vinID, asoArtNit, artCodigo, vinFechaInicio);
            }
            /*paso 2: enviar la consulta a la capa de datos para ejecutarla*/
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }

        public DataSet consultarVinculacionesPorFechaInicio(string vinFechaInicio)
        {
            DataSet mids = new DataSet();

            string consulta;
            consulta = String.Format(@"SELECT
                         AsociacionArtistas.asoArtNit ""Nit"",
                         asoArtNombre ""Nombre Asociacion"",
                         Artista.artCodigo ""Codigo Artista"",
                         artNombreArtistico ""Nombre Artistico"",
                         artTipoArte ""Tipo de arte interpretado"",
                         nvl(to_char(vinFechaFin), 'No hay fecha') ""Fecha fin vinculacion""
                         FROM Vincula INNER JOIN Artista
                         ON Vincula.artCodigo = Artista.artCodigo
                         INNER JOIN AsociacionArtistas
                         ON Vincula.asoArtNit = AsociacionArtistas.asoArtNit
                         WHERE vinFechaInicio like to_date('{0}','dd/MM/yyyy')", vinFechaInicio);
            //envio la consulta al metodo ejecutarSELECT en la capa de datos
            mids = dt.ejecutarSELECT(consulta);
            return mids;
        }
    }
}