namespace DotaApi.Dal.Options
{
    public class ApiUrl
    {
        public string BaseUrl { get; set; }

        public string BaseImageUrl { get; set; }

        public MatchUrl Matches { get; set; }

        public EconomyUrl Economy { get; set; }

        public ImagesUrl Images { get; set; }
    }

    public class MatchUrl
    {
        public string Base { get; set; }

        public string Details { get; set; }

        public string History { get; set; }
    }

    public class EconomyUrl
    {
        public string Base { get; set; }

        public string Heroes { get; set; }

        public string Items { get; set; }
    }

    public class ImagesUrl
    {
        public string Heroes { get; set; }

        public string Items { get; set; }
    }
}