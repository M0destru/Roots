using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace Roots
{
    static class Lang
    {
        static Dictionary<string, List<string>> locs { get; set; }
        const string defLanguage = "Русский";
        const string locFileName = "loc.json";

        public static Dictionary<string, List<string>> GetDict()
        {
            return locs;
        }

        public static bool LoadLoc()
        {
            if (locs == null)
            {
                try
                {
                    var path = Directory.GetParent(
                                Directory.GetParent(
                                 Directory.GetParent(
                                  Directory.GetCurrentDirectory()).FullName).FullName).FullName + "\\";
                    path += locFileName;

                    using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
                    {
                        string json = sr.ReadToEnd();
                        locs = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(json);
                    }
                }
                catch
                {
                    MessageBox.Show("Error", "Can not access \"loc.json\"");
                    return false;
                }

                return true;
            }
            else
                return true;
        }

        public static bool LoadLoc(string fileName)
        {
            Dictionary<string, List<string>> new_locs;

            try
            {
                string path = fileName;

                using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
                {
                    string json = sr.ReadToEnd();
                    new_locs = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(json);
                }
            }
            catch
            {
                MessageBox.Show("Can not access file: \"" + fileName + "\"", "Error");
                return false;
            }

            if (new_locs != null)
            {
                var dict = GetDict();
                int nNew = new_locs.Keys.Count;
                var keyNew = new_locs.Keys.ToList<string>();

                for (int i = 0; i < nNew; i++)
                {
                    if (!dict.ContainsKey(keyNew[i]))
                    {
                        dict.Add(keyNew[i], new_locs[keyNew[i]]);
                    }
                }
            }

            return true;
        }

        public static List<string>? GetLoc(string lang = defLanguage)
        {
            if (locs != null)
                return locs[lang];
            else
                return null;
        }
    }
}
