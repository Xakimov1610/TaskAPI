using System;
using System.ComponentModel.DataAnnotations;

namespace tasks.Model
{
    public class NewTask
    {
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

    }
}