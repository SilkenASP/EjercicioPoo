using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioPOO.Model
{
    public class Transacciones
    {
        public String Accion { get; set; }
        public Double Monto { get; set; }
        public DateTime Fecha { get; set; }
        public Double Nuevo_Saldo { get; set; }
    }
}