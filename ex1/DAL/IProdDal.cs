using ex1.Models;
namespace ex1.DAL
{
    public interface IProdDal
    {
        List<Products> GetAllProd();
        Products GetProdByID(int id);
        void Add(Products p);
        Products Update(Products p);
        List<Products> Delete(int Id);
        Products GetName(string name);
        Products GetCategory(string Category);
        List<Products> GetPrice(int range);
    }
}
