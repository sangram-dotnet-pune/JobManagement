using JobManagement.Applicant.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobManagement.Repositories
{
    public class ApplicantService
    {
        private readonly IApplicantRepository _applicantRepository;

        public ApplicantService(IApplicantRepository applicantRepository)
        {
            _applicantRepository = applicantRepository;
        }

        public async Task<user?> GetApplicantByIdAsync(long applicantId)
        {
            return await _applicantRepository.GetByIdAsync(applicantId);
        }

        public async Task<IEnumerable<user>> GetAllApplicantsAsync()
        {
            return await _applicantRepository.GetAllAsync();
        }

        public async Task UpdateApplicantProfileAsync(user applicant)
        {
            await _applicantRepository.UpdateAsync(applicant);
        }
    }
}
