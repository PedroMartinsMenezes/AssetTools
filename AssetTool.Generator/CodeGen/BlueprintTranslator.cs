
using AssetTool.Generator.CodeGen;

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
            List<int> indices = eventGraph.Nodes().OrderBy(x => x).ToList();

            //removendo os índices dos comentários
            List<int> validIndices = indices.Where(x => asset.Objects[x - 1].ClassName != "EdGraphNode_Comment").ToList();

            //Dictionary<string, UEdGraphPin> pins = GetPins(validIndices, asset);

            //Listando os nodes do EventGraph
            List<Node> nodes = GetNodes(validIndices, asset);

            //Listando os nodes do tipo FlowNode
            List<Node> flowNodes = nodes.GetFlowNodes();

            //Listando os FlowNode que iniciam o fluxo
            List<Node> initialNodes = flowNodes.GetInitialNodes();
        }

        private Dictionary<string, UEdGraphPin> GetPins(List<int> indices, AssetPackage asset)
        {
            Dictionary<string, UEdGraphPin> pins = [];
            foreach (int index in indices)
            {
                AssetObject obj = asset.Objects[index - 1];
                UK2Node baseNode = obj.Get<UK2Node>();
                foreach (UEdGraphPin pin in baseNode.Pins)
                {
                    pins[pin.PinGuid.ToString()] = pin;
                }
            }
            return pins;
        }

        private List<Node> GetNodes(List<int> indices, AssetPackage asset)
        {
            Dictionary<string, UEdGraphPin> pins = GetPins(indices, asset);
            List<Node> nodes = [];
            foreach (int index in indices)
            {
                Node node = new Node(index - 1, asset, pins);
                nodes.Add(node);
            }
            return nodes;
        }
    }
}
