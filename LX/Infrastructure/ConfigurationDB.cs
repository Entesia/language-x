using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Globalization;
using LX.Enums;
using LX.Models;

namespace LX.Infrastructure
{
    public static class ConfigurationDB
    {
        public static void FillMakes(LanguagesDbContext context)
        {
            List<MakeContent> makeContentToyota = new List<MakeContent>
            {
                new MakeContent { Id = 1, Language = Language.English, Text = "Toyota" },
                new MakeContent { Id = 2, Language = Language.German, Text = "Toyota" },
                new MakeContent { Id = 3, Language = Language.French, Text = "Toyota" },
                new MakeContent { Id = 4, Language = Language.Italian, Text = "Toyota" },
                new MakeContent { Id = 5, Language = Language.Spanish, Text = "Toyota" },
                new MakeContent { Id = 6, Language = Language.Dutch, Text = "Toyota" },
                new MakeContent { Id = 7, Language = Language.Polish, Text = "Toyota" },
                new MakeContent { Id = 8, Language = Language.Romanian, Text = "Toyota" },
                new MakeContent { Id = 9, Language = Language.Russian, Text = "Toyota" },
                new MakeContent { Id = 10, Language = Language.Turkish, Text = "Toyota" }
            };

            List<MakeContent> makeContentVolkswagen = new List<MakeContent>
            {
                new MakeContent { Id = 11, Language = Language.English, Text = "Volkswagen" },
                new MakeContent { Id = 12, Language = Language.German, Text = "Volkswagen" },
                new MakeContent { Id = 13, Language = Language.French, Text = "Volkswagen" },
                new MakeContent { Id = 14, Language = Language.Italian, Text = "Volkswagen" },
                new MakeContent { Id = 15, Language = Language.Spanish, Text = "Volkswagen" },
                new MakeContent { Id = 16, Language = Language.Dutch, Text = "Volkswagen" },
                new MakeContent { Id = 17, Language = Language.Polish, Text = "Volkswagen" },
                new MakeContent { Id = 18, Language = Language.Romanian, Text = "Volkswagen" },
                new MakeContent { Id = 19, Language = Language.Russian, Text = "Volkswagen" },
                new MakeContent { Id = 20, Language = Language.Turkish, Text = "Volkswagen" }
            };

            context.Makes.AddOrUpdate(p => p.Id, new Make { Id = 1, Name = "Toyota", MakeContent = makeContentToyota });
            context.Makes.AddOrUpdate(p => p.Id, new Make { Id = 2, Name = "Volkswagen", MakeContent = makeContentVolkswagen });
        }

        public static void FillModels(LanguagesDbContext context)
        {
            context.Models.AddOrUpdate(p => p.Id, new Model { Id = 1, Name = "Prius", MakeId  = 1 });
            context.Models.AddOrUpdate(p => p.Id, new Model { Id = 2, Name = "Yaris", MakeId = 1 });
            context.Models.AddOrUpdate(p => p.Id, new Model { Id = 3, Name = "Golf", MakeId = 2 });
            context.Models.AddOrUpdate(p => p.Id, new Model { Id = 4, Name = "Scirocco", MakeId = 2 });
            context.Models.AddOrUpdate(p => p.Id, new Model { Id = 5, Name = "Touran", MakeId = 2 });
        }

