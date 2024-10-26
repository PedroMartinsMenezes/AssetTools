using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace AssetTool.Generator
{
    public class Program
    {
        static string ClassTemplate = string.Empty;
        static string SimpleClassTemplate = string.Empty;

        static void Main(string[] args)
        {
            ClassTemplate = File.ReadAllText("Input/ClassTemplate.txt");
            SimpleClassTemplate = File.ReadAllText("Input/SimpleClassTemplate.txt");
            string json = File.ReadAllText("GeneratorConfig.json");
            GeneratorConfig config = JsonSerializer.Deserialize<GeneratorConfig>(json);
            string[] files = Directory.GetFiles(config.InputDir, "*.h");
            List<FileData> list = ReadClassFiles(files);
            WriteClassFiles(config, list);
        }

        private static List<FileData> ReadClassFiles(string[] files)
        {
            List<FileData> list = [];
            foreach (string file in files)
            {
                FileData fileData = new();
                list.Add(fileData);
                fileData.FileName = Path.GetFileNameWithoutExtension(file);
                string input = File.ReadAllText(file);
                string pattern = @"UCLASS\(.*\)\s+class\s+(\w+)\s*:\s*public\s+(\w+)";
                Regex regex = new Regex(pattern, RegexOptions.Multiline);
                var matches = regex.Matches(input);
                foreach (Match match in matches)
                {
                    if (match.Success)
                    {
                        ClassData classData = new();
                        classData.ClassName = match.Groups[1].Value;
                        classData.BaseClassName = match.Groups[2].Value;
                        fileData.Classes.Add(classData);
                        Console.WriteLine($"  {fileData.FileName}.h: class {classData.ClassName} : {classData.BaseClassName}");
                    }
                }
            }
            list = list.Where(x => x.Classes.Count > 0).ToList();
            return list;
        }

        private static void WriteClassFiles(GeneratorConfig config, List<FileData> files)
        {
            var dict = config.IgnoredClasses.ToHashSet();
            foreach (FileData fileData in files)
            {
                StringBuilder content = new StringBuilder(ClassTemplate);
                foreach (ClassData classData in fileData.Classes)
                {
                    if (dict.Contains(classData.ClassName))
                        continue;

                    content.Replace("{ClassAttribute}", classData.ClassAttribute);
                    content.Replace("{ClassName}", classData.ClassName);
                    content.Replace("{BaseClassName}", classData.BaseClassName);

                }
                string path = $"{config.OutputDir}\\{fileData.FileName}.cs";
                File.WriteAllText(path, content.ToString());
            }

            //var simpleFiles = list.Where(x => !string.IsNullOrEmpty(x.BaseClassName)).ToList();
            //foreach (ClassData classData in simpleFiles)
            //{

            //    string className = classData.BaseClassName.Split('<')[0];
            //    if (dict.Contains(className))
            //        continue;

            //    StringBuilder classTemplate = new StringBuilder(SimpleClassTemplate);

            //    string file = $"{config.OutputDir}\\{className}.cs";

            //    classTemplate.Replace("{ClassName}", className);
            //    classTemplate.Replace("{TypeName}", className.StartsWith('U') ? className.Substring(1) : classData.ClassName);

            //    string content = classTemplate.ToString();
            //    File.WriteAllText(file, content);
            //}
        }
    }
}
