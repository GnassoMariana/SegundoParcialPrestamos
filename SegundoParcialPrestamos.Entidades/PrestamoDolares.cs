using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialPrestamos.Entidades
{
    public class PrestamoDolares: Prestamo
    {
        public Dictionary<Plazo, decimal> TasasPorPlazo { get;}

        public PrestamoDolares()
        {
            
        }
        public PrestamoDolares(Persona persona, decimal monto, Plazo plazo,DateTime fechaInicio, decimal tasa)
            :base(persona, monto, plazo, fechaInicio, tasa) 
        {
            
        }
    }
}