        public static void FillLocalizations(LanguagesDbContext context)
        {
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 1, Culture = "de-de", Name = "Site.Title", Value = @"Auto-Suche", ContentType = ContentType.Generic });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 2, Culture = "en-gb", Name = "Site.Title", Value = @"Car Search", ContentType = ContentType.Generic });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 3, Culture = "fr-fr", Name = "Site.Title", Value = @"Car Recherche", ContentType = ContentType.Generic });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 4, Culture = "it-it", Name = "Site.Title", Value = @"Ricerca auto", ContentType = ContentType.Generic });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 5, Culture = "es-es", Name = "Site.Title", Value = @"Búsqueda de automóviles", ContentType = ContentType.Generic });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 6, Culture = "nl-nl", Name = "Site.Title", Value = @"Auto zoeken", ContentType = ContentType.Generic });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 7, Culture = "pl-pl", Name = "Site.Title", Value = @"Wyszukiwarka samochodów", ContentType = ContentType.Generic });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 8, Culture = "ro-ro", Name = "Site.Title", Value = @"Căutare auto", ContentType = ContentType.Generic });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 9, Culture = "ru-ru", Name = "Site.Title", Value = @"Поиск автомобиля", ContentType = ContentType.Generic });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 10, Culture = "tr-tr", Name = "Site.Title", Value = @"Araç Arama", ContentType = ContentType.Generic });

            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 11, Culture = "de-de", Name = "Index.Page.Box_2.Make", Value = @"Marke", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 12, Culture = "en-gb", Name = "Index.Page.Box_2.Make", Value = @"Make", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 13, Culture = "fr-fr", Name = "Index.Page.Box_2.Make", Value = @"Marque", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 14, Culture = "it-it", Name = "Index.Page.Box_2.Make", Value = @"Marca", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 15, Culture = "es-es", Name = "Index.Page.Box_2.Make", Value = @"Marca", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 16, Culture = "nl-nl", Name = "Index.Page.Box_2.Make", Value = @"Merk", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 17, Culture = "pl-pl", Name = "Index.Page.Box_2.Make", Value = @"Marka", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 18, Culture = "ro-ro", Name = "Index.Page.Box_2.Make", Value = @"Marca", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 19, Culture = "ru-ru", Name = "Index.Page.Box_2.Make", Value = @"Марка", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 20, Culture = "tr-tr", Name = "Index.Page.Box_2.Make", Value = @"Markası", ContentType = ContentType.SiteContent });

            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 21, Culture = "de-de", Name = "Index.Page.Box_2.Model", Value = @"Modell", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 22, Culture = "en-gb", Name = "Index.Page.Box_2.Model", Value = @"Model", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 23, Culture = "fr-fr", Name = "Index.Page.Box_2.Model", Value = @"Modèle", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 24, Culture = "it-it", Name = "Index.Page.Box_2.Model", Value = @"Modello", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 25, Culture = "es-es", Name = "Index.Page.Box_2.Model", Value = @"Modelo", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 26, Culture = "nl-nl", Name = "Index.Page.Box_2.Model", Value = @"Model", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 27, Culture = "pl-pl", Name = "Index.Page.Box_2.Model", Value = @"Model", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 28, Culture = "ro-ro", Name = "Index.Page.Box_2.Model", Value = @"Modelul", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 29, Culture = "ru-ru", Name = "Index.Page.Box_2.Model", Value = @"Модель", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 30, Culture = "tr-tr", Name = "Index.Page.Box_2.Model", Value = @"Modeli", ContentType = ContentType.SiteContent });

            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 31, Culture = "de-de", Name = "Index.Page.Box_6.Header.Motor", Value = @"Motor", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 32, Culture = "en-gb", Name = "Index.Page.Box_6.Header.Motor", Value = @"Motor", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 33, Culture = "fr-fr", Name = "Index.Page.Box_6.Header.Motor", Value = @"Moteur", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 34, Culture = "it-it", Name = "Index.Page.Box_6.Header.Motor", Value = @"Motore", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 35, Culture = "es-es", Name = "Index.Page.Box_6.Header.Motor", Value = @"Motor", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 36, Culture = "nl-nl", Name = "Index.Page.Box_6.Header.Motor", Value = @"Motor", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 37, Culture = "pl-pl", Name = "Index.Page.Box_6.Header.Motor", Value = @"Silnik", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 38, Culture = "ro-ro", Name = "Index.Page.Box_6.Header.Motor", Value = @"Motor", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 39, Culture = "ru-ru", Name = "Index.Page.Box_6.Header.Motor", Value = @"Мотор", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 40, Culture = "tr-tr", Name = "Index.Page.Box_6.Header.Motor", Value = @"Motor", ContentType = ContentType.SiteContent });

            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 41, Culture = "de-de", Name = "Petrol", Value = @"Benzin", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 42, Culture = "en-gb", Name = "Petrol", Value = @"Petrol", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 43, Culture = "fr-fr", Name = "Petrol", Value = @"Essence", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 44, Culture = "it-it", Name = "Petrol", Value = @"Benzina", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 45, Culture = "es-es", Name = "Petrol", Value = @"Gasolina", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 46, Culture = "nl-nl", Name = "Petrol", Value = @"Benzine", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 47, Culture = "pl-pl", Name = "Petrol", Value = @"Benzyna", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 48, Culture = "ro-ro", Name = "Petrol", Value = @"Benzină", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 49, Culture = "ru-ru", Name = "Petrol", Value = @"Бензин", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 50, Culture = "tr-tr", Name = "Petrol", Value = @"Benzin", ContentType = ContentType.SiteContent });

            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 51, Culture = "de-de", Name = "Diesel", Value = @"Diesel", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 52, Culture = "en-gb", Name = "Diesel", Value = @"Diesel", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 53, Culture = "fr-fr", Name = "Diesel", Value = @"Diesel", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 54, Culture = "it-it", Name = "Diesel", Value = @"Diesel", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 55, Culture = "es-es", Name = "Diesel", Value = @"Diesel", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 56, Culture = "nl-nl", Name = "Diesel", Value = @"Diesel", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 57, Culture = "pl-pl", Name = "Diesel", Value = @"Diesel", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 58, Culture = "ro-ro", Name = "Diesel", Value = @"Diesel", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 59, Culture = "ru-ru", Name = "Diesel", Value = @"Дизель", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 60, Culture = "tr-tr", Name = "Diesel", Value = @"Dizel", ContentType = ContentType.SiteContent });

            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 61, Culture = "de-de", Name = "Electric", Value = @"Elektro", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 62, Culture = "en-gb", Name = "Electric", Value = @"Electric", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 63, Culture = "fr-fr", Name = "Electric", Value = @"Electrique", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 64, Culture = "it-it", Name = "Electric", Value = @"Elettrico", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 65, Culture = "es-es", Name = "Electric", Value = @"Eléctrico", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 66, Culture = "nl-nl", Name = "Electric", Value = @"Elektrisch", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 67, Culture = "pl-pl", Name = "Electric", Value = @"Elektryczny", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 68, Culture = "ro-ro", Name = "Electric", Value = @"Electric", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 69, Culture = "ru-ru", Name = "Electric", Value = @"Электрический", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 70, Culture = "tr-tr", Name = "Electric", Value = @"Elektrik", ContentType = ContentType.SiteContent });

            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 71, Culture = "de-de", Name = "ManualTransmission", Value = @"Schaltgetriebe", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 72, Culture = "en-gb", Name = "ManualTransmission", Value = @"Manual transmission", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 73, Culture = "fr-fr", Name = "ManualTransmission", Value = @"Transmission manuelle", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 74, Culture = "it-it", Name = "ManualTransmission", Value = @"Cambio manuale", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 75, Culture = "es-es", Name = "ManualTransmission", Value = @"Transmisión manual", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 76, Culture = "nl-nl", Name = "ManualTransmission", Value = @"Handgeschakelde versnellingsbak", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 77, Culture = "pl-pl", Name = "ManualTransmission", Value = @"Manualna skrzynia biegów", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 78, Culture = "ro-ro", Name = "ManualTransmission", Value = @"Transmisie manuala", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 79, Culture = "ru-ru", Name = "ManualTransmission", Value = @"Mеханическая коробка передач", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 80, Culture = "tr-tr", Name = "ManualTransmission", Value = @"Manuel şanzıman", ContentType = ContentType.SiteContent });

            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 81, Culture = "de-de", Name = "Semiautomatic", Value = @"Halbautomatik", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 82, Culture = "en-gb", Name = "Semiautomatic", Value = @"Semiautomatic", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 83, Culture = "fr-fr", Name = "Semiautomatic", Value = @"Semi-automatique", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 84, Culture = "it-it", Name = "Semiautomatic", Value = @"Semiautomatico", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 85, Culture = "es-es", Name = "Semiautomatic", Value = @"Semiautomático", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 86, Culture = "nl-nl", Name = "Semiautomatic", Value = @"Halfautomatische", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 87, Culture = "pl-pl", Name = "Semiautomatic", Value = @"Półautomatyczne", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 88, Culture = "ro-ro", Name = "Semiautomatic", Value = @"Semiautomat", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 89, Culture = "ru-ru", Name = "Semiautomatic", Value = @"Полуавтоматический", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 90, Culture = "tr-tr", Name = "Semiautomatic", Value = @"Yarı otomatik", ContentType = ContentType.SiteContent });

            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 91, Culture = "de-de", Name = "Automatic", Value = @"Automatik", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 92, Culture = "en-gb", Name = "Automatic", Value = @"Automatik", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 93, Culture = "fr-fr", Name = "Automatic", Value = @"Automatique", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 94, Culture = "it-it", Name = "Automatic", Value = @"Automatico", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 95, Culture = "es-es", Name = "Automatic", Value = @"Semiautomático", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 96, Culture = "nl-nl", Name = "Automatic", Value = @"Automático", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 97, Culture = "pl-pl", Name = "Automatic", Value = @"Automatisch", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 98, Culture = "ro-ro", Name = "Automatic", Value = @"Automatyczny", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 99, Culture = "ru-ru", Name = "Automatic", Value = @"Автоматическая", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 100, Culture = "tr-tr", Name = "Automatic", Value = @"Otomatik", ContentType = ContentType.SiteContent });

            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 101, Culture = "de-de", Name = "SearchButton", Value = @"Suche", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 102, Culture = "en-gb", Name = "SearchButton", Value = @"Search", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 103, Culture = "fr-fr", Name = "SearchButton", Value = @"Chercher", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 104, Culture = "it-it", Name = "SearchButton", Value = @"Ricerca", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 105, Culture = "es-es", Name = "SearchButton", Value = @"Buscar", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 106, Culture = "nl-nl", Name = "SearchButton", Value = @"Zoeken", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 107, Culture = "pl-pl", Name = "SearchButton", Value = @"Poszukiwanie", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 108, Culture = "ro-ro", Name = "SearchButton", Value = @"Căutare", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 109, Culture = "ru-ru", Name = "SearchButton", Value = @"Поиск", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 110, Culture = "tr-tr", Name = "SearchButton", Value = @"Arama", ContentType = ContentType.SiteContent });

            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 111, Culture = "de-de", Name = "Search", Value = @"suche", ContentType = ContentType.Controller });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 112, Culture = "en-gb", Name = "Search", Value = @"search", ContentType = ContentType.Controller });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 113, Culture = "fr-fr", Name = "Search", Value = @"chercher", ContentType = ContentType.Controller });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 114, Culture = "it-it", Name = "Search", Value = @"ricerca", ContentType = ContentType.Controller });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 115, Culture = "es-es", Name = "Search", Value = @"buscar", ContentType = ContentType.Controller });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 116, Culture = "nl-nl", Name = "Search", Value = @"zoeken", ContentType = ContentType.Controller });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 117, Culture = "pl-pl", Name = "Search", Value = @"poszukiwanie", ContentType = ContentType.Controller });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 118, Culture = "ro-ro", Name = "Search", Value = @"căutare", ContentType = ContentType.Controller });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 119, Culture = "ru-ru", Name = "Search", Value = @"поиск", ContentType = ContentType.Controller });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 120, Culture = "tr-tr", Name = "Search", Value = @"arama", ContentType = ContentType.Controller });

            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 121, Culture = "de-de", Name = "Index", Value = @"index", ContentType = ContentType.Action });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 122, Culture = "en-gb", Name = "Index", Value = @"index", ContentType = ContentType.Action });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 123, Culture = "fr-fr", Name = "Index", Value = @"indice", ContentType = ContentType.Action });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 124, Culture = "it-it", Name = "Index", Value = @"indice", ContentType = ContentType.Action });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 125, Culture = "es-es", Name = "Index", Value = @"indice", ContentType = ContentType.Action });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 126, Culture = "nl-nl", Name = "Index", Value = @"index", ContentType = ContentType.Action });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 127, Culture = "pl-pl", Name = "Index", Value = @"indeks", ContentType = ContentType.Action });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 128, Culture = "ro-ro", Name = "Index", Value = @"index", ContentType = ContentType.Action });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 129, Culture = "ru-ru", Name = "Index", Value = @"индекс", ContentType = ContentType.Action });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 130, Culture = "tr-tr", Name = "Index", Value = @"indeks", ContentType = ContentType.Action });

            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 131, Culture = "de-de", Name = "Home", Value = @"hauptseite", ContentType = ContentType.Controller });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 132, Culture = "en-gb", Name = "Home", Value = @"home", ContentType = ContentType.Controller });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 133, Culture = "fr-fr", Name = "Home", Value = @"pagedaccueil", ContentType = ContentType.Controller });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 134, Culture = "it-it", Name = "Home", Value = @"homepage", ContentType = ContentType.Controller });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 135, Culture = "es-es", Name = "Home", Value = @"páginadeinicio", ContentType = ContentType.Controller });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 136, Culture = "nl-nl", Name = "Home", Value = @"startpagina", ContentType = ContentType.Controller });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 137, Culture = "pl-pl", Name = "Home", Value = @"stronagłówna", ContentType = ContentType.Controller });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 138, Culture = "ro-ro", Name = "Home", Value = @"paginadestart", ContentType = ContentType.Controller });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 139, Culture = "ru-ru", Name = "Home", Value = @"домашняястраница", ContentType = ContentType.Controller });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 140, Culture = "tr-tr", Name = "Home", Value = @"anasayfa", ContentType = ContentType.Controller });

            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 141, Culture = "de-de", Name = "Wanted", Value = @"Gesucht", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 142, Culture = "en-gb", Name = "Wanted", Value = @"Wanted", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 143, Culture = "fr-fr", Name = "Wanted", Value = @"Voulait", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 144, Culture = "it-it", Name = "Wanted", Value = @"Ricercato", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 145, Culture = "es-es", Name = "Wanted", Value = @"Querido", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 146, Culture = "nl-nl", Name = "Wanted", Value = @"Gezocht", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 147, Culture = "pl-pl", Name = "Wanted", Value = @"Chciał", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 148, Culture = "ro-ro", Name = "Wanted", Value = @"Dorit", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 149, Culture = "ru-ru", Name = "Wanted", Value = @"Разыскивается", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 150, Culture = "tr-tr", Name = "Wanted", Value = @"Aranan", ContentType = ContentType.SiteContent });

            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 151, Culture = "de-de", Name = "ForSale", Value = @"Zu verkaufen", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 152, Culture = "en-gb", Name = "ForSale", Value = @"For Sale", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 153, Culture = "fr-fr", Name = "ForSale", Value = @"À vendre", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 154, Culture = "it-it", Name = "ForSale", Value = @"In vendita", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 155, Culture = "es-es", Name = "ForSale", Value = @"En venta", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 156, Culture = "nl-nl", Name = "ForSale", Value = @"Te koop", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 157, Culture = "pl-pl", Name = "ForSale", Value = @"Na sprzedaż", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 158, Culture = "ro-ro", Name = "ForSale", Value = @"De vânzare", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 159, Culture = "ru-ru", Name = "ForSale", Value = @"Продается", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 160, Culture = "tr-tr", Name = "ForSale", Value = @"Satılık", ContentType = ContentType.SiteContent });

            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 161, Culture = "de-de", Name = "To", Value = @"Nach", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 162, Culture = "en-gb", Name = "To", Value = @"To", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 163, Culture = "fr-fr", Name = "To", Value = @"À", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 164, Culture = "it-it", Name = "To", Value = @"A", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 165, Culture = "es-es", Name = "To", Value = @"A", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 166, Culture = "nl-nl", Name = "To", Value = @"Naar", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 167, Culture = "pl-pl", Name = "To", Value = @"Do", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 168, Culture = "ro-ro", Name = "To", Value = @"La", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 169, Culture = "ru-ru", Name = "To", Value = @"До", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 170, Culture = "tr-tr", Name = "To", Value = @"Için", ContentType = ContentType.SiteContent });

            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 171, Culture = "de-de", Name = "From", Value = @"Von", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 172, Culture = "en-gb", Name = "From", Value = @"From", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 173, Culture = "fr-fr", Name = "From", Value = @"De", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 174, Culture = "it-it", Name = "From", Value = @"Da parte di", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 175, Culture = "es-es", Name = "From", Value = @"De", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 176, Culture = "nl-nl", Name = "From", Value = @"Van", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 177, Culture = "pl-pl", Name = "From", Value = @"Od", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 178, Culture = "ro-ro", Name = "From", Value = @"Din", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 179, Culture = "ru-ru", Name = "From", Value = @"От", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 180, Culture = "tr-tr", Name = "From", Value = @"Itibaren", ContentType = ContentType.SiteContent });

            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 181, Culture = "de-de", Name = "SiteContent.Any", Value = @"Beliebig", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 182, Culture = "en-gb", Name = "SiteContent.Any", Value = @"Any", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 183, Culture = "fr-fr", Name = "SiteContent.Any", Value = @"Tout", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 184, Culture = "it-it", Name = "SiteContent.Any", Value = @"Qualsiasi", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 185, Culture = "es-es", Name = "SiteContent.Any", Value = @"Cualquier", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 186, Culture = "nl-nl", Name = "SiteContent.Any", Value = @"Elk", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 187, Culture = "pl-pl", Name = "SiteContent.Any", Value = @"Dowolny", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 188, Culture = "ro-ro", Name = "SiteContent.Any", Value = @"Orice", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 189, Culture = "ru-ru", Name = "SiteContent.Any", Value = @"Любой", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 190, Culture = "tr-tr", Name = "SiteContent.Any", Value = @"Herhangi", ContentType = ContentType.SiteContent });

            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 191, Culture = "de-de", Name = "ClientSideValidation", Value = @"Client-seitige validierung", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 192, Culture = "en-gb", Name = "ClientSideValidation", Value = @"Client side validation", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 193, Culture = "fr-fr", Name = "ClientSideValidation", Value = @"Validation côté client", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 194, Culture = "it-it", Name = "ClientSideValidation", Value = @"La validazione lato client", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 195, Culture = "es-es", Name = "ClientSideValidation", Value = @"Validación del lado del cliente", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 196, Culture = "nl-nl", Name = "ClientSideValidation", Value = @"Client side validatie", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 197, Culture = "pl-pl", Name = "ClientSideValidation", Value = @"Walidacja po stronie klienta", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 198, Culture = "ro-ro", Name = "ClientSideValidation", Value = @"Validare partea de client", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 199, Culture = "ru-ru", Name = "ClientSideValidation", Value = @"Проверка на стороне клиента", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 200, Culture = "tr-tr", Name = "ClientSideValidation", Value = @"İstemci tarafı doğrulama", ContentType = ContentType.SiteContent });

            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 201, Culture = "de-de", Name = "ServerSideValidation", Value = @"Server-seitige Validierung", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 202, Culture = "en-gb", Name = "ServerSideValidation", Value = @"Server side validation", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 203, Culture = "fr-fr", Name = "ServerSideValidation", Value = @"Validation côté serveur", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 204, Culture = "it-it", Name = "ServerSideValidation", Value = @"La validazione lato server", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 205, Culture = "es-es", Name = "ServerSideValidation", Value = @"La validación del lado del servidor", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 206, Culture = "nl-nl", Name = "ServerSideValidation", Value = @"Side validatie server", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 207, Culture = "pl-pl", Name = "ServerSideValidation", Value = @"Walidacja po stronie serwera", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 208, Culture = "ro-ro", Name = "ServerSideValidation", Value = @"Validarea pe partea de server", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 209, Culture = "ru-ru", Name = "ServerSideValidation", Value = @"Проверка на стороне сервера", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 210, Culture = "tr-tr", Name = "ServerSideValidation", Value = @"Sunucu tarafı doğrulama", ContentType = ContentType.SiteContent });

            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 211, Culture = "de-de", Name = "MessageForError", Value = @"Bitte geben Sie einen Text ein", ContentType = ContentType.Validation });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 212, Culture = "en-gb", Name = "MessageForError", Value = @"Please enter some text", ContentType = ContentType.Validation });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 213, Culture = "fr-fr", Name = "MessageForError", Value = @"S'il vous plaît entrer un texte", ContentType = ContentType.Validation });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 214, Culture = "it-it", Name = "MessageForError", Value = @"Si prega di inserire del testo", ContentType = ContentType.Validation });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 215, Culture = "es-es", Name = "MessageForError", Value = @"Por favor, introduzca algún texto", ContentType = ContentType.Validation });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 216, Culture = "nl-nl", Name = "MessageForError", Value = @"U dient een tekst", ContentType = ContentType.Validation });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 217, Culture = "pl-pl", Name = "MessageForError", Value = @"Proszę podać tekst", ContentType = ContentType.Validation });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 218, Culture = "ro-ro", Name = "MessageForError", Value = @"Vă rugăm să introduceți un text", ContentType = ContentType.Validation });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 219, Culture = "ru-ru", Name = "MessageForError", Value = @"Пожалуйста, введите текст", ContentType = ContentType.Validation });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 220, Culture = "tr-tr", Name = "MessageForError", Value = @"Bir metin girin", ContentType = ContentType.Validation });

            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 221, Culture = "de-de", Name = "BackButton", Value = @"Zurück", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 222, Culture = "en-gb", Name = "BackButton", Value = @"Back", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 223, Culture = "fr-fr", Name = "BackButton", Value = @"Arrière", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 224, Culture = "it-it", Name = "BackButton", Value = @"Indietro", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 225, Culture = "es-es", Name = "BackButton", Value = @"Espalda", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 226, Culture = "nl-nl", Name = "BackButton", Value = @"Terug", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 227, Culture = "pl-pl", Name = "BackButton", Value = @"Plecy", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 228, Culture = "ro-ro", Name = "BackButton", Value = @"Înapoi", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 229, Culture = "ru-ru", Name = "BackButton", Value = @"Назад", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 230, Culture = "tr-tr", Name = "BackButton", Value = @"Geri", ContentType = ContentType.SiteContent });

            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 231, Culture = "de-de", Name = "SearchResults", Value = @"Suchergebnisse", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 232, Culture = "en-gb", Name = "SearchResults", Value = @"Search Results", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 233, Culture = "fr-fr", Name = "SearchResults", Value = @"Résultats de la recherche", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 234, Culture = "it-it", Name = "SearchResults", Value = @"Risultati di ricerca", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 235, Culture = "es-es", Name = "SearchResults", Value = @"Resultados de la búsqueda", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 236, Culture = "nl-nl", Name = "SearchResults", Value = @"Zoekresultaten", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 237, Culture = "pl-pl", Name = "SearchResults", Value = @"Wyniki wyszukiwania", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 238, Culture = "ro-ro", Name = "SearchResults", Value = @"Rezultatele cautarii", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 239, Culture = "ru-ru", Name = "SearchResults", Value = @"Результаты поиска", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 240, Culture = "tr-tr", Name = "SearchResults", Value = @"Arama sonuçları", ContentType = ContentType.SiteContent });

            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 241, Culture = "de-de", Name = "ForRent", Value = @"Zu vermieten", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 242, Culture = "en-gb", Name = "ForRent", Value = @"For Rent", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 243, Culture = "fr-fr", Name = "ForRent", Value = @"A louer", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 244, Culture = "it-it", Name = "ForRent", Value = @"Da affittare", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 245, Culture = "es-es", Name = "ForRent", Value = @"En renta", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 246, Culture = "nl-nl", Name = "ForRent", Value = @"Te huur", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 247, Culture = "pl-pl", Name = "ForRent", Value = @"Do wynajęcia", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 248, Culture = "ro-ro", Name = "ForRent", Value = @"De inchiriat", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 249, Culture = "ru-ru", Name = "ForRent", Value = @"Аренда", ContentType = ContentType.SiteContent });
            context.Localizations.AddOrUpdate(p => p.Id, new Localization { Id = 250, Culture = "tr-tr", Name = "ForRent", Value = @"Kiralık", ContentType = ContentType.SiteContent });
        }
    }
}