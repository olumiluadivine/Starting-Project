using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Starting_Project.DTOs;
using Starting_Project.Models;

namespace Starting_Project.Data.Repo
{
    public class AppFormRepository : IAppFormRepository
    {
        private readonly AppDb _context;

        public AppFormRepository(AppDb context)
        {
            _context = context;
        }

        public async Task<ApplicationForm> CreateFormDetails(ApplicationForm form)
        {
            var response = await _context.ApplicationForms.AddAsync(form);
            return response.Entity;
        }

        public async Task<IEnumerable<ApplicationForm>> GetAllFormsAsync()
        {
            var response = await _context.ApplicationForms.ToListAsync();
            foreach (var r in response)
            {
                Console.WriteLine(r.ToString());
            }
            return response.ToList();
        }

        public async Task<ApplicationForm> GetByProgramId(string Id)
        {
            var response = await _context.ApplicationForms.Where(e => e.ProgramId == Id).FirstOrDefaultAsync();
            return response != null ? response : null;
        }

        public async Task<ApplicationForm> GetFormForUserAsync(string Id)
        {
            var response = await _context.ApplicationForms.Where(e => e.Id == Id).FirstOrDefaultAsync();
            return response != null ? response : null;
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
        public async Task<ApplicationForm> UpdateFormAsync(ApplicationForm form, string Id)
        {
            var data = await _context.ApplicationForms.Where(e => e.Id == Id).FirstOrDefaultAsync();
            if (data != null)
            {
                data = form;
            }
            return data;
        }
    }
}
