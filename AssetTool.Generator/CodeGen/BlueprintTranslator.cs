
namespace AssetTool.Generator
{
    public class BlueprintTranslator
    {
        public void GenerateCpp(string bluePrintFile)
        {
            AssetPackage asset = bluePrintFile.ReadJson<AssetPackage>();

            if (!asset.IsBlueprint())
            {
                Console.WriteLine($"Not a blueprint: {bluePrintFile}");
            }

            //contém os membros do blueprint
            UBlueprint blueprint = asset.Objects.Single(x => x.ClassName == "Blueprint").Get<UBlueprint>();

            //contém os membros do blueprint
            UBlueprintGeneratedClass blueprintGeneratedClass = asset.Objects.Single(x => x.ClassName == "BlueprintGeneratedClass" && !x.ObjectFlags.HasFlag(EObjectFlags.RF_ClassDefaultObject)).Get<UBlueprintGeneratedClass>();

            //contém os membros do blueprint
            UBlueprintGeneratedClass blueprintGeneratedClassDefault = asset.Objects.Single(x => x.ClassName == "BlueprintGeneratedClass" && x.ObjectFlags.HasFlag(EObjectFlags.RF_ClassDefaultObject)).Get<UBlueprintGeneratedClass>();

            //contém os nós que realmente importam
            UEdGraph eventGraph = asset.Objects.Single(x => x.ClassName == "EdGraph" && x.ObjectName == "EventGraph").Get<UEdGraph>();

            //ordenando os índices dos nodes
            List<int> nodes = eventGraph.Nodes().OrderBy(x => x).ToList();

            //removendo os índices dos comentários
            List<int> validNodes = nodes.Where(x => asset.Objects[x - 1].ClassName != "EdGraphNode_Comment").ToList();


        }

        //private void GenerateClasses()
        //{
        //    string path = "C:\\UE\\AssetTools\\AssetTool.Generator\\CodeGen\\";

        //    string pathNames = "C:\\UE\\AssetTools\\AssetTool\\UE\\Editor\\BlueprintGraph\\Classes\\saida.txt";

        //    string templatePath = "C:\\UE\\AssetTools\\AssetTool.Generator\\CodeGen\\NodeExample.cs";

        //    string content = File.ReadAllText(templatePath);

        //    string[] names = File.ReadAllLines(pathNames);

        //    foreach (string name in names)
        //    {
        //        File.WriteAllText(path + name + ".cs", content.Replace("NodeName", name));
        //    }
        //}
    }
}
