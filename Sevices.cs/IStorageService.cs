using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Task.Entities;

namespace Task.Services
{
    public interface IStorageService
    {
        Task<(bool IsSuccess, Exception exception)> InsertTaskAsync(Task.Entities.Task task);

        Task<List<Task.Entities.Task>> GetTasksAsync(
            Guid id = default(Guid),
            string title = default(string),
            string description = default(string),
            string tags = default(string),
            Task.Entities.ETaskPriority? priority = null,
            Task.Entities.ETaskRepeat? repeat= null,
            Task.Entities.ETaskStatus? status = null,
            DateTimeOffset onADay = default(DateTimeOffset),
            DateTimeOffset atATime = default(DateTimeOffset),
            string location = default(string),
            string url = default(string));

        Task<(bool isSuccess, Exception exception)> UpdateTaskAsync(Entities.Task task);

        Task<(bool isSuccess, Exception exception)> DelateTaskAsync(Guid id);
    }
}