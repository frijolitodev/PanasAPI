using Domain.BaseIdentities;
using Domain.Presentations;

namespace Domain.Speakers
{
    public class Speaker : BaseIdentity
    {
        public virtual Presentation Presentation { get; set; }
    }
}