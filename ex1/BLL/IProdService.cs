
namespace ex1.BLL
{
    public interface IProdService
    {
        void Add(Products p);
        List<Products> Delete(int Id);
        List<Products> GetAllProd();
        Products GetCategory(string Category);
        Products GetName(string name);
        List<Products> GetPrice(int range);
        Products GetProdByID(int id);
        Products Update(Products p);
    }
}