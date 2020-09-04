using BattleRoyalle.DTO;
using BattleRoyalle.Models;
using BattleRoyalle.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BattleRoyalle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaquinaController : ControllerBase
    {

        private readonly IMaquinaRepository _maquina;

        public MaquinaController(IMaquinaRepository maquina)
        {
            _maquina = maquina;
        }

        // GET: api/<AccountController>
        [HttpPost("cadastrar")]
        public async Task<IActionResult> Cadastrar(CadastroViewModel model)
        {
               var maquina = new Maquina
                {
                    NomeMaquina = model.NomeMaquina,
                    IP = model.IP,
                    AntiVirus = model.AntiVirus,
                    FireWall = model.FireWall,
                    VersaoWindows = model.VersaoWindows,
                    VersaoNet = model.VersaoNet,
                    TamanhoHDDisponivel = model.TamanhoHDDisponivel,
                    TamanhoHDTotal = model.TamanhoHDTotal
               };
            
            var resultado = await _maquina.Adicionar(maquina);

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("tes123d123123asd2adasdas1312ewte");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, ""),
                    new Claim(ClaimTypes.Role, "")
                }),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            MaquinaDTO maquinaDTO = new MaquinaDTO();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            maquinaDTO.Token = tokenHandler.WriteToken(token);

            return Ok(maquinaDTO.Token);
        }
    }
}
