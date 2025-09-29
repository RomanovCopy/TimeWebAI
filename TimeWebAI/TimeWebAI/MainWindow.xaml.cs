using Microsoft.Web.WebView2.Core;

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
                AgentId = savedAgentId;
            }

            InitializeWebView();
        }

        private async void InitializeWebView()
        {
            var env = await CoreWebView2Environment.CreateAsync();
            await webView.EnsureCoreWebView2Async(env);

            // Передаем agentId в JS
            await webView.ExecuteScriptAsync($"window.agentId = '{AgentId}';");

            // Загружаем HTML
            //string htmlPath = "pack://application:,,,/widget.html";
            //if(!File.Exists(htmlPath))
            //{
            //    MessageBox.Show("Файл widget.html не найден!");
            //    Application.Current.Shutdown();
            //    return;
            //}
            //webView.Source = new Uri(htmlPath, UriKind.Relative);
            webView.NavigateToString(@"<!DOCTYPE html>
<html lang=""ru"">
<head>
<meta charset=""UTF-8"">
<meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
<title>Timeweb Widget</title>
<style>
html, body { margin:0; padding:0; width:100%; height:100%; overflow:hidden; }
agent-chat-widget { width:100%; height:100%; display:block; }
</style>
</head>
<body>
<script type=""module"">
(function() {
    // Берём agentId из WPF
    const agentId = window.agentId || 'default-id';
    const wsUrl = 'https://chat.timeweb.cloud';
    const isCollapsed = false;

    const script = document.createElement('script');
    script.type = 'module';
    script.src = 'https://st.timeweb.com/cloud-static/cloud-ai/agent-widget/agent-chat-widget.js';

    script.onload = () => {
        const widget = document.createElement('agent-chat-widget');
        widget.setAttribute('agentid', agentId);
        widget.setAttribute('wsurl', wsUrl);
        widget.setAttribute('is-collapsed', isCollapsed);
        document.body.appendChild(widget);

        // Подождём, пока LitElement полностью отрендерится
        setTimeout(() => {
            // Разворачиваем сразу на весь экран
            if (typeof widget._enterFullscreen === 'function') widget._enterFullscreen();

            const shadow = widget.shadowRoot;
            if (shadow) {
                // Разрешаем выделение текста
                const style = document.createElement('style');
                style.textContent = '* { user-select: text !important; }';
                shadow.appendChild(style);

                // Скрываем кнопки разворота и закрытия
                const fullscreenBtn = shadow.querySelector('.fullscreen-btn');
                if (fullscreenBtn) fullscreenBtn.style.display = 'none';
                const closeBtn = shadow.querySelector('.close-btn');
                if (closeBtn) closeBtn.style.display = 'none';

                // MutationObserver для меню
                const observer = new MutationObserver(() => {
                    const menuItems = shadow.querySelectorAll('.menu-popover .menu-item');
                    menuItems.forEach(item => {
                        const textSpan = item.querySelector('.menu-text');
                        if (textSpan && textSpan.textContent.includes('Вернуть вид по умолчанию')) {
                            item.style.display = 'none';
                        }
                    });
                });
                observer.observe(shadow, { childList: true, subtree: true });
            }

            // iframe user-select
            const iframes = widget.querySelectorAll('iframe');
            iframes.forEach(f => {
                try { f.contentDocument.body.style.userSelect = 'text'; } 
                catch(e){ console.warn(e); }
            });

        }, 500);
    };

    document.head.appendChild(script);
})();
</script>
</body>
</html>
");
        }
    }
}