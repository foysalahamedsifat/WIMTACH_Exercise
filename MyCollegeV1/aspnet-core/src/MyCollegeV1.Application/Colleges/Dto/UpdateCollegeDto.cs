using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MyCollegeV1.Models;

namespace MyCollegeV1.Colleges.Dto
{
    [AutoMapTo(typeof(College))]
    public class UpdateCollegeDto : EntityDto<int>
    {
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

