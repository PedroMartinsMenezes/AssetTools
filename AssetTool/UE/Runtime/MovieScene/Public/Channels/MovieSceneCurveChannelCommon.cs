using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FMovieSceneTangentData : ITransferable, ITransferableRaw
    {
        public float ArriveTangent;
        public float LeaveTangent;
        public float ArriveTangentWeight;
        public float LeaveTangentWeight;
        public byte TangentWeightMode;
        public byte UnserializedPaddingBytes1;
        public byte UnserializedPaddingBytes2;
        public byte UnserializedPaddingBytes3;

        public bool IsZero() => ArriveTangent == 0.0f && LeaveTangent == 0.0f && ArriveTangentWeight == 0.0f && LeaveTangentWeight == 0.0f && TangentWeightMode == 0 && UnserializedPaddingBytes1 == 0 && UnserializedPaddingBytes2 == 0 && UnserializedPaddingBytes3 == 0;

        [Location("bool FMovieSceneTangentData::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            if (!transfer.Supports.SerializeFloatChannel)
            {
                return this;
            }

            if (!transfer.Supports.SerializeFloatChannelCompletely)
            {
                transfer.Move(ref ArriveTangent);
                transfer.Move(ref LeaveTangent);
                transfer.Move(ref TangentWeightMode);
                transfer.Move(ref ArriveTangentWeight);
                transfer.Move(ref LeaveTangentWeight);
            }
            else
            {
                transfer.Move(ref ArriveTangent);
                transfer.Move(ref LeaveTangent);
                transfer.Move(ref ArriveTangentWeight);
                transfer.Move(ref LeaveTangentWeight);
                transfer.Move(ref TangentWeightMode);
            }

            return this;
        }

        public ITransferable MoveRaw(Transfer transfer)
        {
            transfer.Move(ref ArriveTangent);
            transfer.Move(ref LeaveTangent);
            transfer.Move(ref ArriveTangentWeight);
            transfer.Move(ref LeaveTangentWeight);
            transfer.Move(ref TangentWeightMode);
            transfer.Move(ref UnserializedPaddingBytes1);
            transfer.Move(ref UnserializedPaddingBytes2);
            transfer.Move(ref UnserializedPaddingBytes3);
            return this;
        }

        public override string ToString()
        {
            StringBuilder builder = new();
            if (ArriveTangent.IsNonZero()) builder.AppendNonNull("ArriveTangent({0}) ", ArriveTangent);
            if (LeaveTangent.IsNonZero()) builder.AppendNonNull("LeaveTangent({0}) ", LeaveTangent);
            if (ArriveTangentWeight.IsNonZero()) builder.AppendNonNull("ArriveTangentWeight({0}) ", ArriveTangentWeight);
            if (LeaveTangentWeight.IsNonZero()) builder.AppendNonNull("LeaveTangentWeight({0}) ", LeaveTangentWeight);
            if (TangentWeightMode != 0) builder.AppendNonNull("TangentWeightMode({0}) ", TangentWeightMode);
            if (UnserializedPaddingBytes1 != 0) builder.AppendNonNull("UnserializedPaddingBytes1({0}) ", UnserializedPaddingBytes1);
            if (UnserializedPaddingBytes2 != 0) builder.AppendNonNull("UnserializedPaddingBytes2({0}) ", UnserializedPaddingBytes2);
            if (UnserializedPaddingBytes3 != 0) builder.AppendNonNull("UnserializedPaddingBytes3({0}) ", UnserializedPaddingBytes3);
            return builder.ToString();
        }

        public static FMovieSceneTangentData FromString(string s)
        {
            FMovieSceneTangentData result = new();
            result.ArriveTangent = s.GetNonNull("ArriveTangent({0})", (x) => float.Parse(x));
            result.LeaveTangent = s.GetNonNull("LeaveTangent({0})", (x) => float.Parse(x));
            result.ArriveTangentWeight = s.GetNonNull("ArriveTangentWeight({0})", (x) => float.Parse(x));
            result.LeaveTangentWeight = s.GetNonNull("LeaveTangentWeight({0})", (x) => float.Parse(x));
            result.TangentWeightMode = s.GetNonNull("TangentWeightMode({0})", (x) => byte.Parse(x));
            result.UnserializedPaddingBytes1 = s.GetNonNull("UnserializedPaddingBytes1({0})", (x) => byte.Parse(x));
            result.UnserializedPaddingBytes2 = s.GetNonNull("UnserializedPaddingBytes2({0})", (x) => byte.Parse(x));
            result.UnserializedPaddingBytes3 = s.GetNonNull("UnserializedPaddingBytes3({0})", (x) => byte.Parse(x));
            return result;
        }
    }

    public class FMovieSceneTangentDataJsonConverter : JsonConverter<FMovieSceneTangentData>
    {
        public override FMovieSceneTangentData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            FMovieSceneTangentData result = new();
            string text = reader.GetString();
            if (text == "null")
                return result;
            result = FMovieSceneTangentData.FromString(text);
            return result;
        }

        public override void Write(Utf8JsonWriter writer, FMovieSceneTangentData value, JsonSerializerOptions options)
        {
            if (value.IsZero())
                writer.WriteStringValue("null");
            else
                writer.WriteStringValue(value.ToString());
        }
    }
}
