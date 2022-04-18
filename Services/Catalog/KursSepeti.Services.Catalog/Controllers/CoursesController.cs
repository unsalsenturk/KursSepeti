using KursSepeti.Services.Catalog.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursSepeti.Services.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    internal class CoursesController : ControllerBase
    {
        private readonly ICourseService _courseService;

        internal CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

    }
}
