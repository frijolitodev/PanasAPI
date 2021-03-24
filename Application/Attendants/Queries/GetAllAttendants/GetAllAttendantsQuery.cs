using Application.Attendants.Queries.Common;
using MediatR;

namespace Application.Attendants.Queries.GetAllAttendants
{
    public class GetAllAttendantsQuery : IRequest<AttendantListVm>
    {
    }
}