using Starting_Project.Models;

namespace Starting_Project.Data.Repo
{
    public interface IWorkflowRepository
    {
        Task<Workflow> GetWorkflowAsync(string Id);
        Task<Workflow> GetByProgramId(string Id);
        Task<IEnumerable<Workflow>> GetAllWorkflowAsync();
        Task<Workflow> UpdateWorkflow(Workflow form, string Id);
        Task<Workflow> CreateWorkflow(Workflow form);
        Task SaveChangesAsync();
    }
}
