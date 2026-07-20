using AutoMapper;
using Doccure.PrescriptionService.Dtos.PrescriptionDtos;
using Doccure.PrescriptionService.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Doccure.PrescriptionService.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Prescription, ResultPrescriptionDto>();
            CreateMap<CreatePrescriptionDto, Prescription>();
            CreateMap<PrescriptionItem, PrescriptionItemDto>().ReverseMap();
        }
    }
}
