using Starting_Project.Models;

namespace Starting_Project.DTOs
{
    public class ApplicationFormDto
    {
        public string CoverImageUrl { get; set; }
        public string ProgramId { get; set; }
        public PersonalInformationModelDto PersonalInformation { get; set; }
        public ProfileModelDto Profile { get; set; }
    }

    public class PersonalInformationModelDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Nationality { get; set; }
        public string CurrentResidence { get; set; }
        public string IdNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public AdditionalQuestions AdditionalQuestions { get; set; }
    }

    public class AdditionalQuestionsDto
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

    public class MultipleChoiceDto
    {
        public int Id { get; set; }
        public bool EnableOtherOptions { get; set; }
        public List<ChoiceDto> Choices { get; set; }
        public int MaxChoiceAllowed { get; set; }
    }

    public class ChoiceDto
    {
        public int MultipleChoiceId { get; set; }
        public string ChoiceQ { get; set; }
    }

    public class DropdownDto
    {
        public string Question { get; set; }
        public bool EnableOtherOptions { get; set; }
        public List<ChoiceDto> Choices { get; set; }
    }

    public class YesNoDto
    {
        public string Question { get; set; }
    }

    public class ShortAnswerDto
    {
    }

    public class ParagraphDto
    {
        public string Question { get; set; }
    }

    public class ProfileModelDto
    {
        public List<EducationModelDto> Education { get; set; }
        public List<ExperienceModelDto> Experience { get; set; }
    }

    public class EducationModelDto
    {
        public string School { get; set; }
        public string Degree { get; set; }
        public string Course { get; set; }
        public string LocationOfStudy { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool CurrentlyStudyingThere { get; set; }
    }

    public class ExperienceModelDto
    {
        public string Company { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool CurrentlyWorkingThere { get; set; }
    }
}
