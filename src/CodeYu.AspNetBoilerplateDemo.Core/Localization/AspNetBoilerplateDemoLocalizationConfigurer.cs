using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;

namespace CodeYu.AspNetBoilerplateDemo.Localization
{
    public static class AspNetBoilerplateDemoLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AspNetBoilerplateDemoConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        Assembly.GetExecutingAssembly(),
                        "CodeYu.AspNetBoilerplateDemo.Core.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}