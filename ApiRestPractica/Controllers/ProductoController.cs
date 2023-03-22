using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using ApiRestPractica.Models;
 
namespace ApiRestPractica.Controllers
{
    public class ProductoController : ApiController

    {
        static Dictionary<int, Producto> productos = new Dictionary<int, Producto>();


       
        //GET API/producto
        public IEnumerable<Producto> get()
        {
            Producto p = new Producto();
            p.Nombre = "Producto de prueba";
            productos.Add(1, p);

            return new List<Producto>(productos.Values);
        }

        //GET API/producto/5

        public Producto get(int id)
        {
            Producto encontrado;
            productos.TryGetValue(id, out encontrado);
            return encontrado;
        }

        // POST api/Producto
        public bool Post ([FromBody] Producto producto)
        {
            Producto encontrado;
            productos.TryGetValue(producto.IdProducto, out encontrado); 
            if (encontrado  != null)
            {  productos.Add(producto.IdProducto, producto);
                return true;
            } else
            {
                return false;
            }
        }


        //POST API/producto
       // public bool Post([Frombody] Producto producto)




        /**
        // GET: Producto
        public ActionResult Index()
        {
            return View();
        }

        // GET: Producto/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Producto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Producto/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Producto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Producto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Producto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Producto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
    *///
}
}
