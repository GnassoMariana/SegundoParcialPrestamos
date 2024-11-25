using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialPrestamos.Entidades
{
    public class PrestamoPesos: Prestamo
    {
        public Dictionary<Plazo, decimal> TasasPorPlazo { get; }

        public PrestamoPesos()
        {
            
        }

        public PrestamoPesos(Persona persona, decimal monto, Plazo plazo, DateTime fechaInicio, decimal tasa)
            :base(persona, monto, plazo, fechaInicio,tasa)
        {
            
        }
    }
}
