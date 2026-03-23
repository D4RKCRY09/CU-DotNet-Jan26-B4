using AutoMapper;
using LoanManagementWebAPI.DTO;
using LoanManagementWebAPI.Model;
namespace LoanManagementWebAPI.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Loan, LoanGetDTO>();
            CreateMap<LoanPostDTO, Loan>();

            CreateMap<Loan, LoanGetDTO>();
        }
    }
}
