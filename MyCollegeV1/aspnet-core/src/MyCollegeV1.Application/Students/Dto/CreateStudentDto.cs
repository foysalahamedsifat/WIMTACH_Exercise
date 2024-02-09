using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MyCollegeV1.Models;

namespace MyCollegeV1.Students.Dto
{
    [AutoMapTo(typeof(Student))]
    public class CreateStudentDto
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ProgramName { get; set; }
        public string DoB { get; set; }
        public bool IsActive { get; set; }
        public int CollegeId { get; set; }

        ///CreateDto.cs.fields1///

    }
}
