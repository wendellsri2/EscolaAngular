using EscolaAngular_WebApi.Data;
using EscolaAngular_WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace EscolaAngular_WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IRepositorio repo;

        public AlunoController(IRepositorio repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                Aluno[]? result = await repo.GetAllAlunosAsync(false);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }
        [HttpGet("{AlunoId}")]
        public async Task<IActionResult> GetByAlunoId(int AlunoId)
        {
            try
            {
                Aluno[]? result = await repo.GetAlunoAsyncById(true);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }
        [HttpGet("ByDisciplina/{disciplinaId}")]
        public async Task<IActionResult> GetByDisciplinaId(int disciplinaId)
        {
            try
            {
                Aluno[]? result = await repo.GetAlunosAsyncByDisciplinaId(disciplinaId, false);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Post(Aluno model)
        {
            try
            {
                repo.Add(model);

                if (await repo.SaveChangesAsync())
                {
                    return Ok(model);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
            return BadRequest();
        }
        [HttpPut("{AlunoId}")]
        public async Task<IActionResult> Put(int alunoId, Aluno model)
        {
            try
            {
                Aluno? aluno = await repo.GetAlunoAsyncById(alunoId, false);
                if (aluno == null)
                {
                    return NotFound();
                }

                repo.Update(model);

                if (await repo.SaveChangesAsync())
                {
                    return Ok(model);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
            return BadRequest();
        }
        [HttpDelete("{AlunoId}")]
        public async Task<IActionResult> Delete(int alunoId)
        {
            try
            {
                Aluno? aluno = await repo.GetAlunoAsyncById(alunoId, false);
                if (aluno == null)
                {
                    return NotFound();
                }

                repo.Delete(aluno);

                if (await repo.SaveChangesAsync())
                {
                    return Ok("Aluno Removido");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
            return BadRequest();
        }


    }
}