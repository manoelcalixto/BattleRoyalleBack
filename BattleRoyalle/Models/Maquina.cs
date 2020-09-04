

using BattleRoyalle.Data;

namespace BattleRoyalle.Models
{
    public class Maquina : IEntity
    {
        public int Id { get; set; }
        public string NomeMaquina { get; set; }
        public string IP { get; set; }
        public string AntiVirus { get; set; }
        public string FireWall { get; set; }
        public string VersaoWindows{ get; set; }
        public string VersaoNet { get; set; }
        public float TamanhoHDDisponivel { get; set; }
        public float TamanhoHDTotal { get; set; }
    }
}
