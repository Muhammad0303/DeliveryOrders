
using DeliveryOrders.Application.Interfaces;
using DeliveryOrders.Doamin.Entities;

namespace OrderProject.Services
{
    public abstract class BaseService<T> : IBaseService<T> where T: EntityBase
    {
        private readonly string _filePath;

        public BaseService(string filePath)
        {
            _filePath = filePath;
        }
        public void Add(T entity)
        {
         
        }

        public void Delete(T entity)
        {
            throw new System.NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(T customer)
        {
            throw new System.NotImplementedException();
        }
    }
}