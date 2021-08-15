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
    public class CategoriasController : ControllerBase
    {
        private readonly TesteApiContext _context;

        public CategoriasController(TesteApiContext context)
        {
            _context = context;
        }

        // GET: api/Categorias
        [HttpGet]
        public IEnumerable<Categoria> GetCategoria()
        {
            return _context.Categoria;
        }

        // GET: api/Categorias/5
        [HttpGet("listar/{id}")]
        public async Task<IActionResult> GetCategoria([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var categoria = await _context.Categoria.FindAsync(id);

            if (categoria == null)
            {
                return NotFound();
            }

            return Ok(categoria);
        }

        // PUT: api/Categorias/5
        [HttpPut]
        public async Task<IActionResult> PutCategoria([FromBody] Categoria categoria)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //if (categoria.IdCategoria != categoria.IdCategoria)
            //{
            //    return BadRequest();
            //}

            _context.Entry(categoria).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoriaExists(categoria.IdCategoria))
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

        // POST: api/Categorias
        [HttpPost]
        public async Task<IActionResult> PostCategoria([FromBody] Categoria categoria)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Categoria.Add(categoria);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategoria", new { id = categoria.IdCategoria }, categoria);
        }

        // DELETE: api/Categorias/5
        [HttpDelete("{id}")]
        [Route("deletar/{id}")]
        public async Task<IActionResult> DeleteCategoria(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var categoria = await _context.Categoria.FindAsync(id);
            if (categoria == null)
            {
                return NotFound();
            }

            _context.Categoria.Remove(categoria);
            await _context.SaveChangesAsync();

            return Ok(categoria);
        }

        private bool CategoriaExists(int id)
        {
            return _context.Categoria.Any(e => e.IdCategoria == id);
        }
    }
}