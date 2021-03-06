﻿// -----------------------------------------------
//     Author: Ramon Bollen
//      File: Pony.LocalizationHandler.cs
// Created on: 20201211
// -----------------------------------------------

using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Pony.Localization
{
    /// <summary>
    ///     Class for handling languages
    /// </summary>
    public static class LocalizationHandler
    {
        public enum Language
        {
            English,
            Dutch,
            Chinese
        }

        private static string          _dictionaryName;
        private static ResourceManager _resMrg;
        private static CultureInfo     _cul;

        static LocalizationHandler() => SetLanguage(Language.English);

        public static Dictionary<Language, string> Languages { get; } = new()
        {
            {Language.English, "en-US"}, {Language.Dutch, "nl-NL"}, {Language.Chinese, "zh-cn"}
        };

        /// <summary>
        ///     Get a specific resource string for the current language
        /// </summary>
        /// <param name="resName"></param>
        /// <returns></returns>
        public static string GetString(string resName) => _resMrg.GetString(resName, _cul);

        public static void SetLanguage(Language lang)
        {
            _dictionaryName = $"{Assembly.GetExecutingAssembly().GetName().Name}.Localization.{Languages[lang]}";
            _resMrg         = new ResourceManager(_dictionaryName, Assembly.GetExecutingAssembly());
            _cul            = new CultureInfo(Languages[lang]);
        }
    }
}