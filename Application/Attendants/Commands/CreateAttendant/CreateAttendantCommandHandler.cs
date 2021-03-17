using System;
using System.Threading;
using System.Threading.Tasks;
using Domain.Attendants;
using Infrastructure;
using MediatR;

namespace Application.Attendants.Commands.CreateAttendant
{
    public class CreateAttendantCommandHandler : IRequestHandler<CreateAttendantCommand>
    {
        private readonly IPanasDbContext Context;

        public CreateAttendantCommandHandler(IPanasDbContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
        }
        
        public async Task<Unit> Handle(CreateAttendantCommand request, CancellationToken cancellationToken)
        {
            var attendant = new Attendant
            {
                FullName = request.FullName,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber
            };

            Context.Attendants.Add(attendant);
            await Context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}