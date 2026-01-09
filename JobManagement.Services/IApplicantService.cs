using JobManagement.Applicant.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobManagement.Services
{
    public interface IApplicantService
    {
        Task<user?> GetApplicantByIdAsync(long applicantId);
        Task<IEnumerable<user>> GetAllApplicantsAsync();
        Task UpdateApplicantProfileAsync(user applicant);
    }
}
