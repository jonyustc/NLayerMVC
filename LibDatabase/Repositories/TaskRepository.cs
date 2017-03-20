using LibDatabase.DatabaseContext;
using LibDatabase.InterfaceEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDatabase.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly MLA_DBEntities _context;

        public TaskRepository(MLA_DBEntities context)
        {
            _context = context;
        }

        public IEnumerable<TaskModel> TasksAll()
        {
            return _context.TaskModels;
        }
    }
}
