using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace Ui
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //var newBtn = new Button();
            //newBtn.Content = "test";
            //newBtn.Name = "button1";
            //newBtn.Height = 23;
            //grid.Children.Add(newBtn);
            //newBtn.Click += new RoutedEventHandler(button1_Click);
            int test = 13;
            Debug.WriteLine($"test {test:X2}");
            Canvas.SetTop(button1, 1);
        }
    }
}