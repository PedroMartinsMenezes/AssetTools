using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace AssetTool.Chaos
{
    [Location("https://github.com/EpicGames/UnrealEngine/blob/release/Engine/Source/Runtime/Experimental/Chaos/Public/Chaos/ConvexHalfEdgeStructureData.h")]
    [DebuggerDisplay("Planes({Planes.Count}) HalfEdges({HalfEdges.Count}) Vertices({Vertices.Count}) Edges({Edges.Count})")]
    public class TConvexHalfEdgeStructureData<FIndex> : ITransferable where FIndex : ITransferable, new()
    {
        public List<FPlaneData<FIndex>> Planes;
        public List<FHalfEdgeData<FIndex>> HalfEdges;
        public List<FVertexData<FIndex>> Vertices;
        public List<FIndex> Edges;

        [Location("void Serialize(FArchive& Ar) at 556")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Planes);
            transfer.Move(ref HalfEdges);
            transfer.Move(ref Vertices);
            if (transfer.Supports.ChaosConvexHasUniqueEdgeSet)
            {
                transfer.Move(ref Edges);
            }
            return this;
        }
    }

    #region FPlaneData
    [DebuggerDisplay("{FirstHalfEdgeIndex} {NumHalfEdges}")]
    public class FPlaneData<FIndex> : ITransferable where FIndex : ITransferable, new()
    {
        public FIndex FirstHalfEdgeIndex;
        public FIndex NumHalfEdges;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref FirstHalfEdgeIndex);
            transfer.Move(ref NumHalfEdges);
            return this;
        }
    }

    public class FPlaneDataJsonConverterTInt32 : JsonConverter<List<FPlaneData<TInt32>>>
    {
        public override List<FPlaneData<TInt32>> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string s = reader.GetString();
            return s.Length == 0 ? [] : s.Split(" | ").Select(x => new FPlaneData<TInt32>()
            {
                FirstHalfEdgeIndex = new() { Value = Int32.Parse(x[0..x.IndexOf(' ')]) },
                NumHalfEdges = new() { Value = Int32.Parse(x[(x.IndexOf(' ') + 1)..]) }
            }).ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<FPlaneData<TInt32>> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => $"{x.FirstHalfEdgeIndex} {x.NumHalfEdges}")));
        }
    }

    public class FPlaneDataJsonConverterTInt16 : JsonConverter<List<FPlaneData<TInt16>>>
    {
        public override List<FPlaneData<TInt16>> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string s = reader.GetString();
            return s.Length == 0 ? [] : s.Split(" | ").Select(x => new FPlaneData<TInt16>()
            {
                FirstHalfEdgeIndex = new() { Value = Int16.Parse(x[0..x.IndexOf(' ')]) },
                NumHalfEdges = new() { Value = Int16.Parse(x[(x.IndexOf(' ') + 1)..]) }
            }).ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<FPlaneData<TInt16>> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => $"{x.FirstHalfEdgeIndex} {x.NumHalfEdges}")));
        }
    }

    public class FPlaneDataJsonConverterTUInt8 : JsonConverter<List<FPlaneData<TUInt8>>>
    {
        public override List<FPlaneData<TUInt8>> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string s = reader.GetString();
            return s.Length == 0 ? [] : s.Split(" | ").Select(x => new FPlaneData<TUInt8>()
            {
                FirstHalfEdgeIndex = new() { Value = Byte.Parse(x[0..x.IndexOf(' ')]) },
                NumHalfEdges = new() { Value = Byte.Parse(x[(x.IndexOf(' ') + 1)..]) }
            }).ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<FPlaneData<TUInt8>> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => $"{x.FirstHalfEdgeIndex} {x.NumHalfEdges}")));
        }
    }
    #endregion

    #region FHalfEdgeData
    [DebuggerDisplay("{PlaneIndex} {VertexIndex} {TwinHalfEdgeIndex}")]
    public class FHalfEdgeData<FIndex> : ITransferable where FIndex : ITransferable, new()
    {
        public FIndex PlaneIndex;
        public FIndex VertexIndex;
        public FIndex TwinHalfEdgeIndex;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref PlaneIndex);
            transfer.Move(ref VertexIndex);
            transfer.Move(ref TwinHalfEdgeIndex);
            return this;
        }
    }

    public class FHalfEdgeDataJsonConverterTInt32 : JsonConverter<List<FHalfEdgeData<TInt32>>>
    {
        public override List<FHalfEdgeData<TInt32>> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string s = reader.GetString();
            return s.Length == 0 ? [] : s.Split(" | ").Select(x =>
            {
                var parts = x.Split(' ');
                return new FHalfEdgeData<TInt32>()
                {
                    PlaneIndex = new() { Value = Int32.Parse(parts[0]) },
                    VertexIndex = new() { Value = Int32.Parse(parts[1]) },
                    TwinHalfEdgeIndex = new() { Value = Int32.Parse(parts[2]) }
                };
            }).ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<FHalfEdgeData<TInt32>> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => $"{x.PlaneIndex} {x.VertexIndex} {x.TwinHalfEdgeIndex}")));
        }
    }

    public class FHalfEdgeDataJsonConverterTInt16 : JsonConverter<List<FHalfEdgeData<TInt16>>>
    {
        public override List<FHalfEdgeData<TInt16>> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string s = reader.GetString();
            return s.Length == 0 ? [] : s.Split(" | ").Select(x =>
            {
                var parts = x.Split(' ');
                return new FHalfEdgeData<TInt16>()
                {
                    PlaneIndex = new() { Value = Int16.Parse(parts[0]) },
                    VertexIndex = new() { Value = Int16.Parse(parts[1]) },
                    TwinHalfEdgeIndex = new() { Value = Int16.Parse(parts[2]) }
                };
            }).ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<FHalfEdgeData<TInt16>> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => $"{x.PlaneIndex} {x.VertexIndex} {x.TwinHalfEdgeIndex}")));
        }
    }

    public class FHalfEdgeDataJsonConverterTUInt8 : JsonConverter<List<FHalfEdgeData<TUInt8>>>
    {
        public override List<FHalfEdgeData<TUInt8>> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string s = reader.GetString();
            return s.Length == 0 ? [] : s.Split(" | ").Select(x =>
            {
                var parts = x.Split(' ');
                return new FHalfEdgeData<TUInt8>()
                {
                    PlaneIndex = new() { Value = Byte.Parse(parts[0]) },
                    VertexIndex = new() { Value = Byte.Parse(parts[1]) },
                    TwinHalfEdgeIndex = new() { Value = Byte.Parse(parts[2]) }
                };
            }).ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<FHalfEdgeData<TUInt8>> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => $"{x.PlaneIndex} {x.VertexIndex} {x.TwinHalfEdgeIndex}")));
        }
    }

    #endregion

    #region FVertexData
    [DebuggerDisplay("{FirstHalfEdgeIndex}")]
    public class FVertexData<FIndex> : ITransferable where FIndex : ITransferable, new()
    {
        public FIndex FirstHalfEdgeIndex;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref FirstHalfEdgeIndex);
            return this;
        }
    }

    public class FVertexDataJsonConverterTInt32 : JsonConverter<List<FVertexData<TInt32>>>
    {
        public override List<FVertexData<TInt32>> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string s = reader.GetString();
            return s.Length == 0 ? [] : s.Split(' ').Select(x => new FVertexData<TInt32>()
            {
                FirstHalfEdgeIndex = new TInt32() { Value = Int32.Parse(x) }
            }).ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<FVertexData<TInt32>> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value.Select(x => $"{x.FirstHalfEdgeIndex}")));
        }
    }

    public class FVertexDataJsonConverterTInt16 : JsonConverter<List<FVertexData<TInt16>>>
    {
        public override List<FVertexData<TInt16>> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string s = reader.GetString();
            return s.Length == 0 ? [] : s.Split(" | ").Select(x => new FVertexData<TInt16>()
            {
                FirstHalfEdgeIndex = new TInt16() { Value = Int16.Parse(x) }
            }).ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<FVertexData<TInt16>> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => $"{x.FirstHalfEdgeIndex}")));
        }
    }

    public class FVertexDataJsonConverterTUInt8 : JsonConverter<List<FVertexData<TUInt8>>>
    {
        public override List<FVertexData<TUInt8>> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string s = reader.GetString();
            return s.Length == 0 ? [] : s.Split(" | ").Select(x => new FVertexData<TUInt8>()
            {
                FirstHalfEdgeIndex = new TUInt8() { Value = Byte.Parse(x) }
            }).ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<FVertexData<TUInt8>> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => $"{x.FirstHalfEdgeIndex}")));
        }
    }
    #endregion
}
