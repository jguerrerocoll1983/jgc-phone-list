namespace JGCPhoneList.Application.Phones.Models
{
    using System.Collections.Generic;

    public class PhoneListDto
    {
        public IList<PhoneListItemDto> PhoneListItems { get; set; }
    }
}