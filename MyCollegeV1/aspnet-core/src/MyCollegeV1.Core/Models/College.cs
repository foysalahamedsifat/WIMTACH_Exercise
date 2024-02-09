using Abp.Domain.Entities.Auditing;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollegeV1.Models
{
    public class College : FullAuditedEntity<int>, IPassivable
    {
        public College()
        {
            this.IsActive = true;
            this.CreationTime = DateTime.Now;
        }
        public string Name { get; set; }
        public string Address { get; set; }

        public string Description { get; set; }

        public string GPSLatitude { get; set; }
        public string Longitude { get; set; }
        public string ContactEmail { get; set; }
        public bool IsFoysalSleep { get; set; }
        public bool IsActive { get; set; }

    }
}
