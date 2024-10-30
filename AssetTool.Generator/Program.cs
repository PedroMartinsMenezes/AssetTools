using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace AssetTool.Generator
{
    public class Program
    {
        static GeneratorConfig config;
        static string FileHeaderTemplate = string.Empty;
        static string FileFooterTemplate = string.Empty;
        static string FileBodyTemplate = string.Empty;

        static void Main(string[] args)
        {
            FileHeaderTemplate = File.ReadAllText("Input/FileHeaderTemplate.txt");
            FileFooterTemplate = File.ReadAllText("Input/FileFooterTemplate.txt");
            FileBodyTemplate = File.ReadAllText("Input/FileBodyTemplate.txt");
            string json = File.ReadAllText("GeneratorConfig.json");
            config = JsonSerializer.Deserialize<GeneratorConfig>(json);
            string[] files = Directory.GetFiles(config.InputDir, "*.h", SearchOption.AllDirectories);
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
                fileData.FileName = Path.GetRelativePath(config.InputDir, file);
                string input = File.ReadAllText(file);
                string pattern = @"UCLASS\(.*\)\s+class\s+(?:[A-Z0-9_]+\s+)?(\w+)\s*(?:\s*final\s*)?:\s*public\s*(\w+)";
                Regex regex = new Regex(pattern, RegexOptions.Multiline);
                var matches = regex.Matches(input);
                foreach (Match match in matches)
                {
                    if (match.Success)
                    {
                        ClassData classData = new();
                        classData.ClassName = match.Groups[1].Value.Trim();
                        classData.BaseClassName = match.Groups[2].Value.Trim();
                        fileData.Classes.Add(classData);
                        Console.WriteLine($"  {fileData.FileName}: class {classData.ClassName} : {classData.BaseClassName}");
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
                StringBuilder content = new StringBuilder();
                content.Append(FileHeaderTemplate);
                foreach ((ClassData classData, int i) in fileData.Classes.Select((x, i) => (x, i)))
                {
                    if (dict.Contains(classData.ClassName))
                        continue;

                    StringBuilder body = new StringBuilder(FileBodyTemplate);
                    body.Replace("{ClassAttribute}", classData.ClassAttribute);
                    body.Replace("{ClassName}", classData.ClassName);
                    body.Replace("{BaseClassName}", classData.BaseClassName);

                    if (i > 0)
                        content.AppendLine();
                    content.AppendLine().Append(body);
                }
                content.AppendLine().Append(FileFooterTemplate);
                string path = $"{config.OutputDir}\\{fileData.FileName}".Replace(".h", ".cs");
                if (!Directory.Exists(Path.GetDirectoryName(path)))
                    Directory.CreateDirectory(Path.GetDirectoryName(path));
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
