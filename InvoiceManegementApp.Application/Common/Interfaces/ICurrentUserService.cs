using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceManegementApp.Application.Common.Interfaces
{
    public interface ICurrentUserService
    {
        string UserId { get; }
    }
}
