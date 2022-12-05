using AutoMapper;
using FinalProject.DataModel;
using FinalProject.App;
using FinalProject.App.Models;

namespace FinalProject.App.Configuration
{
    public class MapperConfig : Profile
    {
        // patients automapper
        public MapperConfig()
        {
            CreateMap<Patient, PatientVM>().ReverseMap();
            CreateMap<Medical, MedicalVM>().ReverseMap();
        }
    }
}
