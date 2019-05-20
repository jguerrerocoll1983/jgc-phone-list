namespace JGCPhoneList.Application.Manufacturers.Models
{
    public class ManufacturerDto
    {
        public int ManufacturerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
        public string LogoPath { get; set; }
    }
}