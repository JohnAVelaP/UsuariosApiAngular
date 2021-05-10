using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Usuarios.Entities.Entities;

namespace Usuarios.BI.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
