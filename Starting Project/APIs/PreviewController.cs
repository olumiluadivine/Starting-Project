using Microsoft.AspNetCore.Mvc;
using Starting_Project.Data.Repo;
using Starting_Project.DTOs;

namespace Starting_Project.APIs
{
    public class PreviewController : ControllerBase
    {
        private readonly IWorkflowRepository _workflowRepository;
        private readonly IAppFormRepository _appFormRepository;
        private readonly IProgramDetailsRepository _programDetailsRepository;

        public PreviewController(IWorkflowRepository workflowRepository, IAppFormRepository appFormRepository, IProgramDetailsRepository programDetailsRepository)
        {
            _workflowRepository = workflowRepository;
            _appFormRepository = appFormRepository;
            _programDetailsRepository = programDetailsRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetPreviewDetails(PreviewReqDto programId)
        {
            var model = new PreviewResDto();
            model.Details = await _programDetailsRepository.GetProgramForUserAsync(programId.ProgramId);
            model.Workflow = await _workflowRepository.GetByProgramId(programId.ProgramId);
            model.ApplicationForm = await _appFormRepository.GetByProgramId(programId.ProgramId);
            return Ok(model);
        }
    }
}
