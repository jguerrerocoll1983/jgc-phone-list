namespace JGCPhoneList.Domain.Entities
{
    using System.Collections.Generic;

    public class PhoneColors
    {
        public int ColorId { get; set; }

        public int PhoneId { get; set; }

        public Color Color { get; set; }
        public Phone Phone { get; set; }
    }
}