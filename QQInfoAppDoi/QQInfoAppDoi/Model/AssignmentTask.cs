namespace QQInfoAppDoi
{
    public class AssignmentTask
    {
        public int Id { get; set; }
        public int AssignmentId { get; set; }
        public string Name { get; set; }
        public int StartHour { get; set; }
        public int Duration { get; set; }
        public bool IsDone { get; set; }
        public int NumberOfPieces { get; set; }
    }
}