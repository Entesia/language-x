using System.Data.Entity.Migrations;
using LX.Models;

namespace LX.Infrastructure
{
    internal sealed class Configuration : DbMigrationsConfiguration<LanguagesDbContext>
    {
        readonly LocalizationService _local = new LocalizationService();

        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;

            ContextKey = "DbLanguages.Domain.Models.LanguagesDbContext";
        }

        protected override void Seed(LanguagesDbContext context)
        {
            _local.ClearTranslations();
            ConfigurationDB.FillLocalizations(context);
            ConfigurationDB.FillMakes(context);
            ConfigurationDB.FillModels(context);
            context.SaveChanges();
        }
    }
}