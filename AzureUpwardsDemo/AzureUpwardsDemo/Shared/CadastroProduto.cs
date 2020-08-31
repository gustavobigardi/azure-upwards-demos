using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AzureUpwardsDemo.Shared
{
    public class CadastroProduto
    {
        [Required]
        [StringLength(13, MinimumLength = 12)]
        public string CodigoBarras { get; set; }
        [Required]
        [MaxLength(30)]
        public string Nome { get; set; }
        
        public double? Preco { get; set; }
    }
}
