using System.Collections.Generic;

namespace JGCPhoneList.Domain.Entities
{
    public class Phone
    {
        public Phone()
        {
            Colors = new HashSet<Color>();
            Images = new HashSet<Image>();
        }

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

        public Manufacturer Manufacturer { get; set; }
        public OperativeSystem OperativeSystem { get; set; }

        public ICollection<Color> Colors { get; set; }
        public ICollection<Image> Images { get; set; }
    }
}