using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeWebAI.Interfaces
{
    public interface IAgentIdService
    {
        string GetSavedAgentId();
        void SaveAgentId(string agentId);
    }
}
