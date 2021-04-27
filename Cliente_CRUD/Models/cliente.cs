using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cliente_CRUD.Models
{
    public class cliente
    {
        [Key]
        public int ID { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
    }
}