using ECommerce_Application.Models;

namespace ECommerce_Application.Data.Services
{
    public interface IActorService
    {
        Task<IEnumerable<Actor>> GetAll();
        Task<Actor> GetById(int id);
        Task Add(Actor actor);
        // check whether id exists in db and if exists then update the database
        void Update(int id, Actor newActor);
        void Delete(int id);
    }
}
