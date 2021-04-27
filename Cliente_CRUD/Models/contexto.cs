using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Cliente_CRUD.Models
{
    public class contexto: DbContext
    {
        public DbSet<cliente> Clientes { get; set; }
    }
}