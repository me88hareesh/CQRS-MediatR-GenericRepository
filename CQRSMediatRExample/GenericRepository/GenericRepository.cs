using System.Data;


namespace CQRSMediatRExample.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private FakeDataStore? _fakeDataStore = null;
        public DataSet<T>? _dataSet;

        public GenericRepository(FakeDataStore _fds) {
            _fakeDataStore = _fds;
            //_dataSet = _fakeDataStore.Set<T>();
        }

        public List<T> GetAll()
        {
            var listData = _fakeDataStore?.GetAllProducts();
            throw new NotImplementedException();
        }


        public T GetById(object id)
        {
            throw new NotImplementedException();
        }
    }
}
