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
	//количество элементов интрефейса
        const int elementsCount = 36;
        static string? curLang { get; set; }
	//словарь переводов: название языка и список переведенных строк
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

	//получение предусмотренных переводов на русский и английский язык
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

	//загрузка перевода из языкового файла формата json по указанному пути
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
                    //добавление перевода с переименованием всех заявленных элементов интерфейса на новый язык
                    if (!dict.ContainsKey(keyNew[i]) && new_locs[keyNew[i]].Count >= elementsCount)
                    {
                        dict.Add(keyNew[i], new_locs[keyNew[i]]);
                    }
                }
            }

            return true;
        }

	//получение переведенных строк текущей локализации
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

	//проверка загрузки локализаций
        public static string? CheckLoc()
        {
            if (locs != null)
                return curLang;
            else
                return null;
        }
    }
}
