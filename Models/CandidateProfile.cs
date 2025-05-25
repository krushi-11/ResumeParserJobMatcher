namespace ResumeParserJobMatcher.Models
{
    public class CandidateProfile
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Skills { get; set; } // Comma-separated list
        public string Education { get; set; }
        public string Experience { get; set; }
        public string ResumeFilePath { get; set; }
    }
}
