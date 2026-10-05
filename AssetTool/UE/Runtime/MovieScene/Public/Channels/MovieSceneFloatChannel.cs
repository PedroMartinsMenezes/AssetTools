using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [TransferableStruct("MovieSceneFloatChannel")]
    public class FMovieSceneFloatChannel : FMovieSceneChannel, ITransferable, ITransferableRaw, ITransferablePropertyTag
    {
        public byte PreInfinityExtrap;
        public byte PostInfinityExtrap;
        public Int32 TimesElementSize;
        public List<FFrameNumber> Times;
        public Int32 ValuesElementSize;
        public List<FMovieSceneFloatValue> Values;
        public bool bShowCurve;
        public float DefaultValue;
        public bool bHasDefaultValue;
        public FFrameRate TickResolution;
        public bool bSerializeShowCurve;

        public bool IsPropertyTag(Transfer transfer)
        {
            return !transfer.Supports.SerializeFloatChannelCompletely && !transfer.Supports.SerializeFloatChannelShowCurve;
        }

        [Location("bool FMovieSceneFloatChannel::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            if (IsPropertyTag(transfer))
                return default;

            transfer.Move(ref PreInfinityExtrap);
            transfer.Move(ref PostInfinityExtrap);

            transfer.Move(ref TimesElementSize);
            if (TimesElementSize != FFrameNumber.Size)
                transfer.Move(ref Times);
            else
                transfer.MoveRaw(ref Times);

            transfer.Move(ref ValuesElementSize);
            if (ValuesElementSize != FMovieSceneFloatValue.Size)
                transfer.Move(ref Values);
            else
                transfer.MoveRaw(ref Values);

            transfer.Move(ref DefaultValue);
            transfer.Move(ref bHasDefaultValue);
            transfer.Move(ref TickResolution);

            if (transfer.Supports.SerializeFloatChannelShowCurve)
                transfer.Move(ref bShowCurve);

            return this;
        }

        public ITransferable MoveRaw(Transfer transfer)
        {
            transfer.Move(ref PreInfinityExtrap);
            transfer.Move(ref PostInfinityExtrap);
            transfer.Move(ref TimesElementSize);
            transfer.Move(ref Times);
            transfer.Move(ref ValuesElementSize);
            transfer.Move(ref Values);
            transfer.Move(ref bShowCurve);
            transfer.Move(ref DefaultValue);
            transfer.Move(ref bHasDefaultValue);
            transfer.Move(ref TickResolution);
            transfer.Move(ref bSerializeShowCurve);
            return this;
        }
    }

    [TransferableStruct("MovieSceneFloatValue")]
    public class FMovieSceneFloatValue : ITransferable, ITransferableRaw, ITransferablePropertyTag
    {
        public static readonly int Size = 28;

        public float Value;
        public FMovieSceneTangentData Tangent;
        public byte? InterpMode;
        public byte? TangentMode;
        public byte? PaddingByte;
        public byte? UnserializedPaddingBytes;

        public bool IsPropertyTag(Transfer transfer)
        {
            return !transfer.Supports.SerializeFloatChannel;
        }

        [Location("bool TMovieSceneCurveChannelImpl<ChannelType>::SerializeChannelValue(ChannelValueType& InValue, FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            if (IsPropertyTag(transfer))
                return default;

            transfer.Move(ref Value);

            if (!transfer.Supports.SerializeFloatChannelCompletely)
            {
                transfer.Move(ref InterpMode);
                transfer.Move(ref TangentMode);
                transfer.Move(ref Tangent);
                Tangent = transfer.IsReading && Tangent.IsZero() ? null : Tangent;
            }
            else
            {
                Tangent ??= new();
                transfer.Move(ref Tangent.ArriveTangent);
                transfer.Move(ref Tangent.LeaveTangent);
                transfer.Move(ref Tangent.ArriveTangentWeight);
                transfer.Move(ref Tangent.LeaveTangentWeight);
                transfer.Move(ref Tangent.TangentWeightMode);
                Tangent = transfer.IsReading && Tangent.IsZero() ? null : Tangent;
                transfer.Move(ref InterpMode);
                transfer.Move(ref TangentMode);
                transfer.Move(ref PaddingByte);
            }

            return this;
        }

        public ITransferable MoveRaw(Transfer transfer)
        {
            transfer.Move(ref Value);
            transfer.MoveRaw(ref Tangent);
            Tangent = transfer.IsReading && Tangent.IsZero() ? null : Tangent;
            transfer.Move(ref InterpMode);
            transfer.Move(ref TangentMode);
            transfer.Move(ref PaddingByte);
            transfer.Move(ref UnserializedPaddingBytes);
            return this;
        }

        public override string ToString()
        {
            StringBuilder builder = new();
            builder.AppendNonNull("Value({0}) ", Value);
            if (InterpMode.GetValueOrDefault(0) != 0) builder.AppendNonNull("InterpMode({0}) ", InterpMode);
            if (TangentMode.GetValueOrDefault(0) != 0) builder.AppendNonNull("TangentMode({0}) ", TangentMode);
            if (PaddingByte.GetValueOrDefault(0) != 0) builder.AppendNonNull("PaddingByte({0}) ", PaddingByte);
            if (UnserializedPaddingBytes.GetValueOrDefault(0) != 0) builder.AppendNonNull("UnserializedPaddingBytes({0}) ", UnserializedPaddingBytes);
            if (Tangent is { } && !Tangent.IsZero()) builder.AppendNonNull("Tangent( {0} )", Tangent.ToString());
            return builder.ToString();
        }

        public static FMovieSceneFloatValue FromString(string s)
        {
            FMovieSceneFloatValue result = new();
            result.Value = s.GetNonNull("Value({0})", (x) => float.Parse(x));
            result.InterpMode = s.GetNonNull("InterpMode({0})", (x) => byte.Parse(x));
            result.TangentMode = s.GetNonNull("TangentMode({0})", (x) => byte.Parse(x));
            result.PaddingByte = s.GetNonNull("PaddingByte({0})", (x) => byte.Parse(x));
            result.UnserializedPaddingBytes = s.GetNonNull("UnserializedPaddingBytes({0})", (x) => byte.Parse(x));
            result.Tangent = s.GetNonNull("Tangent( {0} )", (x) => FMovieSceneTangentData.FromString(x));
            return result;
        }
    }

    public class FMovieSceneFloatValueJsonConverter : JsonConverter<FMovieSceneFloatValue>
    {
        public override FMovieSceneFloatValue Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string text = reader.GetString();
            var result = FMovieSceneFloatValue.FromString(text);
            return result;
        }

        public override void Write(Utf8JsonWriter writer, FMovieSceneFloatValue value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
