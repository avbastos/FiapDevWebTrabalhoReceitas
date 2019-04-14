using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TrabalhoDevWebSiteReceitas.Core.Models
{
    public class Receita
    {

        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public string ModoDePreparo { get; set; }
        public string Ingredientes { get; set; }
    }
}
