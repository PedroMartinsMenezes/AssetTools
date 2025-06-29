namespace AssetTool
{
    public class FMovieSceneTangentData : ITransferible, ITransferibleRaw
    {
        public float ArriveTangent;
        public float LeaveTangent;
        public float ArriveTangentWeight;
        public float LeaveTangentWeight;
        public byte TangentWeightMode;
        public TUInt8[] UnserializedPaddingBytes = new TUInt8[3];

        [Location("bool FMovieSceneTangentData::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
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

        public ITransferible MoveRaw(Transfer transfer)
        {
            transfer.Move(ref ArriveTangent);
            transfer.Move(ref LeaveTangent);
            transfer.Move(ref ArriveTangentWeight);
            transfer.Move(ref LeaveTangentWeight);
            transfer.Move(ref TangentWeightMode);
            transfer.Move(ref UnserializedPaddingBytes, 3);
            return this;
        }
    }
}
