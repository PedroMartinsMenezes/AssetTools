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

        public FName KeyTypeOld
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

        public FName ValueTypeOld
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

        public string MapKeyType
        {
            get
            {
                if (Nodes[0].Name.Value == FMapProperty.TYPE_NAME)
                {
                    for (int i = 1; i < Nodes.Count; i++)
                    {
                        if (Nodes[i].Name.Value == "ByteProperty")
                            return Nodes[i].Name.Value;
                        else if (Nodes[i].Name.Value == "EnumProperty")
                            return Nodes[i].Name.Value;
                        else if (Nodes[i].Name.Value == "StructProperty")
                            return Nodes[i + 1].Name.Value;
                        else if (Nodes[i].InnerCount == 0)
                            return Nodes[i].Name.Value;
                        else
                            throw new InvalidOperationException(NodesString);
                    }
                }
                return null;
            }
        }
        public string MapValueType
        {
            get
            {
                if (Nodes[0].Name.Value == FMapProperty.TYPE_NAME)
                {
                    int i = 0, skipCount = 0;
                    for (i = 1; i < Nodes.Count && skipCount >= 0; i++)
                    {
                        skipCount += Nodes[i].InnerCount;
                        skipCount--;
                    }
                    while (i < Nodes.Count)
                    {
                        if (Nodes[i].Name.Value == "ByteProperty")
                            return Nodes[i].Name.Value;
                        else if (Nodes[i].Name.Value == "EnumProperty")
                            return Nodes[i].Name.Value;
                        else if (Nodes[i].Name.Value == "StructProperty")
                            return Nodes[i + 1].Name.Value;
                        else if (Nodes[i].InnerCount == 0)
                            return Nodes[i].Name.Value;
                        else
                            throw new InvalidOperationException(NodesString);
                    }
                }
                return null;
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
