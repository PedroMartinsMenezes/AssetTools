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
                var match = regex.Match(input);
                if (match.Success)
                {
                    classData.ClassName = match.Groups[1].Value;
                    classData.BaseClassName = match.Groups[2].Value;
                    list.Add(classData);
                }
            }
            return list;
        }

        private static void WriteClassFiles(GeneratorConfig config, List<ClassData> list)
        {
            foreach (ClassData classData in list)
            {
                string file = $"{config.OutputDir}\\{classData.ClassName}.cs";
                string content = ClassTemplate.Replace("{ClassName}", classData.ClassName).Replace("{BaseClassName}", classData.BaseClassName);
                File.WriteAllText(file, content);

            }

            var simpleFiles = list.Where(x => !string.IsNullOrEmpty(x.BaseClassName)).ToList();
            foreach (ClassData classData in simpleFiles)
            {
                string className = classData.BaseClassName.Split('<')[0];
                string file = $"{config.OutputDir}\\{className}.cs";
                string content = SimpleClassTemplate.Replace("{ClassName}", className);
                File.WriteAllText(file, content);
            }
        }
    }
}
