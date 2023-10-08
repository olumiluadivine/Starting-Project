using Microsoft.EntityFrameworkCore;
using Starting_Project.Models;
using System;

namespace Starting_Project.Data.Repo
{
    public class ProgramDetailsRepository : IProgramDetailsRepository
    {
        private readonly AppDb _context;

        public ProgramDetailsRepository(AppDb context)
        {
            _context = context;
        }

        public async Task<ProgramDetailsModel> CreateProgramAsync(ProgramDetailsModel program)
        {
            var response = await _context.ProgramDetails.AddAsync(program);
            return response.Entity;
        }

        public async Task<IEnumerable<ProgramDetailsModel>> GetAllProgramsAsync()
        {
            var response = await _context.ProgramDetails.ToListAsync();
            foreach(var r in response)
            {
                Console.WriteLine(r.InfoModel.ProgramLocation);
            }
            return response.ToList();
        }

        public async Task<ProgramDetailsModel> GetProgramForUserAsync(string Id)
        {
            var response = await _context.ProgramDetails.Where(e => e.Id == Id).FirstOrDefaultAsync();
            return response!= null ? response : null;
        }

        public async Task<ProgramDetailsModel> UpdateProgramAsync(ProgramDetailsModel program, string Id)
        {
            var data = await _context.ProgramDetails.Where(e => e.Id == Id).FirstOrDefaultAsync();
            if (data != null)
            {
                data = program;
            }
            return data;
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
