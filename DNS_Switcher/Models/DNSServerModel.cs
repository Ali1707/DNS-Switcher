
namespace DNS_Switcher.Models
{
    public class DNSServerModel
    {

        public string DNSServerName { get; set; } = "";
        public string IPV4Index1 { get; set; }
        public string? IPV4Index2 { get; set; }
        public string? IPV6Index1 { get; set; }
        public string? IPV6Index2 { get; set; }
        public string? DOH { get; set; }
    }
}
