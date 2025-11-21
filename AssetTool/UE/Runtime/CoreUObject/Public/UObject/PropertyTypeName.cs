using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("{Type} {EnumName} {StructName}")]
    public class FPropertyTypeName : ITransferable
    {
        public List<FPropertyTypeNameNode> Nodes = [];

        public FName Type => Nodes[0].Name;

        public FName EnumName =>
            Nodes.Count < 3 ?
                default :
                Nodes[0].Name.Value is FByteProperty.TYPE_NAME or FEnumProperty.TYPE_NAME ?
                    Nodes[1].Name :
                    Nodes[0].Name.Value == Consts.ArrayProperty && Nodes[1].Name.Value is FByteProperty.TYPE_NAME or FEnumProperty.TYPE_NAME ?
                        Nodes[2].Name :
                        default;

        public FName StructName
        {
            get
            {
                if (Nodes[0].Name.Value is FStructProperty.TYPE_NAME)
                {
                    return Nodes[1].Name;
                }
                else if (Nodes[0].Name.Value is FArrayProperty.TYPE_NAME or FSetProperty.TYPE_NAME or FOptionalProperty.TYPE_NAME)
                {
                    if (Nodes.Count == 2) return Nodes[1].Name;
                    else if (Nodes.Count == 4) return Nodes[2].Name;
                    else return default;
                }
                return default;
            }
        }

        public FName InnerType
        {
            get
            {
                if (Nodes[0].Name.Value is FArrayProperty.TYPE_NAME or FSetProperty.TYPE_NAME or FOptionalProperty.TYPE_NAME)
                {
                    if (Nodes.Count == 2) return Nodes[1].Name;
                    else if (Nodes[1].Name.Value is FStructProperty.TYPE_NAME) return Nodes[1].Name;
                    else if (Nodes[1].Name.Value is FEnumProperty.TYPE_NAME) return Nodes[1].Name;
                    else return Nodes[1].Name;
                }
                return default;
            }
        }

        public FName KeyType
        {
            get
            {
                if (Nodes[0].Name.Value == FMapProperty.TYPE_NAME)
                {
                    if (Nodes.Count == 3) return Nodes[1].Name;
                    else if (Nodes[1].Name.Value is FStructProperty.TYPE_NAME) return Nodes[2].Name;
                    else if (Nodes[1].Name.Value is FEnumProperty.TYPE_NAME) return Nodes[1].Name;
                    else return Nodes[1].Name;
                }
                return default;
            }
        }

        public FName ValueType
        {
            get
            {
                if (Nodes[0].Name.Value == FMapProperty.TYPE_NAME)
                {
                    if (Nodes.Count == 3) return Nodes[2].Name;
                    else if (Nodes[1].Name.Value is FStructProperty.TYPE_NAME) return Nodes[4].Name;
                    else if (Nodes[1].Name.Value is FEnumProperty.TYPE_NAME) return Nodes[5].Name;
                    else return Nodes[2].Name;
                }
                return default;
            }
        }

        [Location("FArchive& operator<<(FArchive& Ar, FPropertyTypeName& TypeName)")]
        public ITransferable Move(Transfer transfer)
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
    public class FPropertyTypeNameNode : ITransferable
    {
        public FName Name;
        public int32 InnerCount;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Name);
            transfer.Move(ref InnerCount);
            return this;
        }
    };
}
