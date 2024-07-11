using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers.API
{
    public class Categrory
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
    public class CategoryController : ApiController
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        // GET api/<controller>
        public IEnumerable<Categrory> GetCategories() => db.Categories.Select(c => new Categrory
        {
            CategoryID = c.CategoryID,
            CategoryName = c.CategoryName,
            Description = c.Description,
        }).ToList();
        //GET Metodu
        public Categrory CategroryGetir(int id)
        {
            Categories categories = db.Categories.FirstOrDefault(c => c.CategoryID == id);
            return new Categrory
            {
                CategoryID = categories.CategoryID,
                CategoryName = categories.CategoryName,
                Description = categories.Description,
            };
        }
        // POST api/<controller>
        public IHttpActionResult PostCategory(Categrory categrory)
        {
            db.Categories.Add(new Categories
            {
                CategoryID = categrory.CategoryID,
                CategoryName = categrory.CategoryName,
                Description = categrory.Description,
            });
            db.SaveChanges();
            return Ok<string>("Kategori Kaydedildi.");
        }


        // PUT api/<controller>/5
        public IHttpActionResult PutCategory(int id)
        {
            Categories categories = db.Categories.FirstOrDefault(c => c.CategoryID== id);
            categories.CategoryName = "";
            db.SaveChanges();
            return Ok<string>("Kategori güncellendi");
        }
        // PUT api/<controller>/5
        [HttpPut]
        public IHttpActionResult CategoryGüncelle(int id)
        {
            Categories categories = db.Categories.FirstOrDefault(c => c.CategoryID== id);
            categories.CategoryName = "";
            db.SaveChanges();
            return Ok<string>("Kategori güncellendi");
        }

        // DELETE api/<controller>/5
        public IHttpActionResult DeleteCategory(int id)
        {
            Categories categories = db.Categories.FirstOrDefault(c => c.CategoryID == id);
            db.Categories.Remove(categories);
            db.SaveChanges();
            return Ok<string>("Kategori silindi.");
        }
    }
}