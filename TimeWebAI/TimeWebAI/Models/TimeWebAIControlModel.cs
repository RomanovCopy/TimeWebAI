﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeWebAI.Infrastructure;
using TimeWebAI.Interfaces;

namespace TimeWebAI.Models
{
    public class TimeWebAIControlModel: ViewModelBase, ITimeWebAIControlModel
    {
        private readonly IWebViewService service;

        private readonly string? AgentId;

        public string Url { get => url ?? string.Empty; set => SetProperty(ref url, value); }
        string? url;

        public TimeWebAIControlModel(IWebViewService service)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));

            this.service.Loaded += Service_Loaded;



            AgentId = Properties.Settings.Default.AgentId;

            bool showDialog = string.IsNullOrWhiteSpace(AgentId);
            service.InitializeAsync();
            string path = ExtractHtmlResourceToTemp("TimeWebAI.Resources.widget.html");
            service.CurrentSource = new Uri(path);

        }

        private void Service_Loaded(object? sender, string e)
        {
            // Загружаем HTML из ресурсов на диск и получаем его адрес
            string path = ExtractHtmlResourceToTemp("TimeWebAI.Resources.widget.html");
            service.CurrentSource = new Uri(path);
        }


        private string LoadHtmlFromResource(string resourceFullName)
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            using var stream = assembly.GetManifestResourceStream(resourceFullName);
            if(stream == null)
                throw new Exception($"Ресурс {resourceFullName} не найден!");
            using var reader = new StreamReader(stream);
            return reader.ReadToEnd();

        }

        private string ExtractHtmlResourceToTemp(string resourceFullName)
        {
            //считываем из ресурсов
            string html = LoadHtmlFromResource(resourceFullName);
            //вставляем Id
            html = html.Replace("const agentId = window.agentId || 'default-id';",
                    $"const agentId = '{AgentId??" "}';");
            //получаем адрес для сохранения файла
            string tempPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "widget.html");
            //сохраняем файл
            File.WriteAllText(tempPath, html);
            return tempPath;
        }





        public bool CanExecute_Loaded(object? obj)
        {
            return true;
        }
        public void Execute_Loaded(object? obj)
        {
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

    }
}
