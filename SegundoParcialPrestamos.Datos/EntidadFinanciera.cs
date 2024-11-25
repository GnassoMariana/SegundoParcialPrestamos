using SegundoParcialPrestamos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialPrestamos.Datos
{
    public class EntidadFinanciera
    {
        private  string? nombre;
        private List<Prestamo>? prestamos;

        public EntidadFinanciera(string nombre)
        {
            this.nombre = nombre;
        }

        private EntidadFinanciera()
        {
            prestamos = new List<Prestamo>();
        }

        public(bool resultado, string mensaje) AgregarPrestamo(Prestamo prestamo)
        {
            if(!ExistePrestamo(prestamo))
            {
                prestamos!.Add(prestamo);
                return (true, $"{prestamo.ToString()}");

            }
            else
            {
                return (false, "Prestamo no otorgado ");
            }
        }



        private bool ExistePrestamo(Prestamo prestamo)
        {
            if(!prestamos!.Any(p=> p.Persona == prestamo.Persona && p.FechaInicio == prestamo.FechaInicio &&
                               p.Monto == prestamo.Monto && p.Plazo == prestamo.Plazo && p.Tipo == prestamo.Tipo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Prestamo> GetPrestamos(TipoPrestamo tipo)
        {
            List<Prestamo> nuevaLista = new List<Prestamo>();
            foreach (var prestamo in prestamos)
            {
                if(prestamo.Tipo == tipo)
                {
                    nuevaLista.Add(prestamo);
                    
                }
            }
            return nuevaLista;
        }

        public int GetCantidad(TipoPrestamo tipo)
        {
            return prestamos!.Count(p=> p.Tipo == tipo);
        }

        public Prestamo GetPrestamo(Guid nro)
        {
            if(prestamos.Any(p=> p.PrestamoNro == nro))
            {
                Prestamo prestamo =prestamos.FirstOrDefault(p=> p.PrestamoNro == nro)!;
                return prestamo;
            }
            else
            {
                throw new ArgumentException("El prestamo no existe");
            }
        }
    }
}
