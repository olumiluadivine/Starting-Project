using Microsoft.EntityFrameworkCore;
using Starting_Project.Models;

namespace Starting_Project.Data.Repo
{
    public class WorkflowRepository : IWorkflowRepository
    {
        private readonly AppDb _context;

        public WorkflowRepository(AppDb context)
        {
            _context = context;
        }
        public async Task<Workflow> CreateWorkflow(Workflow form)
        {
            var response = await _context.Workflows.AddAsync(form);
            return response.Entity;
        }

        public async Task<IEnumerable<Workflow>> GetAllWorkflowAsync()
        {
            var response = await _context.Workflows.ToListAsync();
            foreach (var r in response)
            {
                Console.WriteLine(r.ToString());
            }
            return response.ToList();
        }

        public async Task<Workflow> GetByProgramId(string Id)
        {
            var response = await _context.Workflows.Where(e => e.ProgramDetailsId == Id).FirstOrDefaultAsync();
            return response != null ? response : null;
        }

        public async Task<Workflow> GetWorkflowAsync(string Id)
        {
            var response = await _context.Workflows.Where(e => e.Id == Id).FirstOrDefaultAsync();
            return response != null ? response : null;
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<Workflow> UpdateWorkflow(Workflow form, string Id)
        {
            var data = await _context.Workflows.Where(e => e.Id == Id).FirstOrDefaultAsync();
            if (data != null)
            {
                data = form;
            }
            return data;
        }
    }
}
