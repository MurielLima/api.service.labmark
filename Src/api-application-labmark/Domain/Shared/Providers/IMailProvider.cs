﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labmark.Domain.Shared.Providers
{
    public interface IMailProvider
    {
        public Task<bool> Execute(string subject, string message, string email);
    }
}
