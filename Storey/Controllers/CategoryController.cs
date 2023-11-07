using Microsoft.AspNetCore.Mvc;
using Storey.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Storey.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        // GET: api/<CategoryController>
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            List<Category> categories = new();

            Category category = new Category();
            Item item = new Item();
            Item otroItem = new Item();
            category.Categoria = "Iluminacion";
            item.Elemento = "Lámpara Led de 5w";
            item.Valor = 5;
            otroItem.Elemento = "Lámpara Led de 10w";
            otroItem.Valor = 10;

            category.Item.Add(item);
            category.Item.Add(otroItem);
            categories.Add(category);

            return categories;
        }
    }
}
