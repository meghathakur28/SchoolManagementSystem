using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAttendanceManagement.Models;

namespace StudentAttendanceManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAttendenceController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<StudentAttendenceDetailsModel> Get()
        {
            var obj1 = new StudentAttendenceDetailsModel() { StudentId = 1, StudentName = "Adam", AttendancePercentage = 88.6};
            var obj2 = new StudentAttendenceDetailsModel() { StudentId = 2, StudentName = "Bran", AttendancePercentage = 96};
            return new List<StudentAttendenceDetailsModel> { obj1, obj2 };
        }
    }
}
