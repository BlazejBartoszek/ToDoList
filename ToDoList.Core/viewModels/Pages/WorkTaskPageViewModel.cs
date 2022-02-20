using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDoList.Core.Helpers;
using ToDoList.Core.viewModels.Control;

namespace ToDoList.Core.viewModels.Pages
{
   public class WorkTaskPageViewModel
    {
        public ObservableCollection<WorkTaskViewModel> WorkTaskList { get; set; } = new ObservableCollection<WorkTaskViewModel>();

        public string NewWorkTaskTitle { get; set; }
        public string NewWorkTaskDescriptopn { get; set; }

        public ICommand AddNewTaskCOmmand { get; set; }
        public WorkTaskPageViewModel()
        {
            AddNewTaskCOmmand = new RelayCommand(AddNewTask);
        }
        private void AddNewTask()
        {
            var newTask = new WorkTaskViewModel
            {
                Title = NewWorkTaskTitle,
                Description = NewWorkTaskDescriptopn,
                CreatedDate = DateTime.Now
            };

            WorkTaskList.Add(newTask); 
        }
    }
}
