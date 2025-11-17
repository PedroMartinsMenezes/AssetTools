using System.Text;

namespace AssetTool.Generator.CodeGen
{
    public class NodeFunctionCall : Node
    {
        public string Name { get; set; }
        public string ParentName { get; set; }
        public string ReturnType { get; set; }
        public string Arguments { get; set; }

        public override void WriteContent(StringBuilder builder)
        {
            builder.Append($"{Indentation}{Name}({Arguments});");
        }
    }
}
