using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplicationTeste.Helper;
using WebApplicationTeste.Models;

namespace WebApplicationTeste.Controllers
{
    public class CategoriaController : Controller
    {
        TesteApi _api = new TesteApi();

        public async Task<IActionResult> Index()
        {
            List<CategoriaData> categorias = new List<CategoriaData>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("categorias");

            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                categorias = JsonConvert.DeserializeObject<List<CategoriaData>>(results);
            }

            return View(categorias);
        }

        // GET: Categoria/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var categoria = new CategoriaData();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync($"categorias/listar/{id}");

            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                categoria = JsonConvert.DeserializeObject<CategoriaData>(results);
            }

            return View(categoria);
        }

        // GET: Categoria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categoria/Create
        [HttpPost]
        public IActionResult Create(CategoriaData categoria)
        {
            HttpClient client = _api.Initial();

            //Http Post
            var postTask = client.PostAsJsonAsync<CategoriaData>("categorias", categoria);
            postTask.Wait();

            var result = postTask.Result;

            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        // GET: Categoria/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var categoria = new CategoriaData();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync($"categorias/listar/{id}");

            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                categoria = JsonConvert.DeserializeObject<CategoriaData>(results);
            }

            return View(categoria);
        }

        // POST: Categoria/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CategoriaData categoria)
        {
            HttpClient client = _api.Initial();

            //Http Post
            var putTask = client.PutAsJsonAsync<CategoriaData>("categorias", categoria);
            putTask.Wait();

            var result = putTask.Result;

            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        // GET: Categoria/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var categoria = new CategoriaData();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync($"categorias/deletar/{id}");

            return RedirectToAction("Index");
        }
    }
}