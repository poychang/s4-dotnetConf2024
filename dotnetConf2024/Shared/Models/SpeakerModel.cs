namespace dotnetConf2024.Shared.Models
{
    public class SpeakerModel
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string JobTitle { get; set; } = string.Empty;
        public string PictureUrl { get; set; } = string.Empty;
        public string BlogUrl { get; set; } = string.Empty;
        public string FacebookUrl { get; set; } = string.Empty;
        public string TwitterUrl { get; set; } = string.Empty;
        public string LinkedinUrl { get; set; } = string.Empty;
        public string YouTubeUrl { get; set; } = string.Empty;
        public string Introduction { get; set; } = string.Empty;
        public string Topic { get; set; } = string.Empty;
        public string TopicOutline { get; set; } = string.Empty;
        public string Room { get; set; } = string.Empty;
        public string Track { get; set; } = string.Empty;
        public DateTime SessionStart { get; set; }
        public DateTime SessionEnd { get; set; }
        public bool IsShow { get; set; }
        public IEnumerable<string> Tags { get; set; } = new List<string>();
    }
}
