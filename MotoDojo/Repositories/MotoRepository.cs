﻿using MotoDojo.Context;
using MotoDojo.Entities;
using Microsoft.EntityFrameworkCore;

namespace MotoDojo.Repositories
{
    public class MotoRepository: IMotoRepository
    {
        private readonly CoreContext _context;

        public MotoRepository(CoreContext context)
        {
            _context = context;
        }

        public List<Moto> GetAll()
        {
            return _context.Motos.ToList();
        }

        public Moto GetById(int id)
        {
            return _context.Motos.FirstOrDefault(moto => moto.Id == id);
        }

        public void Insert(Moto moto)
        {
            _context.Entry(moto).State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Update(Moto moto)
        {
            _context.Entry(moto).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var moto = GetById(id);

            if(moto == null) return;

            _context.Entry(moto).State = EntityState.Deleted;
            _context.SaveChanges();
        }
    }
}
