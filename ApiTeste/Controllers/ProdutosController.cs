using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiTeste.Models;

namespace ApiTeste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly TesteApiContext _context;

        public ProdutosController(TesteApiContext context)
        {
            _context = context;
        }

        // GET: api/Produtos
        [HttpGet]
        public IEnumerable<Produto> GetProduto()
        {
            return _context.Produto;
        }

        // GET: api/Produtos/5
        [HttpGet("listar/{id}")]
        public async Task<IActionResult> GetProduto([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var produto = await _context.Produto.FindAsync(id);

            if (produto == null)
            {
                return NotFound();
            }

            return Ok(produto);
        }

        // PUT: api/Produtos/5
        [HttpPut]
        public async Task<IActionResult> PutProduto([FromBody] Produto produto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //if (id != produto.IdProduto)
            //{
            //    return BadRequest();
            //}

            _context.Entry(produto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProdutoExists(produto.IdProduto))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Produtos
        [HttpPost]
        public async Task<IActionResult> PostProduto([FromBody] Produto produto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Produto.Add(produto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduto", new { id = produto.IdProduto }, produto);
        }

        // DELETE: api/Produtos/5
        [HttpDelete("{id}")]
        [Route("deletar/{id}")]
        public async Task<IActionResult> DeleteProduto([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var produto = await _context.Produto.FindAsync(id);
            if (produto == null)
            {
                return NotFound();
            }

            _context.Produto.Remove(produto);
            await _context.SaveChangesAsync();

            return Ok(produto);
        }

        private bool ProdutoExists(int id)
        {
            return _context.Produto.Any(e => e.IdProduto == id);
        }
    }
}