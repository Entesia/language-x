using System.Collections.Generic;
using System.Linq;
using LX.Models;

namespace LX.Infrastructure
{
    public class LocalizationService
    {
        public List<Localization> GetAll()
        {
            using (var db = new LanguagesDbContext())
            {
                return db.Localizations.ToList();
            }
        }

        public void Add(Localization add)
        {
            var db = new LanguagesDbContext();

            var item = new Localization()
            {
                Name = add.Name,
                ContentType = add.ContentType,
                Culture = add.Culture,
                Value = add.Value,
            };

            db.Localizations.Add(item);
            db.SaveChanges();
        }

        public void UpdateTranslations(List<Localization> localizations)
        {
            using (var db = new LanguagesDbContext())
            {
                db.Localizations.AddRange(localizations);
                db.SaveChanges();
            }
        }

        public void ClearTranslations()
        {
            var db = new LanguagesDbContext();
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE [Localization]");
        }
    }
}