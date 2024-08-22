﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helpers.Business.ImageHelper
{
    public interface IImageAddHelper
    {
        void AddImage(IFormFile formFile, string guid);
    }
}
