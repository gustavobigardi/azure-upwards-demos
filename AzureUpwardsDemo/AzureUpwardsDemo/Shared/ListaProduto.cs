using System;
using System.Collections.Generic;
using System.Text;

namespace AzureUpwardsDemo.Shared
{
    public class ListaProduto
    {
        public string CodigoBarras { get; set; }
        public string Nome { get; set; }
        public double? Preco { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
