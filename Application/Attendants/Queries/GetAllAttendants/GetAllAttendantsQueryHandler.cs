using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Attendants.Queries.Common;
using AutoMapper;
using MediatR;

namespace Application.Attendants.Queries.GetAllAttendants
{
    public class GetAllAttendantsQueryHandler 
        : IRequestHandler<GetAllAttendantsQuery, AttendantListVm>
    {
        private readonly IPanasDbContext context;
        public IMapper mapper;

        public GetAllAttendantsQueryHandler(IPanasDbContext context, IMapper mapper)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));;
        }

        public async Task<AttendantListVm> 
            Handle(GetAllAttendantsQuery request, CancellationToken cancellationToken)
        {
            var attendants = await context.Attendants
                .ProjectTo<AttendantVm>(mapper.ConfigurationProvider)
                .ToListAsync();

            return new AttendantListVm(attendants);
        }
    }
}