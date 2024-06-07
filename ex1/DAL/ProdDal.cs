using ex1.Models;
using Microsoft.AspNetCore.Mvc;
namespace ex1.DAL
{
    public class ProdDal: IProdDal
    {

        List<Products> prod = new List<Products>() {
            new Products(1, "a", "aa", 1),
            new Products(2, "b", "bb", 2),
            new Products(3, "c", "cc", 3),
            new Products(4, "d", "dd", 4),
        };
        public List<Products> GetAllProd()
        {
            return prod;
        }

        public Products GetProdByID(int id)
        {
            Products p2 = prod.Find(pr => pr.Id == id);
            if (p2 != null)
            {
                return p2;
            }
            return null;
        }
        public void Add(Products p)
        {
            new Products
            {
                Id = p.Id,
                Name = p.Name,
                Category = p.Category,
                Price = p.Price
            };
        }

        public Products Update(Products p)
        {

            Products p2 = prod.Find(pr => pr.Id == p.Id);
            if (p2 != null)
            {
                p2.Name = p.Name;
                p2.Price = p.Price;
                p2.Category = p.Category;
                return (p2);
            }
            return null;
        }
        public List<Products> Delete(int Id)
        {
            Products p2 = prod.Find(pr => pr.Id == Id);
            if (p2 != null)
            {
                prod.Remove(p2);
                return prod;
            }
            return null;
        }
        public Products GetName(string Name)
        {
            Products p2 = prod.Find(pr => pr.Name == Name);
            return p2;
        }
        public Products GetCategory(string Category)
        {
            Products p2 = prod.Find(pr => pr.Category == Category);       
            return p2;           
        }
        public List<Products> GetPrice(int range)
        {
            List<Products> p2 = prod.FindAll(pr => pr.Price <= range);
           return p2;
            
        }





    }
}
