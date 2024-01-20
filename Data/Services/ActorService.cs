using ECommerce_Application.Models;
using Microsoft.EntityFrameworkCore;
using ECommerce_Application.Data;

namespace ECommerce_Application.Data.Services
{
    public class ActorService : IActorService
    {
        private readonly AppDbContext _context;

        public ActorService(AppDbContext context)
        {
            _context = context;
        }
        public async Task Add(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }

        public async Task<Actor> GetById(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public void Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}
