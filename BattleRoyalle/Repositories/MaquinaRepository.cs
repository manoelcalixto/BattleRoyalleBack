using BattleRoyalle.Data;
using BattleRoyalle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleRoyalle.Repositories
{
    public class MaquinaRepository : IMaquinaRepository
    {
        private readonly ApplicationContext _context;
        public MaquinaRepository(ApplicationContext context)
        {
            this._context = context;
        }

        public async Task<Maquina> Adicionar(Maquina entity)
        {
            _context.Set<Maquina>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
