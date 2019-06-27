using CleanArch.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Core.Bus
{
    public interface MediatorHandler
    {
        Task SendCommand<T>(T Comand) where T : Command;
    }
}
