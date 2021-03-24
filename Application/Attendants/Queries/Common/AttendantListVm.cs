using System;
using System.Collections;
using System.Collections.Generic;

namespace Application.Attendants.Queries.Common
{
    public class AttendantListVm
    {
        public IList<AttendantVm> Attendants { get; set; }
        
        public int Size => Attendants.Count;

        public AttendantListVm(IList<AttendantVm> attendants)
        {
            Attendants = attendants ?? throw new ArgumentNullException(nameof(attendants));
        }
    }
}