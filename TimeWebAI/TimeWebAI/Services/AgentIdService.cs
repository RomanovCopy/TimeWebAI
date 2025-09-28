using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeWebAI.Interfaces;

namespace TimeWebAI.Services
{
    public class AgentIdService: IAgentIdService
    {
        public string GetSavedAgentId()
        {
            return Properties.Settings.Default.AgentId;
        }

        public void SaveAgentId(string agentId)
        {
            Properties.Settings.Default.AgentId = agentId;
            Properties.Settings.Default.Save();
        }
    }
}
