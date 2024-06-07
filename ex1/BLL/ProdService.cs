using ex1.Models;
using ex1.DAL;

namespace ex1.BLL;
public class ProdService : IProdService
{
    private readonly IProdDal prodDal;
    public ProdService(IProdDal prodDal)
    {
        this.prodDal = prodDal;
    }
    public List<Products> GetAllProd()
    {
        return prodDal.GetAllProd();
    }
    public Products GetProdByID(int id)
    {
        return prodDal.GetProdByID(id);
    }
    public void Add(Products p)
    {
        prodDal.Add(p);
    }
    public Products Update(Products p)
    {
        return prodDal.Update(p);
    }
    public List<Products> Delete(int Id)
    {
        return prodDal.Delete(Id);
    }
    public Products GetName(string name)
    {
        return prodDal.GetName(name);
    }
    public Products GetCategory(string Category)
    {
        return prodDal.GetCategory(Category);
    }
    public List<Products> GetPrice(int range)
    {
        return prodDal.GetPrice(range);
    }
}

   
