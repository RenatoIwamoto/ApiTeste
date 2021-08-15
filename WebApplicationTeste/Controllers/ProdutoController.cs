using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using WebApplicationTeste.Helper;
using WebApplicationTeste.Models;

namespace WebApplicationTeste.Controllers
{
    public class ProdutoController : Controller
    {
        TesteApi _api = new TesteApi();

        // GET: Produto
        public async Task<IActionResult> Index(int id)
        {
            List<ProdutoData> categorias = new List<ProdutoData>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("produtos");

            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                categorias = JsonConvert.DeserializeObject<List<ProdutoData>>(results);
            }

            return View(categorias);
        }

        // GET: Produto/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var produto = new ProdutoData();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync($"produtos/listar/{id}");

            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                produto = JsonConvert.DeserializeObject<ProdutoData>(results);
            }

            return View(produto);
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProdutoData produto)
        {
            HttpClient client = _api.Initial();

            //Http Post
            var postTask = client.PostAsJsonAsync<ProdutoData>("produtos", produto);
            postTask.Wait();

            var result = postTask.Result;

            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        // GET: Produto/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var produto = new ProdutoData();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync($"produtos/listar/{id}");

            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                produto = JsonConvert.DeserializeObject<ProdutoData>(results);
            }

            return View(produto);
        }

        // POST: Produto/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProdutoData produto)
        {
            HttpClient client = _api.Initial();

            //Http Post
            var putTask = client.PutAsJsonAsync<ProdutoData>("produtos", produto);
            putTask.Wait();

            var result = putTask.Result;

            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        // POST: Produto/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var categoria = new ProdutoData();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync($"produtos/deletar/{id}");

            return RedirectToAction("Index");
        }
    }
}