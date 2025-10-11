﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeWebAI.Interfaces
{
    public interface ITitleBarTimeWebAIControlModel: IModel
    {
        bool IsAgent {  get; }
        bool CanExecute_NewAgent(object? obj);
        void Execute_NewAgent(object? obj);
    }
}
