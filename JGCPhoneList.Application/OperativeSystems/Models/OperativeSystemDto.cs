namespace JGCPhoneList.Application.OperativeSystems.Model
{
    using JGCPhoneList.Application.Manufacturers.Models;

    public class OperativeSystemDto
    {
        public int OperativeSystemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LogoPath { get; set; }
        public string Url { get; set; }

        public ManufacturerDto Manufacturer { get; set; }
    }
}