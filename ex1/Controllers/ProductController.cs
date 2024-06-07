using Microsoft.AspNetCore.Mvc;
using ex1;
using ex1.DAL;
using ex1.BLL;
using ex1.Models;
using ex1.Models.DTO;
using Microsoft.AspNetCore.Http;
using System.Xml.Linq;
using AutoMapper;
using Microsoft.Extensions.Options;

namespace ex1.Controllers
{  
    [ApiController]
    [Route("api/[controller]")]
  
    public class ProductsController : ControllerBase
    {
        private readonly IProdService prodService;
        private readonly IMapper mapper;

        public ProductsController(IProdService productService, IMapper mapper)
        {
            this.prodService = productService;
            this.mapper = mapper;
           
        }

        [HttpGet("/api/products")]
        public List<Products> Get()
        {
            return prodService.GetAllProd();
        }

        [HttpGet("/api/products/{Id}")]
        public ActionResult<Products> Get(int Id)
        {
            return prodService.GetProdByID(Id);
        }

        [HttpPost("/api/products")]
        public void Add(ProductDto p)
        {
            var p2 = mapper.Map<Products>(p);
            prodService.Add(p2);
        }


        [HttpPut("/api/products/{Id}")]
        public Products update(Products p)
        {
            return prodService.Update(p);

        }

        [HttpDelete("/api/products/{Id}")]
        public List<Products> delete(int Id)
        {
            return prodService.Delete(Id); 
        }


        [HttpGet("/api/products/search")]
        public Products GetName(string name)
        {
            return prodService.GetName(name);

        }

        [HttpGet("/api/products/Category/{Category}")]
        public ActionResult<Products> GetCategory(string Category)
        {
            return prodService.GetCategory(Category);
        }

        [HttpGet("api/products/range")]
        public List<Products> GetPrice(int range)
        {
            return prodService.GetPrice(range);
        }



    }

}
