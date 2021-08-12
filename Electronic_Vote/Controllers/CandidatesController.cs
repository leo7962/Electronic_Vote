using AutoMapper;
using Electronic_Vote.Context;
using Electronic_Vote.Dtos;
using Electronic_Vote.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Electronic_Vote.Controllers
{
    [ApiController]
    [Route("api/candidates")]
    public class CandidatesController : ControllerBase
    {
        private readonly DataContext context;
        private readonly IMapper mapper;

        public CandidatesController(DataContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<CandidateDto>>> Get()
        {
            var entities = await context.Candidates.ToListAsync();
            var dtos = mapper.Map<List<CandidateDto>>(entities);
            return dtos;
        }

        [HttpGet("{id:int}", Name = "getCandidate")]
        public async Task<ActionResult<CandidateDto>> Get(int id)
        {
            var entity = await context.Candidates.FirstOrDefaultAsync(x => x.id == id);

            if (entity == null)
            {
                return NotFound();
            }

            var dto = mapper.Map<CandidateDto>(entity);

            return dto;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CandidateCreateDto candidateCreateDto)
        {
            var entity = mapper.Map<Candidate>(candidateCreateDto);
            context.Add(entity);
            await context.SaveChangesAsync();
            var candidateDTO = mapper.Map<CandidateDto>(entity);

            return new CreatedAtRouteResult("getCandidate", new { id = candidateDTO.id }, candidateDTO);
        }


    }
}
