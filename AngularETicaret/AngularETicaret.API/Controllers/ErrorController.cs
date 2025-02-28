﻿using AngularETicaret.API.Errors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularETicaret.API.Controllers
{
    [Route("error/{code}")]
  [ApiExplorerSettings(IgnoreApi =true)]//bunu swaggerda gösterme diyorum
    public class ErrorController : BaseApiController
    {
        public IActionResult Index(int code)
        {
            return new ObjectResult(new ApiResponse(code));
        }
    }
}
