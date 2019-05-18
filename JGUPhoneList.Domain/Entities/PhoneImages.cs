using System.Collections.Generic;

namespace JGCPhoneList.Domain.Entities
{
    public class PhoneImages
    {
        public int PhoneId { get; set; }
        public int ImageId { get; set; }

        public Phone Phone { get; set; }
        public Image Image { get; set; }
    }
}