namespace AssetTool
{
    [TransferibleStruct("MovieSceneDoubleChannel")]
    public class FMovieSceneDoubleChannel : FMovieSceneChannel, ITransferible
    {
        public byte PreInfinityExtrap;
        public byte PostInfinityExtrap;
        public Int32 TimesElementSize;
        public FFrameNumber[] Times;
        public Int32 ValuesElementSize;
        public FMovieSceneDoubleValue[] Values;
        public FBool bShowCurve;
        public double DefaultValue;
        public FBool bHasDefaultValue;
        public FFrameRate TickResolution;
        public FBool bSerializeShowCurve;

        [Location("bool FMovieSceneDoubleChannel::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            if (!transfer.Supports.SerializeFloatChannelCompletely && !transfer.Supports.SerializeFloatChannelShowCurve)
                return default;

            transfer.Move(ref PreInfinityExtrap);
            transfer.Move(ref PostInfinityExtrap);

            transfer.Move(ref TimesElementSize);
            if (TimesElementSize != FFrameNumber.Size)
                transfer.Move(ref Times);
            else
                transfer.MoveRaw(ref Times);

            transfer.Move(ref ValuesElementSize);
            if (ValuesElementSize != FMovieSceneDoubleValue.Size)
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
    }

    [TransferibleStruct("MovieSceneDoubleValue")]
    public struct FMovieSceneDoubleValue : ITransferible
    {
        public static readonly int Size = System.Runtime.InteropServices.Marshal.SizeOf(typeof(FMovieSceneDoubleValue));

        public double Value;
        public FMovieSceneTangentData Tangent;
        public byte InterpMode;
        public byte TangentMode;
        public byte PaddingByte;
        public byte UnserializedPaddingBytes;

        [Location("bool TMovieSceneCurveChannelImpl<ChannelType>::SerializeChannelValue(ChannelValueType& InValue, FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            if (!transfer.Supports.SerializeFloatChannel)
            {
                return default;
            }
            Value = transfer.Supports.LARGE_WORLD_COORDINATES ? transfer.Move(Value) : transfer.Move((float)Value);
            if (!transfer.Supports.SerializeFloatChannelCompletely)
            {
                transfer.Move(ref InterpMode);
                transfer.Move(ref TangentMode);
                transfer.Move(ref Tangent);
            }
            else
            {
                transfer.Move(ref Tangent.ArriveTangent);
                transfer.Move(ref Tangent.LeaveTangent);
                transfer.Move(ref Tangent.ArriveTangentWeight);
                transfer.Move(ref Tangent.LeaveTangentWeight);
                transfer.Move(ref Tangent.TangentWeightMode);
                transfer.Move(ref InterpMode);
                transfer.Move(ref TangentMode);
                transfer.Move(ref PaddingByte);
            }
            return this;
        }
    }
}