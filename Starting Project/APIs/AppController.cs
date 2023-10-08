using Microsoft.AspNetCore.Mvc;
using Starting_Project.Data.Repo;
using Starting_Project.DTOs;
using Starting_Project.Models;

namespace Starting_Project.APIs
{
    public class AppController : ControllerBase
    {
        private readonly IAppFormRepository _appFormRepository;

        public AppController(IAppFormRepository appFormRepository)
        {
            _appFormRepository = appFormRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateFormDetails([FromBody] ApplicationFormDto programDetailsModel)
        {
            var model = convertDto(programDetailsModel);
            await _appFormRepository.CreateFormDetails(model);
            await _appFormRepository.SaveChangesAsync();

            return Ok(model);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFormDetails([FromBody] ApplicationFormDto programDetailsModel, string Id)
        {
            var model = convertDto(programDetailsModel);
            await _appFormRepository.UpdateFormAsync(model, Id);
            return Ok(model);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllFormDetails()
        {
            return Ok(await _appFormRepository.GetAllFormsAsync());
        }

        [HttpGet]
        public async Task<IActionResult> GetFormDetails(string Id)
        {
            return Ok(await _appFormRepository.GetFormForUserAsync(Id));
        }

        private static ApplicationForm convertDto(ApplicationFormDto dto)
        {
            var model = new ApplicationForm();
            model.Id = Guid.NewGuid().ToString();
            model.ProgramId = dto.ProgramId;
            model.CoverImageUrl = dto.CoverImageUrl;
            model.PersonalInformation.IdNumber = dto.PersonalInformation.IdNumber;
            model.PersonalInformation.FirstName = dto.PersonalInformation.FirstName;
            model.PersonalInformation.Email = dto.PersonalInformation.Email;
            model.PersonalInformation.LastName = dto.PersonalInformation.LastName;
            model.PersonalInformation.PhoneNumber = dto.PersonalInformation.PhoneNumber;
            model.PersonalInformation.Nationality = dto.PersonalInformation.Nationality;
            model.PersonalInformation.CurrentResidence = dto.PersonalInformation.CurrentResidence;
            model.PersonalInformation.DateOfBirth = dto.PersonalInformation.DateOfBirth;
            model.PersonalInformation.Gender = dto.PersonalInformation.Gender;
            if (dto.PersonalInformation.AdditionalQuestions.paragraph != null)
            {
                foreach(var p in dto.PersonalInformation.AdditionalQuestions.paragraph)
                {
                    model.PersonalInformation.AdditionalQuestions.paragraph.Add(p);
                }
            }
            if (dto.PersonalInformation.AdditionalQuestions.multipleChoice != null)
            {
                foreach (var p in dto.PersonalInformation.AdditionalQuestions.multipleChoice)
                {
                    model.PersonalInformation.AdditionalQuestions.multipleChoice.Add(p);
                }
            }
            if (dto.PersonalInformation.AdditionalQuestions.dropdown != null)
            {
                foreach (var p in dto.PersonalInformation.AdditionalQuestions.dropdown)
                {
                    model.PersonalInformation.AdditionalQuestions.dropdown.Add(p);
                }
            }
            if (dto.PersonalInformation.AdditionalQuestions.yesNo != null)
            {
                foreach (var p in dto.PersonalInformation.AdditionalQuestions.yesNo)
                {
                    model.PersonalInformation.AdditionalQuestions.yesNo.Add(p);
                }
            }
            return model;
        }
    }
}
