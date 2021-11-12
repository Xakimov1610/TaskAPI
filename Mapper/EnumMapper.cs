using Task.Entities;
namespace Task.Mapper
{
    public static class EnumMappers
    {
        public static Task.Entities.ETaskPriority ToEntityETaskPriority(this Model.ETaskPriority? priority)
        {
            return priority switch
            {
                Model.ETaskPriority.High => Task.Entities.ETaskPriority.High,
                Model.ETaskPriority.Mid => Task.Entities.ETaskPriority.Mid,
                Model.ETaskPriority.Low => Task.Entities.ETaskPriority.Low,
                _ => Task.Entities.ETaskPriority.None,
            };
        }

        public static Task.Entities.ETaskStatus ToEntityETaskStatus(this Model.ETaskStatus? status)
        {
            return status switch
            {
                Model.ETaskStatus.Completed => Task.Entities.ETaskStatus.Completed,
                Model.ETaskStatus.InProgress => Task.Entities.ETaskStatus.InProgress,
                Model.ETaskStatus.Postponed => Task.Entities.ETaskStatus.Postponed,
                _ => Task.Entities.ETaskStatus.None,
            };
        }

        public static Task.Entities.ETaskRepeat ToEntityETaskRepeat(this Model.ETaskRepeat? repeat)
        {
            return repeat switch
            {
                Model.ETaskRepeat.Daily => Task.Entities.ETaskRepeat.Daily,
                Model.ETaskRepeat.Hourly => Task.Entities.ETaskRepeat.Hourly,
                Model.ETaskRepeat.Monthly => Task.Entities.ETaskRepeat.Monthly,
                Model.ETaskRepeat.Weekly => Task.Entities.ETaskRepeat.Weekly,
                Model.ETaskRepeat.Yearly => Task.Entities.ETaskRepeat.Yearly,
                _ => Task.Entities.ETaskRepeat.Never
            };
        }
    }
}