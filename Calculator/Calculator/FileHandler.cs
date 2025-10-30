using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal static class FileHandler
    {
        public static string ReadFromFile(string path)
        {
            FileStream file = new FileStream(path, FileMode.Open);
            StreamReader reader = new StreamReader(file);
            string content = reader.ReadToEnd();
            reader.Close();

            return content;
        }
    }
}
