using Microsoft.AspNetCore.Mvc;
using Starting_Project.Data.Repo;
using Starting_Project.DTOs;
using Starting_Project.Models;

namespace Starting_Project.APIs
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class ProgramController : ControllerBase
    {
        private readonly IProgramDetailsRepository _programDetailsRepository;

        public ProgramController(IProgramDetailsRepository programDetailsRepository)
        {
            _programDetailsRepository = programDetailsRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProgramDetails([FromBody] ProgramDetailsDto programDetailsModel)
        {
            var model = convertDto(programDetailsModel);
            await _programDetailsRepository.CreateProgramAsync(model);
            await _programDetailsRepository.SaveChangesAsync();

            return Ok(model);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProgramDetails([FromBody] ProgramDetailsDto programDetailsModel, string Id)
        {
            var model = convertDto(programDetailsModel);
            await _programDetailsRepository.UpdateProgramAsync(model,Id);
            return Ok(model);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProgramDetails()
        {
            return Ok(await _programDetailsRepository.GetAllProgramsAsync());
        }

        [HttpGet]
        public async Task<IActionResult> GetProgramDetails(string Id)
        {
            return Ok(await _programDetailsRepository.GetProgramForUserAsync(Id));
        }

        private static ProgramDetailsModel convertDto(ProgramDetailsDto dto)
        {
            var model = new ProgramDetailsModel();
            var inof = new AdditionalProgramInfoModel();
            model.ProgramBenefits = dto.ProgramBenefits;
            model.Summary = dto.Summary;
            model.Description = dto.Description;
            model.ProgramTitle = dto.ProgramTitle;
            model.ApplicationCriteria = dto.ApplicationCriteria;
            model.KeySkillsRequired = dto.KeySkillsRequired;
            inof.ProgramStartDate = dto.InfoModel.ProgramStartDate;
            inof.ProgramType = dto.InfoModel.ProgramType;
            inof.ApplicationCloseDate = dto.InfoModel.ApplicationCloseDate;
            inof.ApplicationOpenDate = dto.InfoModel.ApplicationOpenDate;
            inof.Duration = dto.InfoModel.Duration;
            inof.ProgramLocation = dto.InfoModel.ProgramLocation;
            inof.MinQualifications = dto.InfoModel.MinQualifications;
            inof.MaxNumberOfApplications = dto.InfoModel.MaxNumberOfApplications;
            model.InfoModel = inof;
            return model;
        }
    }
}
