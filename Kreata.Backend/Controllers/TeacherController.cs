using Kreata.Backend.Repos;
using Kreta.Shared.Dtos;
using Kreta.Shared.Extensions;
using Kreta.Shared.Models;
using Kreta.Shared.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController : ControllerBase
    {
        private ITeacherRepo? _teacherRepo;
        public TeacherController(ITeacherRepo? teacherRepo)
        {
            _teacherRepo = teacherRepo ?? throw new ArgumentNullException(nameof(teacherRepo));
        }
        public TeacherController()
        {
            
        }
    }
}
