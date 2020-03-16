using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace TestingAspnetCore.Localization
{
    public static class TestingAspnetCoreLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(TestingAspnetCoreConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(TestingAspnetCoreLocalizationConfigurer).GetAssembly(),
                        "TestingAspnetCore.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
