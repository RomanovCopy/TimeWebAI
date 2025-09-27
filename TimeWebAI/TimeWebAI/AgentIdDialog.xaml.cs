using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TimeWebAI
{
    /// <summary>
    /// Логика взаимодействия для AgentIdDialog.xaml
    /// </summary>
    public partial class AgentIdDialog: Window
    {
        public string? AgentId { get; private set; }
        public bool SaveAgentId { get; private set; }

        public AgentIdDialog(string defaultAgentId = "")
        {
            InitializeComponent();
            AgentIdTextBox.Text = defaultAgentId;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(AgentIdTextBox.Text))
            {
                MessageBox.Show("Введите корректный Agent ID!");
                return;
            }

            AgentId = AgentIdTextBox.Text.Trim();
            SaveAgentId = SaveCheckBox.IsChecked == true;
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
