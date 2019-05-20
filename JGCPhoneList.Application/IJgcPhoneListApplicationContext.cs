namespace JGCPhoneList.Application
{
    using JGCPhoneList.Application.Phones.Models;

    public interface IJgcPhoneListApplicationContext
    {
        PhoneListDto GetPhoneList();

        PhoneDetailDto GetPhoneDetail(int id);
    }
}