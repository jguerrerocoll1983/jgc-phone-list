namespace JGCPhoneList.Application
{
    using System.Linq;

    using JGCPhoneList.Application.Colors.Models;
    using JGCPhoneList.Application.Images.Models;
    using JGCPhoneList.Application.Manufacturers.Models;
    using JGCPhoneList.Application.OperativeSystems.Model;
    using JGCPhoneList.Application.Phones.Models;
    using JGCPhoneList.Domain.Entities;
    using JGCPhoneList.Persistence;

    using Microsoft.EntityFrameworkCore;

    public class JgcPhoneListApplicationContext : JgcPhoneListDbContext, IJgcPhoneListApplicationContext
    {
        public JgcPhoneListApplicationContext(DbContextOptions<JgcPhoneListDbContext> options) : base(options)
        {
        }

        public PhoneListDto GetPhoneList()
        {
            var phoneListItems = Phones.Select(
                p => new PhoneListItemDto
                {
                    PhoneId = p.PhoneId,
                    Battery = p.Battery,
                    Description = p.Description,
                    ManufacturerId = p.Manufacturer.ManufacturerId,
                    ManufacturerName = p.Manufacturer.Name,
                    Model = p.Model,
                    OperativeSystemId = p.OperativeSystem.OperativeSystemId,
                    OperativeSystemName = p.OperativeSystem.Name,
                    Price = p.Price,
                    RAM = p.RAM,
                    Year = p.Year,
                    Weight = p.Weight,
                    Storage = p.Storage,
                    Resolution = p.Resolution,
                }).ToList();

            var result = new PhoneListDto
            {
                PhoneListItems = phoneListItems
            };

            return result;
        }

        public PhoneDetailDto GetPhoneDetail(int id)
        {
            var result = Phones.Where(p => p.PhoneId == id).Select(
                p => new PhoneDetailDto
                {
                    PhoneId = p.PhoneId,
                    Battery = p.Battery,
                    Description = p.Description,
                    Manufacturer = ToDto(p.Manufacturer),
                    Model = p.Model,
                    OperativeSystem = ToDto(p.OperativeSystem, p.Manufacturer),
                    Price = p.Price,
                    RAM = p.RAM,
                    Year = p.Year,
                    Weight = p.Weight,
                    Storage = p.Storage,
                    Resolution = p.Resolution,
                    Images = p.PhoneImages.Select(pi => ToDto(pi.Image)).ToList(),
                    Colors = p.PhoneColors.Select(pi => ToDto(pi.Color)).ToList()
                }).FirstOrDefault();

            return result;
        }

        private ManufacturerDto ToDto(Manufacturer manufacturer)
        {
            if (manufacturer == null)
                return null;

            return new ManufacturerDto
            {
                ManufacturerId = manufacturer.ManufacturerId,
                Country = manufacturer.Country,
                Description = manufacturer.Description,
                LogoPath = manufacturer.LogoPath,
                Name = manufacturer.Name,
                Year = manufacturer.Year
            };
        }

        private OperativeSystemDto ToDto(OperativeSystem operativeSystem, Manufacturer manufacturer)
        {
            if (operativeSystem == null)
                return null;

            return new OperativeSystemDto
            {
                OperativeSystemId = operativeSystem.OperativeSystemId,
                Description = operativeSystem.Description,
                LogoPath = operativeSystem.LogoPath,
                Manufacturer = ToDto(manufacturer),
                Name = operativeSystem.Name,
                Url = operativeSystem.Url
            };
        }

        private ColorDto ToDto(Color color)
        {
            if (color == null)
                return null;

            return new ColorDto
            {
                ColorId = color.ColorId,
                Name = color.Name,
                BValue = color.BValue,
                GValue = color.GValue,
                RValue = color.RValue
            };
        }

        private ImageDto ToDto(Image image)
        {
            if (image == null)
                return null;

            return new ImageDto
            {
                ImageId = image.ImageId,
                ImageUrl = image.ImageUrl,
                Priority = image.Priority
            };
        }
    }
}