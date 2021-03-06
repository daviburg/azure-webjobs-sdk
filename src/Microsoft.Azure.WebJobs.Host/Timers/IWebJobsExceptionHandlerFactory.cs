﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Azure.WebJobs.Host.Timers
{
    public interface IWebJobsExceptionHandlerFactory
    {
        IWebJobsExceptionHandler Create(IHost jobHost);
    }
}
