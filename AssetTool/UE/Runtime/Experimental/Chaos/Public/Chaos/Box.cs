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
}
