using BattleRoyalle.Models;
using System.Threading.Tasks;

namespace BattleRoyalle.Repositories
{
    public interface IMaquinaRepository
    {
        Task<Maquina> Adicionar(Maquina entity);
    }
}