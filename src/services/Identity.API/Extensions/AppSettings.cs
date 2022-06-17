namespace Identity.API.Extensions
{
    public class AppSettings
    {
        public string Secret { get; set; }
        public int ExpiryHours { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
    }
}
