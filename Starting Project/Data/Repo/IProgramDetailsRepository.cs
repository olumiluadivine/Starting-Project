using Microsoft.EntityFrameworkCore;
using Starting_Project.Models;

namespace Starting_Project.Data.Repo
{
    public interface IProgramDetailsRepository
    {
        Task<ProgramDetailsModel> GetProgramForUserAsync(string Id);
        Task<ProgramDetailsModel> CreateProgramAsync(ProgramDetailsModel program);
        Task<IEnumerable<ProgramDetailsModel>> GetAllProgramsAsync();
        Task<ProgramDetailsModel> UpdateProgramAsync(ProgramDetailsModel program, string Id);
        Task SaveChangesAsync();
    }
}
