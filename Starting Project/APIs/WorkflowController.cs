using Microsoft.AspNetCore.Mvc;
using Starting_Project.Data.Repo;
using Starting_Project.DTOs;
using Starting_Project.Models;

namespace Starting_Project.APIs
{
    public class WorkflowController : ControllerBase
    {
        private readonly IWorkflowRepository _workflowRepository;

        public WorkflowController(IWorkflowRepository workflowRepository)
        {
            _workflowRepository = workflowRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateFormDetails([FromBody] WorkflowDto workflow)
        {
            var model = convertDto(workflow);
            await _workflowRepository.CreateWorkflow(model);
            await _workflowRepository.SaveChangesAsync();

            return Ok(model);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFormDetails([FromBody] WorkflowDto workflow, string Id)
        {
            var model = convertDto(workflow);
            await _workflowRepository.UpdateWorkflow(model, Id);
            return Ok(model);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllFormDetails()
        {
            return Ok(await _workflowRepository.GetAllWorkflowAsync());
        }

        [HttpGet]
        public async Task<IActionResult> GetFormDetails(string Id)
        {
            return Ok(await _workflowRepository.GetWorkflowAsync(Id));
        }

        private static Workflow convertDto(WorkflowDto dto)
        {
            var workflow = new Workflow();
            var videoInt = new VideoInterview();
            var stageT = new StageType();
            workflow.ProgramDetailsId = dto.ProgramDetailsId;
            workflow.StageName = dto.StageName;
            videoInt.VideoUrl = dto.StageType.VideoInterview.VideoUrl;
            videoInt.Question = dto.StageType.VideoInterview.Question;
            videoInt.AdditionalInfo = dto.StageType.VideoInterview.AdditionalInfo;
            videoInt.MaxDuration = dto.StageType.VideoInterview.MaxDuration;
            videoInt.Deadline = dto.StageType.VideoInterview.Deadline;
            videoInt.Timee = dto.StageType.VideoInterview.Timee;
            stageT.VideoInterview = videoInt;
            workflow.StageType = stageT;
            return workflow;
        }
    }
}
