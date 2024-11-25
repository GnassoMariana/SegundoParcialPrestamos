using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialPrestamos.Entidades
{
    public  class Prestamo
    {
        private Persona persona;
        private Plazo plazo;
        private DateTime fechaInicio;
        private decimal tasaAnual;
        private decimal monto;
        private Guid prestamoNro;
        private TipoPrestamo tipo;

        public Persona Persona { get => persona; set => persona = value; }
        public Plazo Plazo { get => plazo; set => plazo = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public decimal TasaAnual { get => tasaAnual; set => tasaAnual = value; }
        public decimal Monto { get => monto; set => monto = value; }
        public Guid PrestamoNro { get => prestamoNro; set => prestamoNro = value; }
        public TipoPrestamo Tipo { get => tipo; set => tipo = value; }

        protected Prestamo() 
        {
            
        }

        public Prestamo(Persona persona, decimal monto, Plazo plazo, DateTime fechaInicio, decimal tasa):this()
        {
            Persona = persona;
            Monto = monto;
            Plazo = plazo;
            FechaInicio= fechaInicio;
            TasaAnual= tasa;

        }

        //public abstract decimal ConfigurarTasaInteres();

        //public abstract List<Prestamo> CalcularCuotas();

        public override string ToString()
        {
           StringBuilder datos = new StringBuilder();
            datos.AppendLine($"Tipo de prestamo: {Tipo}");
            datos.AppendLine($"Fecha de inicio: {FechaInicio}");
            datos.AppendLine($"Monto total: {Monto}");
            datos.AppendLine($"Interes anual: {TasaAnual}");
            datos.AppendLine($"Plazo: {Plazo}");

            return datos.ToString();
        }

    }
}
