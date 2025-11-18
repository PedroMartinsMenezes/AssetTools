using System.Diagnostics;
using System.Text;

namespace AssetTool.Generator.CodeGen
{
    [DebuggerDisplay("[{Index}] {MemberName ?? ObjectName}")]
    public class Node
    {
        public string Indentation { get; set; }
        public string Content { get; set; }
        public string ObjectName { get; set; }
        public string MemberName { get; set; }
        public int Index { get; set; }

        public List<Node> InputNodes { get; set; }
        public List<Node> OutputNodes { get; set; }
        public List<Pin> InputPins { get; set; }
        public List<Pin> OutputPins { get; set; }

        public Node()
        {
        }

        public Node(int index, AssetPackage package, Dictionary<string, UEdGraphPin> pins)
        {
            AssetObject obj = package.Objects[index];

            UK2Node baseNode = obj.Get<UK2Node>();

            Index = obj.Index;

            ObjectName = obj.ObjectName;

            MemberName = NodeExtensions.GetMemberName(obj.ClassName, baseNode, package);

            InputPins = baseNode.Pins.Where(x => x.Direction == EEdGraphPinDirection.EGPD_Input).Select(x => new Pin(x, pins)).ToList();

            OutputPins = baseNode.Pins.Where(x => x.Direction == EEdGraphPinDirection.EGPD_Output).Select(x => new Pin(x, pins)).ToList();
        }

        public void Write(StringBuilder builder)
        {
            BeginWrite(builder);
            WriteContent(builder);
            EndWrite(builder);
        }

        public virtual void BeginWrite(StringBuilder builder)
        {
        }

        public virtual void EndWrite(StringBuilder builder)
        {
        }

        public virtual void WriteContent(StringBuilder builder)
        {
        }
    }
}
