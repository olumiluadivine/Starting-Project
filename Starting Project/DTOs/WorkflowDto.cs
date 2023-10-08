using Starting_Project.Models;

namespace Starting_Project.DTOs
{
    public class WorkflowDto
    {
        public string StageName { get; set; }
        public string ProgramDetailsId { get; set; }
        public StageType StageType { get; set; }
    }
    public class StageTypeDto
    {
        public Shortlisting Shortlisting { get; set; }
        public VideoInterview VideoInterview { get; set; }
        public Placement Placement { get; set; }
    }
    public class VideoInterviewDto
    {
        public string VideoUrl { get; set; }
        public string Question { get; set; }
        public string AdditionalInfo { get; set; }
        public int MaxDuration { get; set; }
        public Timee Timee { get; set; }
        public int Deadline { get; set; }
    }
    public enum Timee
    {
        Min,
        Sec
    }
}
