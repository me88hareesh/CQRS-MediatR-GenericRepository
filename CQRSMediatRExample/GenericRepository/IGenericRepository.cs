namespace CQRSMediatRExample.GenericRepository
{

    public interface IGenericRepository<T> where T : class
    {
         List<T> GetAll();
         T GetById(object  id);

    }
}
