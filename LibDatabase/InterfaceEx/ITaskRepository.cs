using LibDatabase.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDatabase.InterfaceEx
{
    public interface ITaskRepository
    {
        IEnumerable<TaskModel> TasksAll();
    }
}
