﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMDATA_API.Models
{
    public class Rol
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
