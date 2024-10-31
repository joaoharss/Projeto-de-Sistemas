namespace Cadastro_Mvc.GenericRepository
{
    public interface IRepository<T> where T : class
    {
        T Create(T entity);
    }
}
