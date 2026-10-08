using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{NodesString}")]
    public class FPropertyTypeName : ITransferable
    {
        public List<FPropertyTypeNameNode> Nodes = [];

        [JsonIgnore] string NodesString => string.Join(" | ", Nodes.Select(x => $"{x.Name} {x.InnerCount}"));

        public FName Type => Nodes[0].Name;

        public FName EnumName =>
            Nodes.Count < 3 ?
                default :
                Nodes[0].Name.Value is FByteProperty.TYPE_NAME or FEnumProperty.TYPE_NAME ?
                    Nodes[1].Name :
                    Nodes[0].Name.Value == FArrayProperty.TYPE_NAME && Nodes[1].Name.Value is FByteProperty.TYPE_NAME or FEnumProperty.TYPE_NAME ?
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
                    else if (Nodes.Count >= 4) return Nodes[2].Name;
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

        public string KeyType
        {
            get
            {
                string result = null;
                if (Nodes[0].Name.Value == FMapProperty.TYPE_NAME)
                {
                    int i = Nodes.FindIndex(x => x.InnerCount == 0);
                    if (i > 0)
                        result = string.Join(' ', Nodes.Where((x, index) => index > 0 && index <= i && x.Name.Value[0] != '/').Select(x => x.Name.Value));
                }
                return result;
            }
        }
        public string ValueType
        {
            get
            {
                string result = null;
                if (Nodes[0].Name.Value == FMapProperty.TYPE_NAME)
                {
                    int i = Nodes.FindIndex(x => x.InnerCount == 0);
                    if (i > 0)
                        result = string.Join(' ', Nodes.Where((x, index) => index > i && x.Name.Value[0] != '/').Select(x => x.Name.Value));
                }
                return result;
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

        public override string ToString()
        {
            return string.Join(" | ", Nodes.Select(x => $"{x.Name} {x.InnerCount}"));
        }

        public FPropertyTypeName FromString(string str)
        {
            string[] nodes = str.Split(" | ").Select(x => x.Trim()).ToArray();
            Nodes = nodes.Select(x => new FPropertyTypeNameNode
            {
                Name = new FName(x[0..x.IndexOf(' ')]),
                InnerCount = int.Parse(x[(x.IndexOf(' ') + 1)..])
            })
            .ToList();
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
    }

    public class FPropertyTypeNameJsonConverter : JsonConverter<FPropertyTypeName>
    {
        public override FPropertyTypeName Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new FPropertyTypeName().FromString(reader.GetString());
        }

        public override void Write(Utf8JsonWriter writer, FPropertyTypeName value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }

    public class FPropertyTypeNameReplica
    {
        public List<FPropertyTypeNameNode> Nodes = [];
    }
}
