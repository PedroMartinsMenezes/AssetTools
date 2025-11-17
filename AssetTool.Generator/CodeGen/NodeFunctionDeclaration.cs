using System.Text;

namespace AssetTool.Generator.CodeGen
{
    public class NodeFunctionDeclaration : Node
    {
        public string Name { get; set; }
        public string ParentName { get; set; }
        public string ReturnType { get; set; }
        public string Arguments { get; set; }

        public override void BeginWrite(StringBuilder builder)
        {
            builder.Append($"{Indentation}public {ReturnType} {Name}({Arguments})\n{Indentation}{{\n");
        }

        public override void EndWrite(StringBuilder builder)
        {
            builder.Append($"{Indentation}\n");
        }

        public override void WriteContent(StringBuilder builder)
        {
            BeginWrite(builder);
            Children.ForEach(x => x.Write(builder));
            EndWrite(builder);
        }
    }
}
