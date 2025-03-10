namespace AssetTool
{
    [TransferibleStruct("MovieSceneDoubleChannel")]
    public class FMovieSceneDoubleChannel : FMovieSceneChannel, ITransferible
    {
        public byte PreInfinityExtrap;
        public byte PostInfinityExtrap;
        public Int32 SerializedElementSize;
        public Int32 SerializedElementSize2;
        public List<FFrameNumber> Times;
        public Int32 NewArrayNum;
        public List<FMovieSceneDoubleValue> Values;
        public Int32 NewArrayNum2;
        public FBool bShowCurve;
        public double DefaultValue;
        public FBool bHasDefaultValue;
        public FFrameRate TickResolution;
        public FBool bSerializeShowCurve;

        [Location("bool FMovieSceneDoubleChannel::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            if (!Supports.SerializeFloatChannelCompletely && !Supports.SerializeFloatChannelShowCurve)
            {
                return null;
            }

            transfer.Move(ref PreInfinityExtrap);
            transfer.Move(ref PostInfinityExtrap);
            transfer.Move(ref SerializedElementSize);
            if (SerializedElementSize != FFrameNumber.Size)
            {
                transfer.Move(ref Times);
            }
            else
            {
                transfer.Move(ref NewArrayNum);
                if (NewArrayNum > 0)
                {
                    Times ??= new();
                    Times.Resize(transfer, NewArrayNum);
                    Times.ForEach(x => x.MoveRaw(transfer));
                }
            }
            transfer.Move(ref SerializedElementSize2);
            if (SerializedElementSize2 != FMovieSceneDoubleValue.Size)
            {
                transfer.Move(ref Values);
            }
            else
            {
                transfer.Move(ref NewArrayNum2);
                if (NewArrayNum2 > 0)
                {
                    Values ??= new();
                    Values.Resize(transfer, NewArrayNum2);
                    Values.ForEach(x => x.MoveRaw(transfer));
                }
            }
            transfer.Move(ref DefaultValue);
            transfer.Move(ref bHasDefaultValue);
            transfer.Move(ref TickResolution);
            if (Supports.SerializeFloatChannelShowCurve)
            {
                transfer.Move(ref bShowCurve);
            }
            return this;
        }
    }

    [TransferibleStruct("MovieSceneDoubleValue")]
    public class FMovieSceneDoubleValue : ITransferible, ITransferibleRaw
    {
        public const int Size = 28;

        public double Value;
        public FMovieSceneTangentData Tangent;
        public byte InterpMode;
        public byte TangentMode;
        public byte PaddingByte;
        public byte UnserializedPaddingBytes;

        [Location("bool TMovieSceneCurveChannelImpl<ChannelType>::SerializeChannelValue(ChannelValueType& InValue, FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            if (!Supports.SerializeFloatChannel)
            {
                return null;
            }

            if (Supports.LARGE_WORLD_COORDINATES)
            {
                Value = transfer.Move(Value);
            }
            else
            {
                Value = transfer.Move((float)Value);
            }

            if (!Supports.SerializeFloatChannelCompletely)
            {
                transfer.Move(ref InterpMode);
                transfer.Move(ref TangentMode);
                transfer.Move(ref Tangent);
            }
            else
            {
                Tangent ??= new();
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

        public ITransferible MoveRaw(Transfer transfer)
        {
            transfer.Move(ref Value);
            transfer.MoveRaw(ref Tangent);
            transfer.Move(ref InterpMode);
            transfer.Move(ref TangentMode);
            transfer.Move(ref PaddingByte);
            transfer.Move(ref UnserializedPaddingBytes);
            return this;
        }
    }
}