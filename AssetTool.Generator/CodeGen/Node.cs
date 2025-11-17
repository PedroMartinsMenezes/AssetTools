using System.Text;

namespace AssetTool.Generator.CodeGen
{
    public abstract class Node
    {
        public Node Parent { get; set; }
        public List<Node> Children { get; set; }
        public string Indentation { get; set; }

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

        public abstract void WriteContent(StringBuilder builder);
    }
}
