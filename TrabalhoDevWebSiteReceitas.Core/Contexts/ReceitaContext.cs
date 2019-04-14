using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
using TrabalhoDevWebSiteReceitas.Core.Models;

namespace TrabalhoDevWebSiteReceitas.Core.Contexts
{
    public class ReceitaContext  /*: DbContext*/
    {
        //public ReceitaContext(DbContextOptions<ReceitaContext> options)
        //    : base(options)
        //{ }

     
        public DbSet<Receita> Receitas { get; set; }
    }
}
