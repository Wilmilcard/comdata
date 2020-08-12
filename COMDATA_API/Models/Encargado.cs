using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMDATA_API.Models
{
    public class Encargado
    {
        [Key]
        public int Id { get; set; }
        public int IdEncargado { get; set; }
    }
}
