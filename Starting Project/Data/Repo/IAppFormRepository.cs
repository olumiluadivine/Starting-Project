using Microsoft.AspNetCore.Mvc;
using Starting_Project.Models;

namespace Starting_Project.Data.Repo
{
    public interface IAppFormRepository
    {
        Task<ApplicationForm> GetFormForUserAsync(string Id);
        Task<ApplicationForm> GetByProgramId(string Id);
        Task<IEnumerable<ApplicationForm>> GetAllFormsAsync();
        Task<ApplicationForm> UpdateFormAsync(ApplicationForm form, string Id);
        Task<ApplicationForm> CreateFormDetails(ApplicationForm form);
        Task SaveChangesAsync();
    }
}
