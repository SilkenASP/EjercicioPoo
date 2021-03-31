using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioPOO.Model
{
    public class Cuenta
    {
        #region PropiedadesBase
        public String NumeroCuenta { get; set; }
        public string Nombre { get; set; }
        public Double Saldo { get; set; }
        public Double Interes { get; set; }
        public List<Transacciones> Transacciones { get; set; }
        #endregion

        #region PropiedesFuncionalidad
        public Double RetiroDiario { get; set; }
        public string FechaUltimaRetiro { get; set; }
        #endregion


    }
}