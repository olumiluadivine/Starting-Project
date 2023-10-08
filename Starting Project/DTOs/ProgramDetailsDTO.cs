using Starting_Project.Models;

namespace Starting_Project.DTOs
{
    public class ProgramDetailsDto
    {
        public string ProgramTitle { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public KeySkillsRequiredEnum KeySkillsRequired { get; set; }
        public string ProgramBenefits { get; set; }
        public string ApplicationCriteria { get; set; }
        public AdditionalProgramInfoDto InfoModel { get; set; }
    }

    public class AdditionalProgramInfoDto
    {
        public ProgramTypeEnum ProgramType { get; set; }
        public DateTime ProgramStartDate { get; set; }
        public DateTime ApplicationOpenDate { get; set; }
        public DateTime ApplicationCloseDate { get; set; }
        public string Duration { get; set; }
        public string ProgramLocation { get; set; }
        public MinQualificationEnum MinQualifications { get; set; }
        public int MaxNumberOfApplications { get; set; }
    }
}
