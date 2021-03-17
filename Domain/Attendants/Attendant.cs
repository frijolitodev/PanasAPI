using System.Collections.Generic;
using Domain.BaseIdentities;
using Domain.Inscriptions;

namespace Domain.Attendants
{
    public class Attendant : BaseIdentity
    {
        public virtual ICollection<Inscription> Inscriptions { get; set; }
    }
}