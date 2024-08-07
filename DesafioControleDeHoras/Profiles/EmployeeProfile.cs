
using AutoMapper;
using DesafioControleDeHoras.Data.Dtos;
using DesafioControleDeHoras.Models;

namespace DesafioControleDeHoras.Profiles
{
    public class EmployeeProfile: Profile
    {
        public EmployeeProfile() 
        {
            CreateMap<CreateEmployeeDto, Employee>();
        }
    }
}
