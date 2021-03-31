using EjercicioPOO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO.Repository
{
    public interface ICuenta
    {
        Response GetSaldo();
        Response Depositar(double monto);
        Response Retirar(double monto);
        Response Proyeccion(int tiempo);
        Response GetData();
        Response GetHistorial();


    }
}
