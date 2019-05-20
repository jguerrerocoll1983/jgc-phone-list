namespace JGCPhoneList.Application.Phones.Models
{
    using System.Collections;
    using System.Collections.Generic;

    using JGCPhoneList.Application.Colors.Models;
    using JGCPhoneList.Application.Images.Models;
    using JGCPhoneList.Application.Manufacturers.Models;
    using JGCPhoneList.Application.OperativeSystems.Model;

    public class PhoneDetailDto
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

        public ManufacturerDto Manufacturer { get; set; }
        public OperativeSystemDto OperativeSystem { get; set; }
        public IList<ColorDto> Colors { get; set; }
        public IList<ImageDto> Images { get; set; }
    }
}