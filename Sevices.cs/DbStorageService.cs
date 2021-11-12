using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Task.Entities;
using tasks.Services;

namespace task.Services
{
    public class DbStorageService : IStorageService
    {
        public DbStorageService()
        {
        }

        Task<List<Task.Entities.Task>> IStorageService.GetTasksAsync(Guid id, string title, string description, string tags, ETaskPriority? priority, ETaskRepeat? repeat, ETaskStatus? status, DateTimeOffset onADay, DateTimeOffset atATime, string location, string url)
        {
            throw new NotImplementedException();
        }

        Task<(bool IsSuccess, Exception exception)> IStorageService.InsertTaskAsync(Task.Entities.Task task)
        {
            throw new NotImplementedException();
        }
    }
}