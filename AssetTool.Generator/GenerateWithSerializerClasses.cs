using System.Text.RegularExpressions;
using System.Text;

namespace AssetTool.Generator
{
    public class GenerateWithSerializerClasses
    {
        private readonly GeneratorConfig config;
        private readonly string FileHeaderTemplate;
        private readonly string FileBodyTemplate;
        private readonly string FileFooterTemplate;

        public GenerateWithSerializerClasses(GeneratorConfig config, string FileHeaderTemplate, string FileBodyTemplate, string FileFooterTemplate)
        {
            this.config = config;
            this.FileHeaderTemplate = FileHeaderTemplate;
            this.FileBodyTemplate = FileBodyTemplate;
            this.FileFooterTemplate = FileFooterTemplate;
        }

        public List<FileData> ReadClassFiles(string[] files)
        {
            Console.WriteLine("Reading files...");
            List<FileData> list = [];
            foreach (string file in files)
            {
                FileData fileData = new();
                list.Add(fileData);
                fileData.FileName = Path.GetRelativePath(config.InputDir, file);
                string input = File.ReadAllText(file);
                string pattern = @"$\s*bool\s+(\w+)\s*::\s*Serialize\(";
                Regex regex = new Regex(pattern, RegexOptions.Multiline);
                var matches = regex.Matches(input);
                foreach (Match match in matches)
                {
                    if (match.Success)
                    {
                        ClassData classData = new();
                        classData.ClassName = match.Groups[1].Value.Trim();
                        fileData.Classes.Add(classData);
                    }
                }
            }
            list = list.Where(x => x.Classes.Count > 0).ToList();
            Console.WriteLine(".");
            return list;
        }

        public void WriteClassFiles(List<FileData> files)
        {
            Console.WriteLine("Writing files...");
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
                string ext = Path.GetExtension(fileData.FileName);
                string path = $"{config.OutputDir}\\{fileData.FileName}".Replace(ext, ".cs");

                if (!Directory.Exists(Path.GetDirectoryName(path)))
                    Directory.CreateDirectory(Path.GetDirectoryName(path));

                if (File.Exists(path))
                    path = path.Replace(".cs", ".2.cs");

                File.WriteAllText(path, content.ToString());
            }
            Console.WriteLine(".");
        }
    }
}
