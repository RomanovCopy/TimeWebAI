using Microsoft.Web.WebView2.Wpf;
using Microsoft.Web.WebView2.Core;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeWebAI.Interfaces;
using System.IO;
using System.Windows;

namespace TimeWebAI.Services
{
    public class WebViewService:WebView2, IWebViewService
    {
        public string? AgentId
        {
            get => _agentId;
            set
            {
                _agentId = value;
                if(_isInitialized)
                    _ = SetAgentIdAsync(_agentId);
            }
        }
        private string? _agentId;


        private bool _isInitialized = false;

        public WebViewService()
        {
            this.CoreWebView2InitializationCompleted += async (s, e) =>
            {
                _isInitialized = true;
                if(!string.IsNullOrEmpty(_agentId))
                    await SetAgentIdAsync(_agentId);
            };
        }

        private async Task SetAgentIdAsync(string? agentId)
        {
            try
            {
                await this.ExecuteScriptAsync($"window.agentId = '{agentId}';");
            } catch(Exception ex)
            {
                MessageBox.Show($"Ошибка передачи AgentId: {ex.Message}");
            }
        }

        public async Task LoadWidgetAsync()
        {
            try
            {
                await EnsureCoreWebView2Async();

                string htmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "widget.html");
                if(!File.Exists(htmlPath))
                {
                    MessageBox.Show("Файл widget.html не найден!");
                    return;
                }

                this.Source = new Uri(htmlPath);
            } catch(Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки виджета: {ex.Message}");
            }
        }
    }
}
