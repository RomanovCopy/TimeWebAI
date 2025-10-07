using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TimeWebAI.Interfaces
{
    public interface IFrameControlModel:IModel
    {
        /// <summary>
        /// текущая отображаемая страница
        /// </summary>
        Page? CurrentPage{ get; }
        /// <summary>
        /// коллекция доступных для отображения страниц
        /// </summary>
        ObservableCollection<Page?>? Pages { get; }

        /// <summary>
        /// выбор страницы для отображения
        /// </summary>
        /// <param name="obj">выбранная страница</param>
        /// <returns>разрешение на установку страницы текущей</returns>
        bool CanExecute_NavigateTo(object? obj);
        /// <summary>
        /// установка страницы текущей
        /// </summary>
        /// <param name="obj">устанавливаемая страница</param>
        void Execute_NavigateTo(object? obj);
    }
}
