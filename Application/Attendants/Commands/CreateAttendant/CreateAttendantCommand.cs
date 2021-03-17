using MediatR;

namespace Application.Attendants.Commands.CreateAttendant
{
    public class CreateAttendantCommand : IRequest
    {
        public string FullName { get; set; }
        
        public string Email { get; set; }
        
        public string PhoneNumber { get; set; }
    }
}