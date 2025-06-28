using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Ubicacion
    {
        private CD_Ubicacion objCapaDato = new CD_Ubicacion();

        public List<Provincia> ObtenerProvincia()
        {
            return objCapaDato.ObtenerProvincia();
        }

        public List<Departamento> ObtenerDepartamento(string idprovincia)
        {
            return objCapaDato.ObtenerDepartamento(idprovincia);
        }

        public List<Localidad> ObtenerLocalidad(string iddepartamento)
        {
            return objCapaDato.ObtenerLocalidad(iddepartamento);
        }
    }
}
