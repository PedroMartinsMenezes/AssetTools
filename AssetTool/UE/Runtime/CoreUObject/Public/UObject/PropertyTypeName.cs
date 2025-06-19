using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("{Type} {EnumName} {StructName}")]
    public class FPropertyTypeName : ITransferible
    {
        public List<FPropertyTypeNameNode> Nodes = [];

        public FName Type => Nodes[0].Name;

        public FName EnumName =>
            Nodes.Count < 3 ?
                null :
                Nodes[0].Name.Value is FByteProperty.TYPE_NAME or FEnumProperty.TYPE_NAME ?
                    Nodes[1].Name :
                    Nodes[0].Name.Value == Consts.ArrayProperty && Nodes[1].Name.Value is FByteProperty.TYPE_NAME or FEnumProperty.TYPE_NAME ?
                        Nodes[2].Name :
                        null;

        public FName StructName =>
            Nodes.Count < 2 ?
                null :
                Nodes.Count < 4 ?
                    Nodes[0].Name.Value == FStructProperty.TYPE_NAME ?
                        Nodes[1].Name :
                        null :
                Nodes[0].Name.Value == Consts.ArrayProperty && Nodes[1].Name.Value == FStructProperty.TYPE_NAME ?
                    Nodes[2].Name :
                    null;

        public FName InnerType =>
            Nodes.Count < 2 ?
                null :
                Nodes.Count < 7 ?
                    Nodes[0].Name.Value is FMapProperty.TYPE_NAME or FSetProperty.TYPE_NAME or Consts.ArrayProperty or Consts.OptionalProperty ?
                    Nodes[1].Name :
                    null :
                Nodes[0].Name.Value is FMapProperty.TYPE_NAME ?
                    Nodes[2].Name :
                    null;

        public FName ValueType =>
            Nodes.Count < 2 ?
                null :
                Nodes.Count < 7 ?
                    Nodes[0].Name.Value is FMapProperty.TYPE_NAME ?
                    Nodes[2].Name :
                    null :
                Nodes[0].Name.Value is FMapProperty.TYPE_NAME ?
                    Nodes[5].Name :
                    null;

        [Location("FArchive& operator<<(FArchive& Ar, FPropertyTypeName& TypeName)")]
        public ITransferible Move2(Transfer transfer)
        {
            int i = 0;
            int32 Remaining = 1;
            do
            {
                FPropertyTypeNameNode node = transfer.IsReading ? new FPropertyTypeNameNode() : Nodes[i++];
                transfer.Move(ref node);
                Remaining += node.InnerCount - 1;
                if (transfer.IsReading)
                {
                    Nodes.Add(node);
                }
            }
            while (Remaining > 0);
            return this;
        }
    }

    [DebuggerDisplay("{Name} {InnerCount}")]
    public class FPropertyTypeNameNode : ITransferible
    {
        public FName Name;
        public int32 InnerCount;

        public ITransferible Move2(Transfer transfer)
        {
            transfer.Move(ref Name);
            transfer.Move(ref InnerCount);
            return this;
        }
    };
}
