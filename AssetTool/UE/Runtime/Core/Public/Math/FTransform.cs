using System.Diagnostics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    //[TransferibleStruct("Transform")]
    public class FTransform3ElegantJson : ITagConverter, IValueConverter
    {
        public object TagToDerived
            (object value, int size)
        {
            var dict = value as Dictionary<string, object>;
            for (int i = 0; i < dict.Count - 1; i++)
            {
                if (dict.ElementAt(i).Value is FPropertyTag propertyTag)
                {
                    var itemKey = BasePropertyJson.BuildKey(propertyTag.StructName.Value, propertyTag);
                    var itemValue = propertyTag.Value;
                    dict.Add(itemKey, itemValue);
                }
            }
            return dict;

        }
    }

    #region Double
    //[TransferibleStruct("Transform3d", "Transform", 235)]
    [DebuggerDisplay("T{Translation} R{Rotation} S{Scale3D}")]
    public class FTransform3d : ITransferible, ITagConverter, IDynamicSize
    {
        public FQuat4d Rotation;
        public FVector3d Translation;
        public FVector3d Scale3D;

        #region ITransferible
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Rotation);
            transfer.Move(ref Translation);
            transfer.Move(ref Scale3D);
            return this;
        }
        #endregion

        public int TagSize(Transfer transfer) => FPropertyTag.SimpleStructHeaderSize(transfer) + (Rotation.IsZero() ? 0 : FQuat4d.SIZE) + (Translation.IsZero() ? 0 : FVector3d.SIZE) + (Scale3D.IsZero() ? 0 : FVector3d.SIZE) + 8;
    }
    #endregion

    #region Float
    [DebuggerDisplay("T{Translation} R{Rotation} S{Scale3D}")]
    public class FTransform3f : ITransferible, ITagConverter, IDynamicSize
    {
        public const int SIZE = 195;
        public const string StructName = "Transform3f";

        public FQuat4f Rotation;
        public FVector3f Translation;
        public FVector3f Scale3D;

        #region ITransferible
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Rotation);
            transfer.Move(ref Translation);
            transfer.Move(ref Scale3D);
            return this;
        }
        #endregion

        #region ITagConverter
        public int TagSize(Transfer transfer) => FPropertyTag.SimpleStructHeaderSize(transfer) + (Rotation.IsZero() ? 0 : FQuat4f.SIZE) + (Translation.IsZero() ? 0 : FVector3f.SIZE) + (Scale3D.IsZero() ? 0 : FVector3f.SIZE) + 8;
        #endregion
    }
    #endregion

    #region Float or Double
    [DebuggerDisplay("T{Translation} R{Rotation} S{Scale3D}")]
    public class FTransform : ITransferible
    {
        public FQuat Rotation;
        public FVector Translation;
        public FVector Scale3D;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Rotation);
            transfer.Move(ref Translation);
            transfer.Move(ref Scale3D);
            return this;
        }
    }

    public class FTransformListJsonConverter : JsonConverter<List<FTransform>>
    {
        public override List<FTransform> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            List<FTransform> list = [];
            if (reader.TokenType == JsonTokenType.StartArray)
            {
                if (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
                {
                    _ = reader.GetString();
                }
                while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
                {
                    FTransform item = new();
                    string s = reader.GetString();

                    (int a, int b) = (s.IndexOf('(') + 1, s.IndexOf(')'));
                    double[] v = s.Substring(a, b - a).ToDoubleArray();
                    item.Translation = new FVector { X = v[0], Y = v[1], Z = v[2] };

                    (a, b) = (s.IndexOf('(', b + 1) + 1, s.IndexOf(')', b + 1));
                    v = s.Substring(a, b - a).ToDoubleArray();
                    item.Rotation = new FQuat { X = v[0], Y = v[1], Z = v[2], W = v[3] };

                    (a, b) = (s.IndexOf('(', b + 1) + 1, s.IndexOf(')', b + 1));
                    v = s.Substring(a, b - a).ToDoubleArray();
                    item.Scale3D = new FVector { X = v[0], Y = v[1], Z = v[2] };

                    list.Add(item);
                }
            }
            return list;
        }

        public override void Write(Utf8JsonWriter writer, List<FTransform> value, JsonSerializerOptions options)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            writer.WriteStartArray();
            writer.WriteStringValue("(Translation) (Rotation) (Scale3D)");
            foreach (var v in value)
            {
                StringBuilder s = new StringBuilder();
                s.Append($"({v.Translation.X} {v.Translation.Y} {v.Translation.Z}) ");
                s.Append($"({v.Rotation.X} {v.Rotation.Y} {v.Rotation.Z} {v.Rotation.W}) ");
                s.Append($"({v.Scale3D.X} {v.Scale3D.Y} {v.Scale3D.Z})");
                writer.WriteStringValue(s.ToString());
            }
            writer.WriteEndArray();
        }
    }
    #endregion
}
