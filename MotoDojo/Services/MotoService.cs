using MotoDojo.Entities;
using MotoDojo.Repositories;

namespace MotoDojo.Services
{
    public class MotoService : IMotoService
    {
        private IMotoRepository _repository;

        public MotoService(IMotoRepository repository)
        {
            _repository = repository;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Moto> GetAll()
        {
            throw new NotImplementedException();
        }

        public Moto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Moto moto)
        {
            throw new NotImplementedException();
        }

        public void Update(Moto moto)
        {
            throw new NotImplementedException();
        }
    }
}
