﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeWebAI.Interfaces
{
    public interface IWebViewPageModel:IModel
    {
        bool CanExecute_PageLoaded(object? obj);
        void Execute_PageLoaded(object? obj);

        bool CanExecute_PageClear(object? obj);
        void Execute_PageClear(object? obj);
    }
}
