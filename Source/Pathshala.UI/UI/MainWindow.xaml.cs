using System;
using System.Windows;
using Pathshala.Main.Model;

namespace Pathshala.Main.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var model = new MainModel();
            model.Status = "Ready";
            model.Title = "Pathshala";
            model.ProductVersion = "Pathshala 1.0.0.0";
            this.DataContext = model;
            
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.Owner = this;
            login.ShowDialog();
        }
    }
}
