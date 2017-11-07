using System.Collections.Generic;

namespace QQInfoAppDoi
{
    public class Assignment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public List<AssignmentTask> TasksInAssignment { get; set; }
    }
}