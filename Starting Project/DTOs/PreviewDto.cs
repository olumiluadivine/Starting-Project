using Starting_Project.Models;

namespace Starting_Project.DTOs
{
    public class PreviewReqDto
    {
        public string ProgramId { get; set; }
    }

    public class PreviewResDto
    {
        public ProgramDetailsModel Details { get; set; }
        public ApplicationForm ApplicationForm { get; set; }
        public Workflow Workflow { get; set; }
    }
}
