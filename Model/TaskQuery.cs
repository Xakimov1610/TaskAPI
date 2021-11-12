using System;
using Microsoft.AspNetCore.Mvc;

namespace Task.Model
{
    public class TaskQuery
    {
        [FromQuery]
        public string Title { get; set; }
        [FromQuery]
        public Guid Id { get; set; }
        [FromQuery]
        public string Priority { get; set; }
        [FromQuery]
        public string Status { get; set; }
    }
}