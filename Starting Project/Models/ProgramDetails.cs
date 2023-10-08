using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Starting_Project.Models
{
    public class ProgramDetailsModel
    {
        public string Id { get; set; }

        [Required]
        [JsonProperty("program_title")]
        public string ProgramTitle { get; set; }

        [Required]
        [JsonProperty("summary")]
        public string Summary { get; set; }

        [Required]
        [JsonProperty("description")]
        public string Description { get; set; }

        [Required]
        [JsonProperty("key_skills_required")]
        public KeySkillsRequiredEnum KeySkillsRequired { get; set; }

        [Required]
        [JsonProperty("program_benefits")]
        public string ProgramBenefits { get; set; }

        [Required]
        [JsonProperty("application_criteria")]
        public string ApplicationCriteria { get; set; }

        [Required]
        [JsonProperty("info_model")]
        public AdditionalProgramInfoModel InfoModel { get; set; }
    }
    public enum KeySkillsRequiredEnum
    {
        C,
        EFCore,
        MVC
    }
    public class AdditionalProgramInfoModel
    {
        [Required]
        [JsonProperty("program_type")]
        public ProgramTypeEnum ProgramType { get; set; }

        [Required]
        [JsonProperty("program_start_date")]
        public DateTime ProgramStartDate { get; set; }

        [Required]
        [JsonProperty("application_open_date")]
        public DateTime ApplicationOpenDate { get; set; }

        [Required]
        [JsonProperty("application_close_date")]
        public DateTime ApplicationCloseDate { get; set; }

        [Required]
        [JsonProperty("duration")]
        public string Duration { get; set; }

        [Required]
        [JsonProperty("program_location")]
        public string ProgramLocation { get; set; }

        [Required]
        [JsonProperty("min_qualifications")]
        public MinQualificationEnum MinQualifications { get; set; }

        [Required]
        [JsonProperty("max_number_of_applications")]
        public int MaxNumberOfApplications { get; set; }
    }
    public enum ProgramTypeEnum
    {
        Internship,
        Job,
        Training,
        Course,
        LiveSeminar,
        Other
    }

    public enum MinQualificationEnum
    {
        HighSchool,
        College,
        University,
        Masters,
        PhD
    }
}
