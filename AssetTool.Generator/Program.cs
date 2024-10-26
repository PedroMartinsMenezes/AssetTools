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
            List<ClassData> list = ReadClassFiles(files);
            WriteClassFiles(config, list);
        }

        private static List<ClassData> ReadClassFiles(string[] files)
        {
            List<ClassData> list = [];
            foreach (string file in files)
            {
                string input = File.ReadAllText(file);
                string pattern = "class\\s*(?:[A-Z_]+)?\\s+(\\w+)\\s*:\\s*public\\s*([\\w<>]+)";
                ClassData classData = new();
                Regex regex = new Regex(pattern, RegexOptions.Multiline);
                var matches = regex.Matches(input);
                foreach (Match match in matches)
                {
                    if (match.Success)
                    {
                        classData.ClassName = match.Groups[1].Value;
                        classData.BaseClassName = match.Groups[2].Value;
                        list.Add(classData);
                        Console.WriteLine($"  {Path.GetFileName(file)} {classData.ClassName}");
                    }
                    else
                    {
                        Console.WriteLine($"x {Path.GetFileName(file)}");
                    }
                }
            }
            return list;
        }

        private static void WriteClassFiles(GeneratorConfig config, List<ClassData> list)
        {
            var dict = config.IgnoredClasses.ToHashSet();

            foreach (ClassData classData in list)
            {
                if (dict.Contains(classData.ClassName))
                    continue;

                StringBuilder classTemplate = new StringBuilder(ClassTemplate);
                string file = $"{config.OutputDir}\\{classData.ClassName}.cs";

                classTemplate.Replace("{ClassAttribute}", classData.ClassAttribute);
                classTemplate.Replace("{ClassName}", classData.ClassName);
                classTemplate.Replace("{BaseClassName}", classData.BaseClassName);

                string content = classTemplate.ToString();
                File.WriteAllText(file, content);
            }

            var simpleFiles = list.Where(x => !string.IsNullOrEmpty(x.BaseClassName)).ToList();
            foreach (ClassData classData in simpleFiles)
            {

                string className = classData.BaseClassName.Split('<')[0];
                if (dict.Contains(className))
                    continue;

                StringBuilder classTemplate = new StringBuilder(SimpleClassTemplate);

                string file = $"{config.OutputDir}\\{className}.cs";

                classTemplate.Replace("{ClassName}", className);
                classTemplate.Replace("{TypeName}", className.StartsWith('U') ? className.Substring(1) : classData.ClassName);

                string content = classTemplate.ToString();
                File.WriteAllText(file, content);
            }
        }
    }
}
