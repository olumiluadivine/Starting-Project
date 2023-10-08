namespace Starting_Project.Models
{
    public class Workflow
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string ProgramDetailsId { get; set; }
        public string StageName { get; set; }
        public StageType StageType { get; set; }
    }

    public class StageType
    {
        public Shortlisting Shortlisting { get; set; }
        public VideoInterview VideoInterview { get; set; }
        public Placement Placement { get; set; }
    }
    public class Shortlisting
    {

    }
    public class VideoInterview
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
    public class Placement
    {

    }
}
