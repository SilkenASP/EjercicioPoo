using EjercicioPOO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioPOO.Services
{
    public class Singleton
    {
        private static Singleton current;
        public static Singleton Instance
        {
            get
            {
                if (current==null)
                {
                    current = new Singleton();
                }
                return current;
            }
        }
        public Cuenta cuenta;
    }
}