namespace JoelPertuzPortfolio.Models
{
    public class Certification
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Institution { get; set; } = string.Empty;
        public string DateObtained { get; set; } = string.Empty;
        public string? CredentialUrl { get; set; }
    }
}