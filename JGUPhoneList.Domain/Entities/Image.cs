namespace JGCPhoneList.Domain.Entities
{
    using System.Collections.Generic;

    public class Image
    {
        public Image()
        {
            PhoneImages = new HashSet<PhoneImages>();
        }

        public int ImageId { get; set; }
        public string ImageUrl { get; set; }
        public int Priority { get; set; }

        public ICollection<PhoneImages> PhoneImages { get; set; }
    }
}