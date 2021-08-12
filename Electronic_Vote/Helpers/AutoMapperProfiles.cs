using AutoMapper;
using Electronic_Vote.Dtos;
using Electronic_Vote.Models;

namespace Electronic_Vote.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Candidate, CandidateDto>().ReverseMap();
            CreateMap<CandidateCreateDto, Candidate>();
        }

    }
}
