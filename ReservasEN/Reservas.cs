using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasEN
{
    public class Reservas
    {
        public int IdReserva { get; set; }
        public string Titulo { get; set; }
        public DateTime Fecha { get; set; }
        public string DescripcionReserva { get; set; }
        public int LugarId { get; set; }
        public int UserId { get; set; }
    }
}
