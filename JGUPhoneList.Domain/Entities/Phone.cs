namespace JGCPhoneList.Domain.Entities
{
    using System.Collections.Generic;

    public class Phone
    {
        public Phone()
        {
            PhoneColors = new HashSet<PhoneColors>();
            PhoneImages = new HashSet<PhoneImages>();
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

        public ICollection<PhoneColors> PhoneColors { get; set; }
        public ICollection<PhoneImages> PhoneImages { get; set; }
    }
}