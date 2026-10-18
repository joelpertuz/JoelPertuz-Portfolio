namespace JoelPertuzPortfolio.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public string FullDescription { get; set; } = string.Empty;
        public string Technologies { get; set; } = string.Empty;
        public string? GithubUrl { get; set; }
        public string? LiveDemoUrl { get; set; }
        public string BadgeText { get; set; } = string.Empty;
        public bool IsFeatured { get; set; } = true;
    }
}