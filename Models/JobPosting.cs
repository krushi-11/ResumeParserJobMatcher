namespace ResumeParserJobMatcher.Models
{
    public class JobPosting
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string RequiredSkills { get; set; } // Comma-separated
        public DateTime DatePosted { get; set; } = DateTime.UtcNow;
    }
}
