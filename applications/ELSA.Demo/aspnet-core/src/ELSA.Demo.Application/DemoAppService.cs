﻿using System;
using System.Collections.Generic;
using System.Text;
using ELSA.Demo.Localization;
using Volo.Abp.Application.Services;

namespace ELSA.Demo
{
    /* Inherit your application services from this class.
     */
    public abstract class DemoAppService : ApplicationService
    {
        protected DemoAppService()
        {
            LocalizationResource = typeof(DemoResource);
        }
    }
}
