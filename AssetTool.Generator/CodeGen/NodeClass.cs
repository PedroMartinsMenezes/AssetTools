using System.Text;

namespace AssetTool.Generator.CodeGen
{
    public class NodeClass : Node
    {
        public string Name { get; set; }
        public string ParentName { get; set; }

        public override void BeginWrite(StringBuilder builder)
        {
            builder.Append($"{Indentation}public class {Name}{ParentName}\n{Indentation}{{\n");
        }

        public override void EndWrite(StringBuilder builder)
        {
            builder.Append($"{Indentation}\n");
        }

        public override void WriteContent(StringBuilder builder)
        {
            Children.ForEach(x => x.Write(builder));
        }
    }
}
