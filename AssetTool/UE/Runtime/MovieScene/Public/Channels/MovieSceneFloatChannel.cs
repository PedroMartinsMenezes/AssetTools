namespace AssetTool
{
    [TransferibleStruct("MovieSceneFloatChannel")]
    public class FMovieSceneFloatChannel : FMovieSceneChannel, ITransferible
    {
        public byte PreInfinityExtrap;
        public byte PostInfinityExtrap;
        public Int32 SerializedElementSize;
        public Int32 SerializedElementSize2;
        public List<FFrameNumber> Times;
        public Int32 NewArrayNum;
        public List<FMovieSceneFloatValue> Values;
        public Int32 NewArrayNum2;
        public FBool bShowCurve;
        public float DefaultValue;
        public FBool bHasDefaultValue;
        public FFrameRate TickResolution;
        public FBool bSerializeShowCurve;

        [Location("bool FMovieSceneFloatChannel::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
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
                    transfer.Move(ref Times, NewArrayNum);
                }
            }
            transfer.Move(ref SerializedElementSize2);
            if (SerializedElementSize2 != FFrameNumber.Size)
            {
                transfer.Move(ref Values);
            }
            else
            {
                transfer.Move(ref NewArrayNum2);
                if (NewArrayNum2 > 0)
                {
                    transfer.Move(ref Values, NewArrayNum2);
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

    public class FMovieSceneFloatValue : ITransferible
    {
        public float Value;
        public FMovieSceneTangentData Tangent;
        public byte InterpMode;
        public byte TangentMode;
        public byte PaddingByte;

        [Location("friend FArchive& operator<<(FArchive& Ar, FMovieSceneFloatValue& P)")]
        public ITransferible Move(Transfer transfer)
        {
            if (Supports.SerializeFloatChannelCompletely)
            {
                return this;
            }

            transfer.Move(ref Value);

            if (!Supports.SerializeFloatChannelCompletely)// Ar.CustomVer(FSequencerObjectVersion::GUID) < FSequencerObjectVersion::SerializeFloatChannelCompletely)
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
    }
}
