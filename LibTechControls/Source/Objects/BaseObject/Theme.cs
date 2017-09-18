using System;
using System.Collections.Generic;
using System.IO;
using LibGalaxyControls.Source.Json;
using LibGalaxyControls.Source.Json.ThemeObjects;
using LibGalaxyControls.Source.Objects.Interfaces;
using Newtonsoft.Json;

namespace LibGalaxyControls.Source.Objects.BaseObject
{
    [Serializable]
    public abstract class Theme : ITheme
    {
        public static List<JsonButtonTheme> AvailableJsonColorThemes = GetJsonThemes().ButtonThemes.Themes;

        public static JsonTheme JsonTheme = GetJsonThemes();

        /// <summary>
        /// Returns all the available json theme data
        /// </summary>
        /// <returns></returns>
        private static JsonTheme GetJsonThemes()
        {
            if (!Directory.Exists("C:\\Themer\\"))
                Directory.CreateDirectory("C:\\Themer\\");

            const String themePath = "C:\\Themer\\themes.json";

            return JsonConvert.DeserializeObject<JsonTheme>(!File.Exists(themePath) ? Resources.DefaultJSON : File.ReadAllText(themePath));
        }

        /// <summary>
        /// Returns all the themes
        /// </summary>
        /// <returns></returns>
        internal abstract List<ITheme> GetAllThemes();
        
        /// <summary>
        /// Override toString
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return Name;
        }

        /// <summary>
        /// The name
        /// </summary>
        public String Name { get; set; }
    }
}
