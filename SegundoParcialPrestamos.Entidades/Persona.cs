using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SegundoParcialPrestamos.Entidades
{
    public class Persona
    {
        private string? apellido;
        private string? nombre;
        private string? dni;

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    apellido = value;
                }
                else
                {
                    throw new ArgumentException("Se debe ingresar el apellido");
                }
            }
        }
        public string Nombre 
        {
            get
            {
                return nombre;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    nombre = value;
                }
                else
                {
                    throw new ArgumentException("Se debe ingresar el nombre");
                }
            }
        }
        public string Dni 
        {
            get
            {
                return dni;
            }
            set
            {
                if (ValidarDni(value))
                {
                    dni = value;
                }
                else
                {
                    throw new ArgumentException("Numero de docuento invalido");
                }
            }
        }

        private static bool ValidarDni(string dni)
        {
            string patron = @"^[0-9]{8}^";
            Regex regex = new Regex(patron);
            return regex.IsMatch(dni);
        }

        public Persona()
        {
            
        }

        public static bool operator ==(Persona a, Persona b)
        {
            return a.Dni == b.Dni;
        }

        public static bool operator != (Persona a, Persona b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            return $"{Apellido}, {Nombre}";
        }
    }
}
