using Microsoft.EntityFrameworkCore;
using ResumeParserJobMatcher.Models;

namespace ResumeParserJobMatcher.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<CandidateProfile> CandidateProfiles { get; set; }
        public DbSet<JobPosting> JobPostings { get; set; }
    }
}
