using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMDATA_API.Models
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int Salario { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public string Sexo { get; set; }
        public string Cod_Interno { get; set; }
        public int fk_id_area { get; set; }
        public int fk_id_rol { get; set; }
        public int? fk_id_Encargado { get; set; }
    }
}
