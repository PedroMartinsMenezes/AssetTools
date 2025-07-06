namespace AssetTool
{
    public struct FMovieSceneTangentData : ITransferible, ITransferibleRaw
    {
        public float ArriveTangent;
        public float LeaveTangent;
        public float ArriveTangentWeight;
        public float LeaveTangentWeight;
        public byte TangentWeightMode;
        public byte UnserializedPaddingBytes1;
        public byte UnserializedPaddingBytes2;
        public byte UnserializedPaddingBytes3;

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
            transfer.Move(ref UnserializedPaddingBytes1);
            transfer.Move(ref UnserializedPaddingBytes2);
            transfer.Move(ref UnserializedPaddingBytes3);
            return this;
        }
    }
}
