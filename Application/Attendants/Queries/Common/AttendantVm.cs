using AutoMapper;
using Domain.Attendants;

namespace Application.Attendants.Queries.Common
{
    public class AttendantVm
    {
        public string FullName { get; set; }
        
        public string Email { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Attendant, AttendantVm>();
        }
    }
}