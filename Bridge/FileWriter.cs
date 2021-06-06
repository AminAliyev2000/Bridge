using Bridge.Interfacex;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace Bridge
{
    public class FileWriter : IWriter
    {
        public void Write(string text)
        {

            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter("JsonWriter.json", true))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    serializer.Serialize(jw, text);
                }
            }
        }
    }
}
