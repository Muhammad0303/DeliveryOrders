using DeliveryOrders.Doamin.Entities;

namespace DeliveryOrders.Application.Interfaces
{
    public interface IBaseService<T> where T : EntityBase
    {
        void Add(T entity);
        void Delete(T entity);
        T GetById(int id);
        void Update(T customer);
    }
}
