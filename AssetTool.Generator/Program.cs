using System.Text.Json;

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
            if (args.Length == 0 || args[0] == "UClasses")
            {
                FileHeaderTemplate = File.ReadAllText("Input/FileHeaderTemplate.txt");
                FileFooterTemplate = File.ReadAllText("Input/FileFooterTemplate.txt");
                FileBodyTemplate = File.ReadAllText("Input/FileBodyTemplate.txt");
                string json = File.ReadAllText("GeneratorConfig.json");
                config = JsonSerializer.Deserialize<GeneratorConfig>(json);
                string[] files = Directory.GetFiles(config.InputDir, "*.h", SearchOption.AllDirectories);

                var obj = new GenerateUClasses(config, FileHeaderTemplate, FileBodyTemplate, FileFooterTemplate);
                List<FileData> list = obj.ReadClassFiles(files);
                obj.WriteClassFiles(list);
            }
            else if (args[0] == "WithSerializerClasses")
            {
                FileHeaderTemplate = File.ReadAllText("Input/FileHeaderTemplate.txt");
                FileFooterTemplate = File.ReadAllText("Input/FileFooterTemplate.txt");
                FileBodyTemplate = File.ReadAllText("Input/FileBodyTemplateWithSerializer.txt");
                string json = File.ReadAllText("GeneratorConfig.json");
                config = JsonSerializer.Deserialize<GeneratorConfig>(json);
                string[] files = Directory.GetFiles(config.InputDir, "*.h", SearchOption.AllDirectories);

                var obj = new GenerateWithSerializerClasses(config, FileHeaderTemplate, FileBodyTemplate, FileFooterTemplate);
                List<FileData> list = obj.ReadClassFiles(files);
                obj.WriteClassFiles(list);
            }
        }
    }
}
