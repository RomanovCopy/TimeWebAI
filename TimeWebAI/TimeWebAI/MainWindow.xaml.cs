using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.Wpf;

using System;
using System.IO;
using System.Windows;

namespace TimeWebAI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string? AgentId;

        public MainWindow()
        {
            InitializeComponent();

            // Загружаем сохранённый agentId, если есть
            string savedAgentId = Properties.Settings.Default.AgentId;
            bool showDialog = string.IsNullOrWhiteSpace(savedAgentId);
            //string htmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "widget.html");


            if(showDialog)
            {
                var dialog = new AgentIdDialog();
                bool? result = dialog.ShowDialog();
                if(result == true)
                {
                    AgentId = dialog.AgentId;

                    if(dialog.SaveAgentId)
                    {
                        Properties.Settings.Default.AgentId = AgentId;
                        Properties.Settings.Default.Save();
                    }
                } else
                {
                    // Отмена — закрываем приложение
                    Application.Current.Shutdown();
                    return;
                }
            } else
            {
                //string htmlContent = File.ReadAllText(htmlPath);
                //string str=Path.Combine( "const agentId =", AgentId ) ;
                //htmlContent = htmlContent.Replace("const agentId = window.AgentId || 'default-id';",
                //                      $"const agentId = {AgentId};");


                AgentId = savedAgentId;
            }


            InitializeWebView();
        }

        private void InitializeWebView()
        {
            // Загружаем HTML из ресурсов на диск и получаем его адрес
            string path = ExtractHtmlResourceToTemp("TimeWebAI.widget.html");

            webView.Source = new Uri(path);
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
            string html=LoadHtmlFromResource(resourceFullName);
            //вставляем Id
            html = html.Replace("const agentId = window.agentId || 'default-id';",
                    $"const agentId = '{AgentId}';");

            //получаем адрес для сохранения файла
            string tempPath = Path.Combine(Path.GetTempPath(), "widget.html");
            //сохраняем файл
            File.WriteAllText(tempPath, html);
            return tempPath;
        }



    }
}