using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureUpwardsDemo.Shared;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AzureUpwardsDemo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        // GET: api/<Produtos>
        [HttpGet]
        public IEnumerable<CadastroProduto> Get()
        {
            return new CadastroProduto[]
            {
                new CadastroProduto() { CodigoBarras = "123456789012", Nome = "Produto 1", Preco = 1.99 },
                new CadastroProduto() { CodigoBarras = "1234876512874", Nome = "Produto 2", Preco = null },
            };
        }

        // GET api/<Produtos>/5
        [HttpGet("{id}")]
        public CadastroProduto Get(string id)
        {
            return new CadastroProduto[]
            {
                new CadastroProduto() { CodigoBarras = "123456789012", Nome = "Produto 1", Preco = 1.99 },
                new CadastroProduto() { CodigoBarras = "1234876512874", Nome = "Produto 2", Preco = null },
            }.FirstOrDefault(p => p.CodigoBarras == id);
        }

        // POST api/<Produtos>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Produtos>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Produtos>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
