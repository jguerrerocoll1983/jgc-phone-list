namespace JGCPhoneList.Domain.Entities
{
    using System.Collections.Generic;

    public class Manufacturer
    {
        public Manufacturer()
        {
            OperativeSystems = new HashSet<OperativeSystem>();
            Phones = new HashSet<Phone>();
        }

        public int ManufacturerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
        public string LogoPath { get; set; }

        public ICollection<OperativeSystem> OperativeSystems { get; set; }
        public ICollection<Phone> Phones { get; set; }
    }
}