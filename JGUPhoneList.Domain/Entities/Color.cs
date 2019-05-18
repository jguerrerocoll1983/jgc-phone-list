namespace JGCPhoneList.Domain.Entities
{
    using System.Collections.Generic;

    public class Color
    {
        public Color()
        {
            PhoneColors = new HashSet<PhoneColors>();
        }

        public int ColorId { get; set; }
        public string Name { get; set; }
        public int RValue { get; set; }
        public int GValue { get; set; }
        public int BValue { get; set; }

        public ICollection<PhoneColors> PhoneColors { get; set; }
    }
}