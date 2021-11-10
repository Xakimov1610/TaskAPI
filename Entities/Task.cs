using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;

namespace Task.Entities
{
    public class Task
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(300)]
        public string Title { get; set; }

        [MaxLength(2000)]
        public string Description { get; set; }

        [MaxLength(1024)]
        public string Tags { get; set; }

        public DateTimeOffset OnADay { get; set; }

        public DateTimeOffset AtATime { get; set; }

        public ETaskStatus Status { get; set; }

        public ETaskPriority Priority { get; set; }

        public ETaskRepeat Repeat { get; set; }

        public string Location { get; set; }

        public string Url { get; set; }

        [Obsolete("Used only for entity binding.", true)]
        public Task() { }

        public Task(string title, string description="", string tags="", DateTimeOffset onADay=default(DateTimeOffset), DateTimeOffset atATime=default(DateTimeOffset),
                ETaskStatus status=ETaskStatus.None, ETaskPriority priority=ETaskPriority.None, ETaskRepeat repeat=ETaskRepeat.Never, string location="", string url="")
        {
            Id = Guid.NewGuid();
            Title = title;
            Description = description;
            Tags = tags;
            OnADay = onADay;
            AtATime = atATime;
            Status = status;
            Priority = priority;
            Repeat = repeat;
            Location = location;
            Url = url;
        }
    }
}