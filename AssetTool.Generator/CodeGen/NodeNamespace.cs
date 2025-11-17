using System.Text;

namespace AssetTool.Generator.CodeGen
{
    public class NodeNamespace : Node
    {
        public string Name { get; set; }

        public override void BeginWrite(StringBuilder builder)
        {
            builder.Append($"namespace {Name}\n{{\n");
        }

        public override void EndWrite(StringBuilder builder)
        {
            builder.Append("}\n");
        }

        public override void WriteContent(StringBuilder builder)
        {
            Children.ForEach(x => x.Write(builder));
        }
    }
}
