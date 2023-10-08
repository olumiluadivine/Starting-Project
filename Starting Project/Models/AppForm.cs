using System.ComponentModel.DataAnnotations;

namespace Starting_Project.Models
{
    public class ApplicationForm
    {
        [Key]
        public string Id { get; set; }

        public string ProgramId { get; set; }

        public string CoverImageUrl { get; set; }

        public PersonalInformationModel PersonalInformation { get; set; }

        public ProfileModel Profile { get; set; }
    }

    public class PersonalInformationModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Nationality { get; set; }

        [Required]
        public string CurrentResidence { get; set; }

        [Required]
        public string IdNumber { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Gender { get; set; }

        public AdditionalQuestions AdditionalQuestions { get; set; }
    }

    public class AdditionalQuestions
    {
        public List<Paragraph>? paragraph { get; set; } = new List<Paragraph>();

        public List<ShortAnswer>? shortAnswer { get; set; } = new List<ShortAnswer>();

        public List<YesNo>? yesNo { get; set; } = new List<YesNo>();

        public List<Dropdown>? dropdown { get; set; } = new List<Dropdown>();

        public List<MultipleChoice>? multipleChoice { get; set; } = new List<MultipleChoice>();

        public List<Datee>? date { get; set; } = new List<Datee>();

        public List<Numberr>? number { get; set; } = new List<Numberr>();

        public List<FileUpload>? fileUpload { get; set; } = new List<FileUpload>();
    }

    public class FileUpload
    {
    }

    public class Numberr
    {
    }

    public class Datee
    {
    }

    public class MultipleChoice
    {
        public bool EnableOtherOptions { get; set; }

        public List<Choice> Choices { get; set; }

        public int MaxChoiceAllowed { get; set; }
    }

    public class Choice
    {
        public string ChoiceQ { get; set; } = string.Empty;
    }

    public class Dropdown
    {
        public string Question { get; set; }

        public bool EnableOtherOptions { get; set; }

        public List<Choice> Choices { get; set; }
    }

    public class YesNo
    {
        public string Question { get; set; }
    }

    public class ShortAnswer
    {
    }

    public class Paragraph
    {
        public string Question { get; set; }
    }

    public class ProfileModel
    {
        public List<EducationModel> Education { get; set; }

        public List<ExperienceModel> Experience { get; set; }
    }

    public class EducationModel
    {
        [Required]
        public string School { get; set; }

        [Required]
        public string Degree { get; set; }

        [Required]
        public string Course { get; set; }

        [Required]
        public string LocationOfStudy { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public bool CurrentlyStudyingThere { get; set; }
    }

    public class ExperienceModel
    {
        [Required]
        public string Company { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public bool CurrentlyWorkingThere { get; set; }
    }
}
