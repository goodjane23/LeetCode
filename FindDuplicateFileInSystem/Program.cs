using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDuplicateFileInSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //["root/a 1.txt(abcd) 2.txt(efgh)","root/c 3.txt(abcd)","root/c/d 4.txt(efgh)"]
            
            var res = FindDuplicate("root/a 1.txt(abcd) 2.txt(efgh),root/c 3.txt(abcd),root/c/d 4.txt(efgh)".Split(','));
            foreach (var items in res)
            {
                foreach (var item in items)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadLine();
        }

        public static IList<IList<string>> FindDuplicate(string[] paths)
        {
            var result = new List<IList<string>>();
            var files = new List<File>();

            //Pasing input string
            foreach (var path in paths)
            {
                var parsedPath = File.Parse(path);
                files.AddRange(parsedPath);
            }

            var duplicatesGroups = files.Select(x => new { file = x, fullName = $"{x.Path}/{x.Name}" })
                .GroupBy(x => x.file.Content)
                .Select(x => x.Select(file => file.fullName).ToList())
                .ToList();

            foreach (var duplicates in duplicatesGroups)
            {
                if (duplicates.Count < 2)
                    continue;

                result.Add(duplicates);
            }

            return result;
        }
    }

    
    public class File
    {
        public string Path { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        

        // Input Example
        // "root/a 1.txt(abcd) 2.txt(efgh)"
        // "root/c 3.txt(abcd)"
        // "root/c/d 4.txt(efgh)"
        public static List<File> Parse(string path)
        {
            var parts = path.Split(' ');
           
            List<File> files = new List<File>();
            if (parts.Length > 1)
            {
                for (int i = 1; i < parts.Length; i++)
                {
                    File file = new File();
                    file.Path = parts[0];
                    var lengthName = parts[i].IndexOf('(');
                    file.Name = parts[i].Substring(0, lengthName);
                    file.Content = parts[i].Substring(lengthName + 1, parts[i].Length - lengthName-2);
                    files.Add(file);
                }
            }
            return files;
        }
    }

}
