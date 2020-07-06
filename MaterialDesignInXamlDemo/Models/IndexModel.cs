using System.Collections.ObjectModel;

namespace MaterialDesignInXamlDemo
{
    public class IndexModel
    {
        public IndexModel()
        {
            childindex = new ObservableCollection<IndexModel>();
        }

        public string header { get; set; }

        public string content { get; set; }

        public ObservableCollection<IndexModel> childindex { get; set; }

    }
}
