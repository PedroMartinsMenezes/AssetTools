using System.Diagnostics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    //[TransferableStruct("Transform")]
    public class FTransform3ElegantJson : ITagConverter, IValueConverter
    {
        public object TagToDerived(object value, int size)
        {
            var dict = value as Dictionary<string, object>;
            for (int i = 0; i < dict.Count - 1; i++)
            {
                if (dict.ElementAt(i).Value is FPropertyTag propertyTag)
                {
                    var itemKey = new BasePropertyJson().BuildKey(propertyTag.StructName.Value, propertyTag);
                    var itemValue = propertyTag.Value;
                    dict.Add(itemKey, itemValue);
                }
            }
            return dict;

        }
    }

    #region Double
    [DebuggerDisplay("T{Translation} R{Rotation} S{Scale3D}")]
    [TransferableStruct("Transform3d")]
    public class FTransform3d : ITransferable, ITagConverter, IDynamicSize
    {
        public FQuat4d Rotation;
        public FVector3d Translation;
        public FVector3d Scale3D;

        #region ITransferable
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Rotation);
            transfer.Move(ref Translation);
            transfer.Move(ref Scale3D);
            return this;
        }
        #endregion

        public int TagSize(Transfer transfer) => FPropertyTag.SimpleStructHeaderSize(transfer) + (Rotation.IsZero() ? 0 : FQuat4d.SIZE) + (Translation.IsZero() ? 0 : FVector3d.SIZE) + (Scale3D.IsZero() ? 0 : FVector3d.SIZE) + 8;
    }

    public class FTransform3dListJsonConverter : JsonConverter<List<FTransform3d>>
    {
        public override List<FTransform3d> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            List<FTransform3d> list = [];
            if (reader.TokenType == JsonTokenType.StartArray)
            {
                if (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
                {
                    _ = reader.GetString();
                }
                while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
                {
                    string line = reader.GetString();
                    string[] items = line.Split(" | ");
                    foreach (var s in items)
                    {
                        FTransform3d obj = new();
                        string[] v = s.Split(" ; ");

                        double[] v1 = v[0].ToDoubleArray();
                        obj.Translation = new FVector3d { X = v1[0], Y = v1[1], Z = v1[2] };

                        double[] v2 = v[1].ToDoubleArray();
                        obj.Rotation = new FQuat4d { X = v2[0], Y = v2[1], Z = v2[2], W = v2[3] };

                        double[] v3 = v[2].ToDoubleArray();
                        obj.Scale3D = new FVector3d { X = v3[0], Y = v3[1], Z = v3[2] };

                        list.Add(obj);
                    }
                }
            }
            return list;
        }

        public override void Write(Utf8JsonWriter writer, List<FTransform3d> value, JsonSerializerOptions options)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            writer.WriteStartArray();
            writer.WriteStringValue("Translation ; Rotation ; Scale3D = X Y Z ; X Y Z W ; X Y Z");
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < value.Count; i++)
            {
                var v = value[i];
                s.Append($"{v.Translation.X} {v.Translation.Y} {v.Translation.Z} ; ");
                s.Append($"{v.Rotation.X} {v.Rotation.Y} {v.Rotation.Z} {v.Rotation.W} ; ");
                s.Append($"{v.Scale3D.X} {v.Scale3D.Y} {v.Scale3D.Z}");
                if (i < value.Count - 1)
                {
                    s.Append(" | ");
                }
            }
            writer.WriteStringValue(s.ToString());
            writer.WriteEndArray();
        }
    }
    #endregion

    #region Float
    [DebuggerDisplay("T{Translation} R{Rotation} S{Scale3D}")]
    [TransferableStruct("Transform3f")]
    public class FTransform3f : ITransferable, ITagConverter, IDynamicSize
    {
        public const int SIZE = 195;
        public const string StructName = "Transform3f";

        public FQuat4f Rotation;
        public FVector3f Translation;
        public FVector3f Scale3D;

        #region ITransferable
        public ITransferable Move(Transfer transfer)
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

    public class FTransform3fListJsonConverter : JsonConverter<List<FTransform3f>>
    {
        public override List<FTransform3f> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            List<FTransform3f> list = [];
            if (reader.TokenType == JsonTokenType.StartArray)
            {
                if (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
                {
                    _ = reader.GetString();
                }
                while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
                {
                    string line = reader.GetString();
                    string[] items = line.Split(" | ");
                    foreach (var s in items)
                    {
                        FTransform3f obj = new();
                        string[] v = s.Split(" ; ");

                        float[] v1 = v[0].ToFloatArray();
                        obj.Translation = new FVector3f { X = v1[0], Y = v1[1], Z = v1[2] };

                        float[] v2 = v[1].ToFloatArray();
                        obj.Rotation = new FQuat4f { X = v2[0], Y = v2[1], Z = v2[2], W = v2[3] };

                        float[] v3 = v[2].ToFloatArray();
                        obj.Scale3D = new FVector3f { X = v3[0], Y = v3[1], Z = v3[2] };

                        list.Add(obj);
                    }
                }
            }
            return list;
        }

        public override void Write(Utf8JsonWriter writer, List<FTransform3f> value, JsonSerializerOptions options)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            writer.WriteStartArray();
            writer.WriteStringValue("Translation ; Rotation ; Scale3D = X Y Z ; X Y Z W ; X Y Z");
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < value.Count; i++)
            {
                var v = value[i];
                s.Append($"{v.Translation.X} {v.Translation.Y} {v.Translation.Z} ; ");
                s.Append($"{v.Rotation.X} {v.Rotation.Y} {v.Rotation.Z} {v.Rotation.W} ; ");
                s.Append($"{v.Scale3D.X} {v.Scale3D.Y} {v.Scale3D.Z}");
                if (i < value.Count - 1)
                {
                    s.Append(" | ");
                }
            }
            writer.WriteStringValue(s.ToString());
            writer.WriteEndArray();
        }
    }
    #endregion

    #region Float or Double
    [DebuggerDisplay("T{Translation} R{Rotation} S{Scale3D}")]
    public class FTransform : ITransferable
    {
        public FQuat Rotation;
        public FVector Translation;
        public FVector Scale3D;

        public ITransferable Move(Transfer transfer)
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
                    string line = reader.GetString();
                    string[] items = line.Split(" | ");
                    foreach (var s in items)
                    {
                        FTransform obj = new();
                        string[] v = s.Split(" ; ");

                        double[] v1 = v[0].ToDoubleArray();
                        obj.Translation = new FVector { X = v1[0], Y = v1[1], Z = v1[2] };

                        double[] v2 = v[1].ToDoubleArray();
                        obj.Rotation = new FQuat { X = v2[0], Y = v2[1], Z = v2[2], W = v2[3] };

                        double[] v3 = v[2].ToDoubleArray();
                        obj.Scale3D = new FVector { X = v3[0], Y = v3[1], Z = v3[2] };

                        list.Add(obj);
                    }
                }
            }
            return list;
        }

        public override void Write(Utf8JsonWriter writer, List<FTransform> value, JsonSerializerOptions options)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            writer.WriteStartArray();
            writer.WriteStringValue("Translation ; Rotation ; Scale3D = X Y Z ; X Y Z W ; X Y Z");
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < value.Count; i++)
            {
                var v = value[i];
                s.Append($"{v.Translation.X} {v.Translation.Y} {v.Translation.Z} ; ");
                s.Append($"{v.Rotation.X} {v.Rotation.Y} {v.Rotation.Z} {v.Rotation.W} ; ");
                s.Append($"{v.Scale3D.X} {v.Scale3D.Y} {v.Scale3D.Z}");
                if (i < value.Count - 1)
                {
                    s.Append(" | ");
                }
            }
            writer.WriteStringValue(s.ToString());
            writer.WriteEndArray();
        }
    }
    #endregion
}
