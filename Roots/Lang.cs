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
        const string locFileName = "loc.json";

        static bool LoadLoc()
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

        public static List<string>? GetLoc(string lang)
        {
            bool res = LoadLoc();
            if (res)
                return locs[lang];
            else
                return null;
        }
    }
}
