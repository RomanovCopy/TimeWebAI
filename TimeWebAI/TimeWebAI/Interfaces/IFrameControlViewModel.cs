using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

using TimeWebAI.Infrastructure;

namespace TimeWebAI.Interfaces
{
    public interface IFrameControlViewModel:IViewModel
    {
        /// <summary>
        /// текущая отображаемая страница
        /// </summary>
        Page? CurrentPage {  get; }
        /// <summary>
        /// коллекция доступных страниц для отображения
        /// </summary>
        ObservableCollection<Page?>? Pages {  get; }
        /// <summary>
        /// команда выбора текущей страницы
        /// </summary>
        ICommand NavigateTo {  get; }

    }
}
