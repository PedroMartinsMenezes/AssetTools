using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool.Chaos
{
    [DebuggerDisplay("{AABB} Margin({MarginFloat})")]
    public class TBox3 : FImplicitObject
    {
        public TAABB3 AABB;
        public float MarginFloat;

        [Location("FORCEINLINE void SerializeImp(FArchive& Ar) at 451")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref AABB);
            if (transfer.Supports.MarginAddedToConvexAndBox)
            {
                transfer.Move(ref MarginFloat);
            }
            return this;
        }
    }

    [DebuggerDisplay("{AABB}")]
    public class SerializeAsAABB3 : ITransferable
    {
        public TBox3 Tmp;
        public TAABB3 AABB;

        public ITransferable Move(Transfer transfer)
        {
            if (!transfer.Supports.TBoxReplacedWithTAABB)
                transfer.Move(ref Tmp);
            else
                transfer.Move(ref AABB);
            return this;
        }
    }

    public class SerializeAsAABB3JsonConverter : JsonConverter<SerializeAsAABB3>
    {
        public override SerializeAsAABB3 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string s = reader.GetString();
            string[] v = s.Split(' ');
            if (v.Length == 7)
            {
                return new SerializeAsAABB3
                {
                    Tmp = new TBox3
                    {
                        AABB = new TAABB3
                        {
                            MMin = new TVector3 { X = float.Parse(v[0]), Y = float.Parse(v[1]), Z = float.Parse(v[2]) },
                            MMax = new TVector3 { X = float.Parse(v[3]), Y = float.Parse(v[4]), Z = float.Parse(v[5]) }
                        },
                        MarginFloat = float.Parse(v[6])
                    }
                };
            }
            else if (v.Length == 6)
            {
                return new SerializeAsAABB3
                {
                    AABB = new TAABB3
                    {
                        MMin = new TVector3 { X = float.Parse(v[0]), Y = float.Parse(v[1]), Z = float.Parse(v[2]) },
                        MMax = new TVector3 { X = float.Parse(v[3]), Y = float.Parse(v[4]), Z = float.Parse(v[5]) }
                    }
                };
            }
            else
            {
                return new SerializeAsAABB3();
            }
        }
        public override void Write(Utf8JsonWriter writer, SerializeAsAABB3 value, JsonSerializerOptions options)
        {
            if (value.Tmp is { })
            {
                writer.WriteStringValue($"{value.Tmp.AABB.MMin.X} {value.Tmp.AABB.MMin.Y} {value.Tmp.AABB.MMin.Z} {value.Tmp.AABB.MMax.X} {value.Tmp.AABB.MMax.Y} {value.Tmp.AABB.MMax.Z} {value.Tmp.MarginFloat}");
            }
            else if (value.AABB is { })
            {
                writer.WriteStringValue($"{value.AABB.MMin.X} {value.AABB.MMin.Y} {value.AABB.MMin.Z} {value.AABB.MMax.X} {value.AABB.MMax.Y} {value.AABB.MMax.Z}");
            }
            else
            {
                writer.WriteStringValue(string.Empty);
            }
        }
    }

    public class SerializeAsAABBs : ITransferable
    {
        public Dictionary<TInt32, TBox3> Tmp;
        public Dictionary<TInt32, TAABB3> AABBs;

        public ITransferable Move(Transfer transfer)
        {
            if (!transfer.Supports.TBoxReplacedWithTAABB)
                transfer.Move(ref Tmp);
            else
                transfer.Move(ref AABBs);
            return this;
        }
    }

    public class SerializeAsAABBsJsonConverter : JsonConverter<SerializeAsAABBs>
    {
        public override SerializeAsAABBs Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string s = reader.GetString();
            string[] items = s.Split(" | ");
            if (items.Length > 0)
            {
                string[] first = items[0].Split(' ');
                if (first.Length == 9)
                {
                    Dictionary<TInt32, TBox3> dict = [];
                    for (int i = 0; i < items.Length; i++)
                    {
                        string[] v = items[i].Split(' ');
                        TInt32 key = new TInt32 { Value = int.Parse(v[0]) };
                        TBox3 value = new TBox3
                        {
                            AABB = new TAABB3
                            {
                                MMin = new TVector3 { X = float.Parse(v[2]), Y = float.Parse(v[3]), Z = float.Parse(v[4]) },
                                MMax = new TVector3 { X = float.Parse(v[5]), Y = float.Parse(v[6]), Z = float.Parse(v[7]) }
                            },
                            MarginFloat = float.Parse(v[8])
                        };
                        dict.Add(key, value);
                    }
                    return new SerializeAsAABBs { Tmp = dict };
                }
                else if (first.Length == 8)
                {
                    Dictionary<TInt32, TAABB3> dict = [];
                    for (int i = 0; i < items.Length; i++)
                    {
                        string[] v = items[i].Split(' ');
                        TInt32 key = new TInt32 { Value = int.Parse(v[0]) };
                        TAABB3 value = new TAABB3
                        {
                            MMin = new TVector3 { X = float.Parse(v[2]), Y = float.Parse(v[3]), Z = float.Parse(v[4]) },
                            MMax = new TVector3 { X = float.Parse(v[5]), Y = float.Parse(v[6]), Z = float.Parse(v[7]) }
                        };
                        dict.Add(key, value);
                    }
                    return new SerializeAsAABBs { AABBs = dict };
                }
                else
                {
                    return new SerializeAsAABBs();
                }
            }
            else
            {
                return new SerializeAsAABBs();
            }

        }
        public override void Write(Utf8JsonWriter writer, SerializeAsAABBs value, JsonSerializerOptions options)
        {
            if (value.Tmp is { })
            {
                writer.WriteStringValue(string.Join(" | ", value.Tmp.Select(x => $"{x.Key.Value} : {x.Value.AABB.MMin.X} {x.Value.AABB.MMin.Y} {x.Value.AABB.MMin.Z} {x.Value.AABB.MMax.X} {x.Value.AABB.MMax.Y} {x.Value.AABB.MMax.Z} {x.Value.MarginFloat}")));
            }
            else if (value.AABBs is { })
            {
                writer.WriteStringValue(string.Join(" | ", value.AABBs.Select(x => $"{x.Key.Value} : {x.Value.MMin.X} {x.Value.MMin.Y} {x.Value.MMin.Z} {x.Value.MMax.X} {x.Value.MMax.Y} {x.Value.MMax.Z}")));
            }
            else
            {
                writer.WriteStringValue(string.Empty);
            }
        }
    }
}
