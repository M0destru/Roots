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
        const int elementsCount = 31;
        static string? curLang { get; set; }
        static Dictionary<string, List<string>> locs { get; set; }
        const string defLanguage = "Русский";
        const string locFileName = "loc.json";

        const string constError = "Ошибка";
        const string constAccess = "Невозможно получить доступ к файлу";

        static string sError;
        static string sAccess;

        public static Dictionary<string, List<string>> GetDict()
        {
            return locs;
        }

        public static bool LoadLoc()
        {
            curLang = null;
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
                    if (curLang == null)
                        MessageBox.Show(constAccess + " \"" + locFileName + "\"", constError);
                    else
                        MessageBox.Show(sAccess + " \"" + locFileName + "\"", sError);

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
                if (curLang == null)
                    MessageBox.Show(constAccess + " \"" + fileName + "\"", constError);
                else
                    MessageBox.Show(sAccess + " \"" + fileName + "\"", sError);

                return false;
            }

            if (new_locs != null)
            {
                var dict = GetDict();
                int nNew = new_locs.Keys.Count;
                var keyNew = new_locs.Keys.ToList<string>();

                for (int i = 0; i < nNew; i++)
                {
                    if (!dict.ContainsKey(keyNew[i]) && new_locs[keyNew[i]].Count >= elementsCount)
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
            {
                curLang = lang;
                return locs[lang];
            }
            else
                return null;
        }

        public static void ChangeLoc(List<string> text)
        {
            if (text != null)
            {
                sError = text[29];
                sAccess = text[30];
            }
        }

        public static string? CheckLoc()
        {
            if (locs != null)
                return curLang;
            else
                return null;
        }
    }
}
