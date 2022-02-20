using System.Windows.Controls;
using ToDoList.Core;
using ToDoList.Core.viewModels.Pages;

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for WorkTaskPage.xaml
    /// </summary> 
    public partial class WorkTaskPage : Page
    {
        public WorkTaskPage()
        {
            InitializeComponent();

            DataContext = new WorkTaskPageViewModel();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
