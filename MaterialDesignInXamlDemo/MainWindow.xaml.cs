using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MaterialDesignInXamlDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        /// <summary>
        /// 索引列表
        /// </summary>
        public ObservableCollection<IndexModel> IndexList { get; set; } = new ObservableCollection<IndexModel>();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            IndexList.Add(new IndexModel { header = "Michael", content = "12332111" });
            IndexList.Add(new IndexModel { header = "Jack", content = "12332111" });
            IndexList.Add(new IndexModel { header = "Marry", content = "12332111" });
            IndexList.Add(new IndexModel
            {
                header = "Nick",
                content = "12332111",
                childindex = new ObservableCollection<IndexModel>
                {
                    new IndexModel{  header="Mike",content="temp" },
                    new IndexModel{  header="Mark",content="datess" },
                    new IndexModel{  header="Furry",content="Nsssk" }
                }
            });
            IndexList.Add(new IndexModel
            {
                header = "Nick2",
                content = "12332111",
                childindex = new ObservableCollection<IndexModel>
                {
                    new IndexModel{  header="Furry",content="Nsssk" },
                    new IndexModel{  header="Mark",content="datess" },
                    new IndexModel{  header="Mike",content="temp" },
                }
            });
            //tvDemo.Items.Add();

        }

        Stopwatch sw = new Stopwatch();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*
            sw.Start();
            for (int i = 0; i < 200; i++)
            {
                BorderStackList.Children.Add(new Border() { Background = new SolidColorBrush(Colors.Red), Width = 10, Height = 10 });
            }
            sw.Stop();
            System.Console.WriteLine($"执行用了 {sw.ElapsedMilliseconds} ms");
            */
        }
    }
}
