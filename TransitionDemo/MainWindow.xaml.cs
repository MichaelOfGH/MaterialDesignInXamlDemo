using System.Windows;

namespace TransitionDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentTransitioner.SelectedIndex + 1 == CurrentTransitioner.Items.Count)
            {
                CurrentTransitioner.SelectedIndex = 0;
            }
            else
            {
                CurrentTransitioner.SelectedIndex += 1;
            }
        }
    }
}
