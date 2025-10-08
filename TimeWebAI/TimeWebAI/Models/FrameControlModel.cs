using Autofac;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

using TimeWebAI.Infrastructure;
using TimeWebAI.Interfaces;
using TimeWebAI.Pages;

namespace TimeWebAI.Models
{
    internal class FrameControlModel: ViewModelBase, IFrameControlModel
    {
        private readonly IPageFactory pageFactory;
        public Page? CurrentPage { get => currentPage; private set => SetProperty(ref currentPage, value); }
        Page? currentPage;

        public ObservableCollection<Page?>? Pages { get => pages; private set => SetProperty(ref pages, value); }
        ObservableCollection<Page?>? pages;

        public FrameControlModel(IPageFactory pageFactory)
        {
            this.pageFactory = pageFactory;
            Pages = [];
            LoadPages();
        }


        public bool CanExecute_NavigateTo(object? obj)
        {
            if(obj is Page page && Pages?.Contains(page) == true && !page.Equals(CurrentPage))
            {
                return true;
            }
            return true;
        }
        public void Execute_NavigateTo(object? obj)
        {
            if(obj is Page page)
            {
                CurrentPage = page;
            }
        }




        public bool CanExecute_Loaded(object? obj)
        {
            return true;
        }
        public void Execute_Loaded(object? obj)
        {
            CurrentPage = Pages?.FirstOrDefault();
        }

        public bool CanExecute_Close(object? obj)
        {
            return true;
        }
        public void Execute_Close(object? obj)
        {

        }

        public bool CanExecute_Closing(object? obj)
        {
            return true;
        }
        public void Execute_Closing(object? obj)
        {

        }

        public bool CanExecute_Closed(object? obj)
        {
            return true;
        }
        public void Execute_Closed(object? obj)
        {
        }



        private void LoadPages()
        {
            // Список типов страниц
            var pageTypes = new[] { typeof(WebViewPage) };

            foreach(var type in pageTypes)
            {
                Pages?.Add(pageFactory.CreatePage(type));
            }

        }


    }
}
