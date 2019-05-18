namespace JGCPhoneList.Persistence
{
    using JGCPhoneList.Domain.Entities;

    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class JgcPhoneListInitializer
    {
        private List<Color> _colors = new List<Color>();
        private List<Image> _images = new List<Image>();
        private List<Manufacturer> _manufacturers = new List<Manufacturer>();
        private List<OperativeSystem> _operativeSystems = new List<OperativeSystem>();
        private List<Phone> _phones = new List<Phone>();
        private List<PhoneImages> _phoneImages;
        private List<PhoneColors> _phoneColors;
        private Random _rand;
        
        public static void Initialize(JgcPhoneListDbContext context)
        {
            var initializer = new JgcPhoneListInitializer();
            initializer.SeedEverything(context);
        }

        private void SeedEverything(JgcPhoneListDbContext context)
        {
            // TODO: Remove EnsureDeleted, just added to test database creation
            //context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            if (context.Phones.Any())
            {
                return; 
            }

            _rand = new Random();

            SeedColors(context);
            SeedImages(context);
            SeedManufacturers(context);
            SeedOperativeSystem(context);
            SeedPhones(context);
            SeedPhoneColors(context);
            SeedPhoneImages(context);
        }

        private void SeedColors(JgcPhoneListDbContext context)
        {
            var colors = new[]
            {
                new Color {Name = "Black", RValue = 0, GValue = 0, BValue = 0},
                new Color {Name = "White", RValue = 255, GValue = 255, BValue = 255},
                new Color {Name = "Red", RValue = 255, GValue = 0, BValue = 0},
                new Color {Name = "Lime", RValue = 0, GValue = 255, BValue = 0},
                new Color {Name = "Blue", RValue = 0, GValue = 0, BValue = 255},
                new Color {Name = "Yellow", RValue = 255, GValue = 255, BValue = 0},
                new Color {Name = "Cyan", RValue = 0, GValue = 255, BValue = 255},
                new Color {Name = "Magenta", RValue = 255, GValue = 0, BValue = 255},
                new Color {Name = "Silver", RValue = 192, GValue = 192, BValue = 192},
                new Color {Name = "Gray", RValue = 128, GValue = 128, BValue = 128},
                new Color {Name = "Maroon", RValue = 128, GValue = 0, BValue = 0},
                new Color {Name = "Olive", RValue = 128, GValue = 128, BValue = 0},
                new Color {Name = "Green", RValue = 0, GValue = 128, BValue = 0},
                new Color {Name = "Purple", RValue = 128, GValue = 0, BValue = 128},
                new Color {Name = "Teal", RValue = 0, GValue = 128, BValue = 128},
                new Color {Name = "Navy", RValue = 0, GValue = 0, BValue = 128},
            };

            context.Colors.AddRange(colors);
            context.SaveChanges();

            _colors = context.Colors.ToList();
        }

        private void SeedImages(JgcPhoneListDbContext context)
        {
            var images = new[]
            {
                new Image {ImageUrl = "/images/1.webp", Priority = 0},
                new Image {ImageUrl = "/images/2.webp", Priority = 1},
                new Image {ImageUrl = "/images/3.webp", Priority = 2},
                new Image {ImageUrl = "/images/4.webp", Priority = 3},
                new Image {ImageUrl = "/images/5.webp", Priority = 4},
                new Image {ImageUrl = "/images/6.webp", Priority = 5},
                new Image {ImageUrl = "/images/7.webp", Priority = 6},
                new Image {ImageUrl = "/images/8.webp", Priority = 7},
                new Image {ImageUrl = "/images/9.webp", Priority = 8},
                new Image {ImageUrl = "/images/10.webp", Priority = 9},
            };

            context.Images.AddRange(images);
            context.SaveChanges();

            _images = context.Images.ToList();
        }

        private void SeedManufacturers(JgcPhoneListDbContext context)
        {
            var manufacturers = new[]
            {
                new Manufacturer {Name = "Apple", Country = "USA", Year = 1976, LogoPath = "/logos/apple.webp", Description = "Apple Inc. is an American multinational technology company headquartered in Cupertino, California, that designs, develops, and sells consumer electronics, computer software, and online services. It is considered one of the Big Four of technology along with Amazon, Google, and Facebook."},
                new Manufacturer {Name = "Google", Country = "USA", Year = 1998, LogoPath = "/logos/google.png", Description = "Google LLC is an American multinational technology company that specializes in Internet-related services and products, which include online advertising technologies, search engine, cloud computing, software, and hardware. It is considered one of the Big Four technology companies, alongside Amazon, Apple and Facebook."},
                new Manufacturer {Name = "Samsung", Country = "South Korea", Year = 1938, LogoPath = "/logos/samsung.png", Description = "Samsung (Hangul: 삼성; Hanja: 三星; Korean pronunciation: [samsʌŋ]; means 'tristar' in English) is a South Korean multinational conglomerate headquartered in Samsung Town, Seoul. It comprises numerous affiliated businesses, most of them united under the Samsung brand, and is the largest South Korean chaebol (business conglomerate)."},
                new Manufacturer {Name = "LG", Country = "South Korea", Year = 1947, LogoPath = "/logos/lg.png", Description = "LG Corporation (Hangul: 주식회사 LG), formerly Lucky-Goldstar (Korean: Leogki Geumseong; Hangul: 럭키금성; Hanja: 樂喜金星), is a South Korean multinational conglomerate corporation. It is the fourth-largest chaebol in South Korea. It is headquartered in the LG Twin Towers building in Yeouido-dong, Yeongdeungpo District, Seoul.[2] LG makes electronics, chemicals, and telecom products and operates subsidiaries such as LG Electronics, Zenith, LG Display, LG Uplus, LG Innotek and LG Chem in over 80 countries."}
            };

            context.Manufacturers.AddRange(manufacturers);
            context.SaveChanges();

            _manufacturers = context.Manufacturers.ToList();
        }

        private void SeedOperativeSystem(JgcPhoneListDbContext context)
        {
            var operativeSystem = new[]
            {
                new OperativeSystem {Name = "iOS", LogoPath = "logos/iOS.png", Url ="www.apple.com/ios/", Manufacturer = context.Manufacturers.First(m => m.Name == "Apple" ), Description = "iOS (formerly iPhone OS) is a mobile operating system created and developed by Apple Inc. exclusively for its hardware. It is the operating system that presently powers many of the company's mobile devices, including the iPhone, iPad, and iPod Touch. It is the second most popular mobile operating system globally after Android."},
                new OperativeSystem {Name = "Android", LogoPath = "/logos/android.png", Url ="www.android.com", Manufacturer = context.Manufacturers.First(m => m.Name == "Google"), Description = "Android is a mobile operating system developed by Google. It is based on a modified version of the Linux kernel and other open source software, and is designed primarily for touchscreen mobile devices such as smartphones and tablets. In addition, Google has further developed Android TV for televisions, Android Auto for cars, and Wear OS for wrist watches, each with a specialized user interface. Variants of Android are also used on game consoles, digital cameras, PCs and other electronics."},
            };

            context.OperativeSystems.AddRange(operativeSystem);
            context.SaveChanges();

            _operativeSystems = context.OperativeSystems.ToList();
        }

        private void SeedPhones(JgcPhoneListDbContext context)
        {
            var descriptions = new[]
            {
                "Great phone at a really cheap price, this offer will expire shortly.",
                "Great phone with really good specs, this offer will expire shortly",
                "Possibly our best offer currently, please consider it!",
                "This could be the last one ever produced so please do not miss this chance",
                "The screen might be not too big, but at least the camera is small."
            };

            var batteries = new[] { 1800, 2100, 2400, 2800, 3200, 4600, 4000, 5100 };

            var rams = new [] {2, 4, 6, 8, 10, 12, 16, 24, 32};

            var prices = new[] {120, 180, 240, 300, 500, 650, 800};

            _phones = new List<Phone>();
            for (var i = 0; i < 50; i++)
            {
                var manufacturer = _manufacturers[_rand.Next(_manufacturers.Count)];
                var modelSuffixes = new[] { "RTX", "Galaxy", "Planet", "ST", "Rocket", "8S", "25R", "MS"};

                var phone = new Phone
                {
                    Battery = batteries[_rand.Next(batteries.Length)],
                    Description = descriptions[_rand.Next(descriptions.Length)],
                    Manufacturer = manufacturer,
                    Model =
                        $"{manufacturer.Name} {modelSuffixes[_rand.Next(modelSuffixes.Length)]} Series: {_rand.Next(1200, 4000)}",
                    OperativeSystem = _operativeSystems[_rand.Next(_operativeSystems.Count)],
                    Price = prices[_rand.Next(prices.Length)],
                    RAM = rams[_rand.Next(rams.Length)],
                };

                _phones.Add(phone);
            }

            context.Phones.AddRange(_phones);

            context.SaveChanges();
        }


        private void SeedPhoneImages(JgcPhoneListDbContext context)
        {
            const int randomNumberAmount = 3;
            var phoneImages = new List<PhoneImages>();
            foreach (var phone in _phones)
            {
                var randomImageIndexes = new List<int>();
                for (var i = 0; i < randomNumberAmount; i++)
                {
                    var randomImageIndex = _rand.Next(_images.Count);
                    if (!randomImageIndexes.Contains(randomImageIndex))
                    {
                        randomImageIndexes.Add(randomImageIndex);
                        phoneImages.Add(new PhoneImages { Image = _images[randomImageIndex], Phone = phone });
                    }
                }
            }

            _phoneImages = phoneImages.Distinct().ToList();
            context.PhoneImages.AddRange(_phoneImages);

            context.SaveChanges();
        }

        private void SeedPhoneColors(JgcPhoneListDbContext context)
        {
            const int randomNumberAmount = 3;
            var phoneColors = new List<PhoneColors>();
            foreach (var phone in _phones)
            {
                var randomColorIndexes = new List<int>();
                for (var i = 0; i < randomNumberAmount; i++)
                {
                    var randomColorIndex = _rand.Next(_colors.Count);
                    if (!randomColorIndexes.Contains(randomColorIndex))
                    {
                        randomColorIndexes.Add(randomColorIndex);
                        phoneColors.Add(new PhoneColors { Color = _colors[randomColorIndex], Phone = phone });
                    }
                }
            }

            _phoneColors = phoneColors.Distinct().ToList();
            context.PhoneColors.AddRange(_phoneColors);

            context.SaveChanges();
        }
    }
}