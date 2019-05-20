namespace JGCPhoneList.Application.Phones.Models
{
    public class PhoneListItemDto
    {
        public int PhoneId { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public int Weight { get; set; }
        public int Battery { get; set; }
        public int RAM { get; set; }
        public int Storage { get; set; }
        public string Resolution { get; set; }
        public float Price { get; set; }


        public int ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }

        public int OperativeSystemId { get; set; }
        public string OperativeSystemName { get; set; }
    }
}