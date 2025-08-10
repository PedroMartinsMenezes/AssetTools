using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FReferenceSkeleton : ITransferible
    {
        public List<FMeshBoneInfo> RawRefBoneInfo;
        public List<FTransform> RawRefBonePose;
        public Dictionary<FName, TInt32> RawNameToIndexMap;

        [Location("FArchive & operator<<(FArchive & Ar, FReferenceSkeleton & F)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref RawRefBoneInfo);
            transfer.Move(ref RawRefBonePose);

            if (transfer.Supports.VER_UE4_REFERENCE_SKELETON_REFACTOR)
            {
                transfer.Move(ref RawNameToIndexMap);
            }

            return this;
        }
    }

    public class FMeshBoneInfo : ITransferible
    {
        public FName Name;
        public Int32 ParentIndex;
        public FColor DummyColor;
        public FString ExportName;

        [Location("FArchive &operator<<(FArchive& Ar, FMeshBoneInfo& F)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Name);
            transfer.Move(ref ParentIndex);
            if (!transfer.Supports.VER_UE4_REFERENCE_SKELETON_REFACTOR)
            {
                transfer.Move(ref DummyColor);
            }
            if (transfer.Supports.VER_UE4_STORE_BONE_EXPORT_NAMES && !transfer.GlobalObjects.IsFilterEditorOnly())
            {
                transfer.Move(ref ExportName);
            }
            return this;
        }
    }

    public class FMeshBoneInfoListJsonConverter : JsonConverter<List<FMeshBoneInfo>>
    {
        public override List<FMeshBoneInfo> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            List<FMeshBoneInfo> list = [];
            if (reader.TokenType == JsonTokenType.StartArray)
            {
                if (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
                {
                    _ = reader.GetString();
                }
                while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
                {
                    FMeshBoneInfo item = new();
                    string s = reader.GetString();

                    (int a, int b) = (s.IndexOf('(') + 1, s.IndexOf(')'));
                    string text = s.Substring(a, b - a);
                    item.Name = new FName(text);

                    (a, b) = (s.IndexOf('(', b + 1) + 1, s.IndexOf(')', b + 1));
                    text = s.Substring(a, b - a);
                    item.ParentIndex = int.Parse(text);

                    (a, b) = (s.IndexOf('(', b + 1) + 1, s.IndexOf(')', b + 1));
                    text = s.Substring(a, b - a);
                    item.ExportName = text.Length > 0 ? new FString(text) : default;

                    (a, b) = (s.IndexOf('(', b + 1) + 1, s.IndexOf(')', b + 1));
                    text = s.Substring(a, b - a);
                    byte[] bytes = text.Length > 0 ? s.Substring(a, b - a).ToByteArray() : [];
                    item.DummyColor = text.Length > 0 ? new FColor { R = bytes[0], G = bytes[1], B = bytes[2], A = bytes[3] } : default;

                    list.Add(item);
                }
            }
            return list;
        }

        public override void Write(Utf8JsonWriter writer, List<FMeshBoneInfo> value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            writer.WriteStringValue("(Name) (ParentIndex) (ExportName) (DummyColor)");
            foreach (var v in value)
            {
                writer.WriteStringValue($"({v.Name}) ({v.ParentIndex}) ({v.ExportName}) ({v.DummyColor})");
            }
            writer.WriteEndArray();
        }
    }
}
