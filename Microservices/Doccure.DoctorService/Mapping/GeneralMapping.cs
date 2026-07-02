using AutoMapper;
using Doccure.DoctorService.Dtos.DoctorDtos;
using Doccure.DoctorService.Entites;

namespace Doccure.DoctorService.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Doctor, ResultDoctorDto>().ReverseMap();
            CreateMap<Doctor, GetByIdDoctorDto>().ReverseMap();
            CreateMap<Doctor, CreateDoctorDto>().ReverseMap();
            CreateMap<Doctor, UpdateDoctorDto>().ReverseMap();

            CreateMap<Education, EducationDto>().ReverseMap();
            CreateMap<Experience, ExperienceDto>().ReverseMap();
            CreateMap<Award, AwardDto>().ReverseMap();

            CreateMap<Location, LocationDto>().ReverseMap();

        }
    }
}
