namespace JGCPhoneList.Domain.Entities
{
    public class OperativeSystem
    {
        public int OperativeSystemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LogoPath { get; set; }
        public string Url { get; set; }

        public Manufacturer Manufacturer { get; set; }
    }
}