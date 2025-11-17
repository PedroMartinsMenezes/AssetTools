using System.Text;

namespace AssetTool.Generator.CodeGen
{
    public class K2Node_IfThenElse : Node
    {
        public string Condition { get; set; }
        public Node ChildTrue { get; set; }
        public Node ChildFalse { get; set; }

        public override void WriteContent(StringBuilder builder)
        {
            if (ChildTrue is { })
            {
                builder.Append($"{Indentation}if ({Condition})\n{Indentation}{{\n");
                ChildTrue.WriteContent(builder);
                builder.Append($"{Indentation}}}\n");
            }

            if (ChildTrue is { } && ChildFalse is { })
            {
                builder.Append($"{Indentation}else\n");
            }

            if (ChildFalse is { })
            {
                if (ChildTrue is null)
                {
                    builder.Append($"{Indentation}if (!{Condition})\n{{\n");
                }
                else
                {
                    builder.Append($"{Indentation}{{\n");
                }
                ChildFalse.WriteContent(builder);
                builder.Append($"{Indentation}}}\n");
            }
        }
    }
}
