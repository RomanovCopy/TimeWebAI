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
            string htmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "widget.html");


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

            InitializeWebView(htmlPath);
        }

        private async void InitializeWebView(string htmlPath)
        {
            var env = await CoreWebView2Environment.CreateAsync();
            await webView.EnsureCoreWebView2Async(env);

            // Передаем agentId в JS
            await webView.ExecuteScriptAsync($"window.agentId = '{AgentId}';");

            // Загружаем HTML
            if(!File.Exists(htmlPath))
            {
                MessageBox.Show("Файл widget.html не найден!");
                Application.Current.Shutdown();
                return;
            }
            webView.Source = new Uri(htmlPath);
        }
    }
}