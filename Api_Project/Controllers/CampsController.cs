using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Project.Controllers
{
    [Route("api/[controller]")]
    public class CampsController : ControllerBase
    {   
      
        public object Get()
        {
            return new { Name = "Ilham", Title = "Book"};
        }
    }
}
