using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Giezi.Tools
{
    public static class InputSystemLocalisation
    {
        private static Dictionary<(string, string), string> _localizedInputs = null;
        
        public static string GetTranslation(string input, string language)
        {
            if (_localizedInputs == null)
                InitialiseLocalisedInputs();

            if (_localizedInputs.TryGetValue((language, input), out string value))
                return value;
            
            return input;
        }

        private static void InitialiseLocalisedInputs()
        {
            _localizedInputs = new Dictionary<(string, string), string>();
            TextAsset textAsset = Resources.Load<TextAsset>("InputKeysDictionary");
            List<string> lines = textAsset.text.Split('\n').ToList();
            string[] languages = lines[0].Split(',');
            int nbEntries = languages.Length;
            
            lines = lines.Skip(1).ToList();
            foreach (string line in lines)
            {
                string[] entries = line.Split(',');
                if(entries.Length != nbEntries)
                    continue;
                
                for (int i = 0; i < nbEntries; i++)
                {
                    _localizedInputs.Add((languages[i].Trim(), entries[0].Trim()), entries[i].Trim());
                }
            }
            Debug.Log(_localizedInputs);
        }
    }
}