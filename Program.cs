using System;
using System.IO;
using System.Reflection;

namespace Encoding
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            Console.WriteLine($"Path donde se está ejecutando la app: {path}");

            foreach (var f in new DirectoryInfo(path).GetFiles("*.vb", SearchOption.AllDirectories))
            {
                string s = File.ReadAllText(f.FullName);
                File.WriteAllText(f.FullName, s, System.Text.Encoding.UTF8);
            }

            foreach (var f in new DirectoryInfo(path).GetFiles("*.cs", SearchOption.AllDirectories))
            {
                string s = File.ReadAllText(f.FullName);
                File.WriteAllText(f.FullName, s, System.Text.Encoding.UTF8);
            }
        }
    }
}
